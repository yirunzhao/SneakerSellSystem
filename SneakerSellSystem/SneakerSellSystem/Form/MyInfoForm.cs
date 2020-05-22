using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerSellSystem
{
    public partial class MyInfoForm : Form
    {
        private Member currentUser = new Member();
        public MyInfoForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
        }
        public MyInfoForm(Member user)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
            this.currentUser = user;
        }

        private void MyInfoForm_Load(object sender, EventArgs e)
        {
            //LoadUserInfo();
            tbMid.Text = currentUser.MID.ToString();
            tbAddr.Text = currentUser.Address;
            tbEmail.Text = currentUser.Email;
            tbPhone.Text = currentUser.PhoneNumber;
            tbPwd.Text = currentUser.Password;
            tbName.Text = currentUser.Name;
            tbLevel.Text = currentUser.Level.ToString();
            tbPoint.Text = currentUser.Point.ToString();
            tbBal.Text = currentUser.Balance.ToString();
        }
        #region 减少重复代码，传入member
        private void LoadUserInfo()
        {
            //string sql = "select * from Member where name = '" + currentUser.Name + "'";
            string sql = "select * from Member where name = @uname";
            SqlParameter[] pms = new SqlParameter[]
            {new SqlParameter("@uname", SqlDbType.NVarChar, 20) { Value = currentUser.Name } };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, pms))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        currentUser.MID = Convert.ToInt32(reader[0]);
                        currentUser.Password = Convert.ToString(reader[1]);
                        currentUser.Address = Convert.ToString(reader[2]);
                        currentUser.Email = Convert.ToString(reader[3]);
                        currentUser.PhoneNumber = Convert.ToString(reader[5]);
                        currentUser.CID = Convert.ToInt32(reader[6]);
                    }
                }
            }
            string sql2 = "select * from Card where cid = @ucid";
            SqlParameter parameter = new SqlParameter("@ucid", SqlDbType.Int) { Value = currentUser.CID };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql2, parameter))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        currentUser.Level = Convert.ToInt32(reader[1]);
                        currentUser.Balance = Convert.ToInt32(reader[2]);
                        currentUser.Point = Convert.ToInt32(reader[3]);
                    }
                }
            }
        }
        #endregion
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update Member set name = @uname,pwd = @upwd,address = @uaddr,phoneNumber = @uphone," +
                "email = @uemail where mid = @umid";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@uname",SqlDbType.NVarChar,20){Value = tbName.Text},
                new SqlParameter("@upwd",SqlDbType.VarChar,20){Value = tbPwd.Text},
                new SqlParameter("@uaddr",SqlDbType.NVarChar,60){Value = tbAddr.Text},
                new SqlParameter("@uphone",SqlDbType.Char,11){Value = tbPhone.Text},
                new SqlParameter("@uemail",SqlDbType.VarChar,20){Value = tbEmail.Text},
                new SqlParameter("@umid",SqlDbType.Int){Value = tbMid.Text}
            };
            int r = SqlHelper.ExecuteNonQuery(sql, pms);
            if(r != 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("delete from Member where MID = '{0}'", currentUser.MID);
            string sql2 = string.Format("delete from Card where CID = '{0}'", currentUser.CID);
            string sql3 = string.Format("delete from BuyInfo where MID = '{0}'", currentUser.MID);
            int r1, r2, r3;
            r1 = SqlHelper.ExecuteNonQuery(sql1);
            r2 = SqlHelper.ExecuteNonQuery(sql2);
            r3 = SqlHelper.ExecuteNonQuery(sql3);
            if(r1 > 0 && r2 > 0)
            {
                MessageBox.Show("删除成功！");
            }
        }

        private void btnKe_Click(object sender, EventArgs e)
        {
            currentUser.Balance += 1000;
            string sql = string.Format("update Card set balance = {0} where CID = {1}", currentUser.Balance, currentUser.CID);
            int r = SqlHelper.ExecuteNonQuery(sql);
            if(r > 0)
            {
                MessageBox.Show("氪金成功！");
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
            tbMid.Text = currentUser.MID.ToString();
            tbAddr.Text = currentUser.Address;
            tbEmail.Text = currentUser.Email;
            tbPhone.Text = currentUser.PhoneNumber;
            tbPwd.Text = currentUser.Password;
            tbName.Text = currentUser.Name;
            tbLevel.Text = currentUser.Level.ToString();
            tbPoint.Text = currentUser.Point.ToString();
            tbBal.Text = currentUser.Balance.ToString();
        }
    }
}
