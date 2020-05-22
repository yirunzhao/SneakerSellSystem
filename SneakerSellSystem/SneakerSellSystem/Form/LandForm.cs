using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SneakerSellSystem
{
    public partial class LandForm : Form
    {
        private MainForm mainForm;
        private Point mousePoint = new Point();
        private RegisterForm registerForm;
        public LandForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - mousePoint.Y;
                this.Left = Control.MousePosition.X - mousePoint.X;
            }
        }

        private void panelMin_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelClose_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出？", "Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //下面的代码是用来移动窗体的
        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackgroundImage = Image.FromFile(@"D:\SneakerSellSystem\ImageResorce\Close2.png");
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackgroundImage = Image.FromFile(@"D:\SneakerSellSystem\ImageResorce\Close1.png");
        }

        private void panelMin_MouseEnter(object sender, EventArgs e)
        {
            panelMin.BackgroundImage = Image.FromFile(@"D:\SneakerSellSystem\ImageResorce\Min2.png");
        }

        private void panelMin_MouseLeave(object sender, EventArgs e)
        {
            panelMin.BackgroundImage = Image.FromFile(@"D:\SneakerSellSystem\ImageResorce\min1.png");
        }
        //移动窗体代码结束

        
        /// <summary>
        /// 登陆操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLand_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string pwd = PwdTextBox.Text;
            string sql = string.Format("select pwd from member where name = '{0}'",name);
            string DbPwd = Convert.ToString(SqlHelper.ExecuteScalar(sql));
            if (pwd != "" && name != "")
            {
                if (DbPwd.Equals(pwd))
                {
                    //传入name，以后调用
                    mainForm = new MainForm(name);
                    this.Hide();
                    //延时一下，防止太快
                    Thread.Sleep(200);
                    //展示mainForm
                    mainForm.ShowDialog();
                    //退出线程
                    Application.ExitThread();
                }
                else
                {
                    MessageBox.Show("用户名或者密码不正确", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空！", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRigst_Click(object sender, EventArgs e)
        {
            registerForm = new RegisterForm();
            Thread.Sleep(100);
            registerForm.ShowDialog();
        }
    }
}
