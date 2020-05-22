using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SneakerSellSystem
{
    public partial class LotteryForm : Form
    {
        // 记录抽奖次数
        // 3次内抽中给2666,5次内抽中给1666，其他给666
        private int count;
        private Member currentUser = new Member();

        public LotteryForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
        }
        public LotteryForm(Member member)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
            currentUser = member;
        }
        private void LotteryForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            label5.Text = random.Next(2).ToString();
            label6.Text = random.Next(2).ToString();
            label7.Text = random.Next(2).ToString();

            count = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (currentUser.Level != 4)
                currentUser.Point -= 20;
            if (currentUser.Point < 20 && currentUser.Level < 4)
            {
                MessageBox.Show("积分不足！");
                return;
            }
            
            label2.Text = random.Next(2).ToString();
            label3.Text = random.Next(2).ToString();
            label4.Text = random.Next(2).ToString();

            count++;
            if (label5.Text.Equals(label2.Text) && label6.Text.Equals(label3.Text) && label7.Text.Equals(label4.Text))
            {
                //中奖，可以进行一些操作
                if(count <= 3)
                {
                    MessageBox.Show("恭喜中奖！奖金2666元！");
                    currentUser.Balance += 666;
                }
                else if(count <= 5)
                {
                    MessageBox.Show("恭喜中奖！奖金1666元！");
                    currentUser.Balance += 1666;
                }
                else
                {
                    MessageBox.Show("恭喜中奖！奖金666元！");
                    currentUser.Balance += 666;
                }
                count = 0;
                UpdateBalance();
            }

        }

        private void UpdateBalance()
        {
            //string sql = "update Card set balance = '" + currentUser.Balance + "'";
            string sql = string.Format("update Card set balance = {0}, point = {1}" +
                "where CID = {2}", currentUser.Balance, currentUser.Point,currentUser.CID);
            SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
