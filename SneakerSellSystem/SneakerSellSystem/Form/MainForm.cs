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
    public partial class MainForm : Form
    {
        //得到当前登录用户的信息
        private Member currentUser = new Member();


        //各种窗体
        private LotteryForm lotteryForm;
        private ShoeInfoForm shoeForm;
        private UserInfoForm userForm;
        private BuyHistoryForm historyForm;
        private MyInfoForm myInfoForm;
        private ExpForm expForm;
        private ExpUpdateForm expUpdateForm;


        //使用List存储鞋子的信息
        public List<Shoe> shoeList = new List<Shoe>();
        //currentShoe记录当前鞋子的索引
        int currentShoe = 2;

        /// <summary>
        /// 重载的构造函数，用于传递用户名信息
        /// </summary>
        /// <param name="name"></param>
        public MainForm(string name)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
            this.currentUser.Name = name;
        }
        public MainForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
        }
        //timer计时，每隔一秒钟更新一下右下方的时钟
        private void timer1_Tick(object sender, EventArgs e)
        {
            tssTimeDisp.Text = DateTime.Now.ToString();
        }
        //退出应用
        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //加载窗体的时候，把uesr显示到最下方状态栏
            tssUserDisp.Text = currentUser.Name;
            //将当前用户的所有信息加载到currentUser对象中
            LoadUserInfo();
            //根据数据库将图片的路径保存在List中
            LoadShoeData();
            //将前两双鞋的信息展示
            FirstTwoShoes();
        }


        /// <summary>
        /// 根据LandForm传过来的用户名得到用户信息，并且装载到记录当前用户信息的currentUser里面
        /// </summary>
        private void LoadUserInfo()
        {
            string sql = "select * from Member where name = @uname";
            SqlParameter[] pms = new SqlParameter[]
            {new SqlParameter("@uname", SqlDbType.NVarChar, 20) { Value = currentUser.Name } };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql,pms))
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
            //为了方便，把Card表中的信息一起装入Member类中
            string sql2 = "select * from Card where cid = @ucid";
            SqlParameter parameter = new SqlParameter("@ucid", SqlDbType.Int) { Value = currentUser.CID };
            using(SqlDataReader reader = SqlHelper.ExecuteReader(sql2, parameter))
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
        /// <summary>
        /// 展示界面加载的时候的前两双鞋
        /// </summary>
        private void FirstTwoShoes()
        {
            pictureBox1.Image = Image.FromFile(@shoeList[0].ImagePath);
            lblCata1.Text = shoeList[0].Catagory;
            lblName1.Text = shoeList[0].Name;
            lblPrice1.Text = shoeList[0].Price.ToString();

            pictureBox2.Image = Image.FromFile(@shoeList[1].ImagePath);
            lblCata2.Text = shoeList[1].Catagory;
            lblName2.Text = shoeList[1].Name;
            lblPrice2.Text = shoeList[1].Price.ToString();
        }


        /// <summary>
        /// 将鞋子信息从shoeInfo表中录入shoeList中去，方便以后的操作
        /// </summary>
        private void LoadShoeData()
        {
            string sql = "select * from Shoe";
            using(SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Shoe shoe = new Shoe();
             
                        shoe.SID = Convert.ToInt32(reader[0]);
                        shoe.Name = Convert.ToString(reader[1]);
                        shoe.Price = Convert.ToInt32(reader[2]);
                        shoe.Catagory = Convert.ToString(reader[3]);
                        shoe.ImagePath = Convert.ToString(reader[4]);
                        shoe.Count = Convert.ToInt32(reader[5]);
                        //把鞋子添加进List
                        shoeList.Add(shoe);
                    }
                }
            }
        }

        private void tsBtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author : WHU.CS.ZYR\n" +
                "Version : 1.1.0\n" + "Github repo address: https://github.com/yirunzhao/SneakerSellSystem" + "\n", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 查看信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 如果是管理员
            if (currentUser.Level == 4)
            {
                userForm = new UserInfoForm();
                userForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("你的权限不够，只有管理员能进行操作！","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 查看商品库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentUser.Level == 4)
            {
                shoeForm = new ShoeInfoForm();
                shoeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("你的权限不够，只有管理员能进行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsBtnMemInfo_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
            myInfoForm = new MyInfoForm(currentUser);
            myInfoForm.ShowDialog();
        }

        private void tsBtnExpInfo_Click(object sender, EventArgs e)
        {
            expForm = new ExpForm(currentUser);
            expForm.ShowDialog();
        }

        private void tsBtnHistory_Click(object sender, EventArgs e)
        {
            historyForm = new BuyHistoryForm(currentUser.MID);
            historyForm.ShowDialog();
        }

        private void tsBtnLottery_Click(object sender, EventArgs e)
        {
            lotteryForm = new LotteryForm(currentUser);
            lotteryForm.ShowDialog();
        }

        private void 更新物流信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentUser.Level == 4)
            {
                expUpdateForm = new ExpUpdateForm();
                expUpdateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("你的权限不够，只有管理员能进行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region 关于上下翻页
        private void lblLater_MouseEnter(object sender, EventArgs e)
        {
            lblLater.ForeColor = Color.FromArgb(132,112,255);
        }

        private void lblLater_MouseLeave(object sender, EventArgs e)
        {
            lblLater.ForeColor = Color.Black;
        }

        private void lblFormer_MouseEnter(object sender, EventArgs e)
        {
            lblFormer.ForeColor = Color.FromArgb(132, 112, 255);
        }

        private void lblFormer_MouseLeave(object sender, EventArgs e)
        {
            lblFormer.ForeColor = Color.Black;
        }


        /// <summary>
        /// 向后翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLater_Click(object sender, EventArgs e)
        {
            if (currentShoe + 1 < shoeList.Count)
            {
                //设置第一个信息
                pictureBox1.Image = Image.FromFile(@shoeList[currentShoe].ImagePath);
                lblCata1.Text = shoeList[currentShoe].Catagory;
                lblName1.Text = shoeList[currentShoe].Name;
                lblPrice1.Text = shoeList[currentShoe].Price.ToString();

                //设置第二个信息
                pictureBox2.Image = Image.FromFile(@shoeList[currentShoe + 1].ImagePath);
                lblCata2.Text = shoeList[currentShoe + 1].Catagory;
                lblName2.Text = shoeList[currentShoe + 1].Name;
                lblPrice2.Text = shoeList[currentShoe + 1].Price.ToString();
                currentShoe += 2;
            }
            else
            {
                MessageBox.Show("已经是最后一页了！");
            }
        }

        /// <summary>
        /// 向前翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblFormer_Click(object sender, EventArgs e)
        {
            if (currentShoe - 2 >= 0)
            {
                currentShoe -= 2;
                //设置第一个信息
                pictureBox1.Image = Image.FromFile(@shoeList[currentShoe].ImagePath);
                lblCata1.Text = shoeList[currentShoe].Catagory;
                lblName1.Text = shoeList[currentShoe].Name;
                lblPrice1.Text = shoeList[currentShoe].Price.ToString();
                //设置第二个信息
                pictureBox2.Image = Image.FromFile(@shoeList[currentShoe + 1].ImagePath);
                lblCata2.Text = shoeList[currentShoe + 1].Catagory;
                lblName2.Text = shoeList[currentShoe + 1].Name;
                lblPrice2.Text = shoeList[currentShoe + 1].Price.ToString();
            }
            else
            {
                MessageBox.Show("不能再前了！");
            }
        }
        #endregion

        private void UpdateCardData()
        {
            string sql = "update Card set cLevel = @level,balance = @bal,point = @point " +
                                "where CID = @cid";
            SqlParameter[] pms = new SqlParameter[]
            {
                                new SqlParameter("@level",SqlDbType.Int){Value = currentUser.Level},
                                new SqlParameter("@bal",SqlDbType.Int){Value = currentUser.Balance},
                                new SqlParameter("@point",SqlDbType.Int){Value = currentUser.Point},
                                new SqlParameter("@CID",SqlDbType.Int){Value = currentUser.CID}
            };
            SqlHelper.ExecuteNonQuery(sql, pms);
        }

        /// <summary>
        /// 更新鞋子信息
        /// </summary>
        /// <param name="select">选择更新左列还是右列的信息，1代表左，2代表右</param>
        private void UpdateShoeData(int select)
        {
            //根据select找到对应的信息
            int index;
            if (select == 1)
            {
                index = shoeList.FindIndex(item => item.Name.Equals(lblName1.Text));
            }
            else
            {
                index = shoeList.FindIndex(item => item.Name.Equals(lblName2.Text));
            }
            string sql = "update Shoe set count = @scnt where sid=@sid";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@scnt",SqlDbType.Int){Value = --shoeList[index].Count},
                new SqlParameter("@sid",SqlDbType.Int){Value = shoeList[index].SID}
            };
            SqlHelper.ExecuteNonQuery(sql,pms);

        }

        /// <summary>
        /// 购买上方的商品，积分达到一定程度会升级会员
        /// 0-----1999 一级会员
        /// 2000-4999 二级会员
        /// 5000-以上 三级会员
        /// 会员等级1需要原价购买，积分是购买价格的10%
        /// 会员等级2打8折，积分是购买价格的20%
        /// 会员等级3打7折，积分是购买价格的30%
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy1_Click(object sender, EventArgs e)
        {
            BuyClick(1);
        }

        private void btnBuy2_Click(object sender, EventArgs e)
        {
            BuyClick(2);
        }

        // dir = 1表示左边， dir = 2表示右边
        private void BuyClick(int dir)
        {
            // 获取索引
            int index = shoeList.FindIndex(item => item.Name.Equals(dir == 1 ? lblName1.Text : lblName2.Text));
            int price = Convert.ToInt32(dir == 1 ? lblPrice1.Text.Trim() : lblPrice2.Text.Trim());

            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@uid",SqlDbType.Int){Value = currentUser.MID},
                new SqlParameter("@cid",SqlDbType.Int){Value = currentUser.CID},
                new SqlParameter("@exp",SqlDbType.NVarChar,16){Value = GetExpName()},
                new SqlParameter("@sname",SqlDbType.NVarChar,40){Value = dir == 1?lblName1.Text: lblName2.Text},
                new SqlParameter("@status",SqlDbType.Bit){Value = 0}
            };
            //PromptOrUpdate(currentUser.Buy(currentUser, pms, price, index, shoeList),2);
            PromptOrUpdate(currentUser.Buy(pms, price, index, shoeList), dir);
        }

        // 随机返回一个快递
        private string GetExpName()
        {
            Random random = new Random();
            int num = random.Next(5);
            string exp = "顺丰";
            switch(num)
            {
                case 0:exp = "顺丰";break;
                case 1:exp = "圆通";break;
                case 2:exp = "京东";break;
                case 3:exp = "中通";break;
                case 4:exp = "菜鸟";break;
                default:break;
            }
            return exp;
        }


        /// <summary>
        /// 用于判断Buy方法的返回结果
        /// </summary>
        /// <param name="returnValue">Buy方法的返回值</param>
        /// <param name="select">选择左右哪一个商品，1是左，2是右</param>
        private void PromptOrUpdate(int returnValue,int select)
        {
            switch (returnValue)
            {
                case 0:
                    MessageBox.Show("你的余额不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    if (currentUser.Level != 4)
                    {
                        MessageBox.Show("商品已经卖完！请联系管理员进行补货！");
                    }
                    else
                    {
                        MessageBox.Show("商品已经卖完！请补货！");
                    }
                    break;
                case 2:
                    {
                        UpdateCardData();
                        UpdateShoeData(select);
                        MessageBox.Show("购买成功！");
                    }
                    break;
                default: break;
            }
        }
    }
}
