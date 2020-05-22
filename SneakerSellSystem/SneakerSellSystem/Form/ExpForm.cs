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
    public partial class ExpForm : Form
    {
        private Member currentUser = new Member();
        private List<BuyInfo> buyInfoList = new List<BuyInfo>();
        public ExpForm()
        {
            InitializeComponent();
        }
        public ExpForm(Member member)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
            currentUser = member;
        }

        private void ExpForm_Load(object sender, EventArgs e)
        {
            //把购物信息都装入List集合中
            LoadBuyData();
        }

        /// <summary>
        /// 装载购物信息
        /// </summary>
        private void LoadBuyData()
        {
            string sql = "select * from BuyInfo where MID = @uid";
            SqlParameter parameter = new SqlParameter("@uid", SqlDbType.Int) { Value = currentUser.MID };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        BuyInfo model = new BuyInfo();
                        model.MID = reader.GetInt32(0);
                        model.CID = reader.GetInt32(1);
                        model.Expressage = reader.GetString(2);
                        model.Sname = reader.GetString(3);
                        model.Status = reader.GetBoolean(4);
                        buyInfoList.Add(model);
                        cbbShoe.Items.Add(model.Sname);
                    }
                }
            }
        }
        /// <summary>
        /// 选择combobox的item的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbShoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //暂时不考虑一个人买多个一种鞋子，所以index一直是第一个搜索到的
            BuyInfo temp = new BuyInfo();
            string shoeName = cbbShoe.SelectedItem.ToString();
            int index = buyInfoList.FindIndex(item => item.Sname.Equals(shoeName));
            string sql = "select * from BuyInfo where Sname = '" + shoeName + "'"+"and cid='"+currentUser.CID+"'";
            using(SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        temp.MID = reader.GetInt32(0);
                        temp.CID = reader.GetInt32(1);
                        temp.Expressage = reader.GetString(2);
                        temp.Sname = reader.GetString(3);
                        temp.Status = reader.GetBoolean(4);
                    }
                }
            }
            tbBuyer.Text = currentUser.Name;
            tbStatus.Text = temp.Status ? "已到达" : "运送中";
            tbExp.Text = temp.Expressage;
            tbShoe.Text = temp.Sname;
        }
    }
}
