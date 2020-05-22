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
    public partial class ExpUpdateForm : Form
    {
        private List<BuyInfo> buyInfoList = new List<BuyInfo>();
        public ExpUpdateForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
        }

        private void ExpUpdateForm_Load(object sender, EventArgs e)
        {
            LoadBuyData();
        }

        private void LoadBuyData()
        {
            string sql = "select * from BuyInfo";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
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
                    }
                }
            }
            dgvExp.DataSource = buyInfoList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //将对应的物流状态转变
                int mid = (int)dgvExp.SelectedCells[0].Value;
                string name = (string)dgvExp.SelectedCells[3].Value;
                bool status = (bool)dgvExp.SelectedCells[4].Value;

                string sql = string.Format("update BuyInfo set status = '{0}' where MID = '{1}' " +
                        "and Sname = '{2}'",status, mid, name);
                int r = SqlHelper.ExecuteNonQuery(sql);
                if (r > 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败! ");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("发生异常" + ee.Message + "\n要求选中当前修改的行！");
            }
        }
    }
}
