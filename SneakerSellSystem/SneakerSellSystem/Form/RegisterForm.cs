using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerSellSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void btnRst_Click(object sender, EventArgs e)
        {
            tbAdd.Text = "";
            tbEmail.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            tbPwd.Text = "";
            tbPwdC.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string pwd = tbPwd.Text;
            string pwdC = tbPwdC.Text;
            string email = tbEmail.Text;
            string address = tbAdd.Text;
            string phoneNumber = tbPhone.Text;
            string mid;
            int cid;
            if (pwd != "" && pwdC != "" && name != "" && email != "" && address != "" && phoneNumber != "") 
            {
                if (pwd.Equals(pwdC))
                {
                    //在card表中创建卡，由于外键限制，必须先创建card表中的信息
                    string sqlCard = string.Format("insert into card values(1,0,0)");
                    //倒着插入
                    string sqlFindCid = string.Format("select top 1 cid from card  order by cid desc");

                    SqlHelper.ExecuteNonQuery(sqlCard);
                    cid = Convert.ToInt32(SqlHelper.ExecuteScalar(sqlFindCid));
                    //在member表中创建用户
                    string sql = string.Format("insert into member values('{0}','{1}','{2}','{3}','{4}',{5})", pwd, address, email, name, phoneNumber, cid);
                    SqlHelper.ExecuteNonQuery(sql);
                    string sql2 = string.Format("select mid from member where name='{0}'", name);
                    mid = Convert.ToString(SqlHelper.ExecuteScalar(sql2));
                    MessageBox.Show("创建账户成功，您的账户号码是" + mid + "请您记好!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致！");
                }
            }
            else
            {
                MessageBox.Show("有item没有填写！","错误");
            }
        }
    }
}
