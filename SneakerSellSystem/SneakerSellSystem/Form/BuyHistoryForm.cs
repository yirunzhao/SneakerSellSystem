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
    public partial class BuyHistoryForm : Form
    {
        List<BuyInfo> buyInfos = new List<BuyInfo>();
        private int mid;
        public BuyHistoryForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
        }
        public BuyHistoryForm(int MID)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
            mid = MID;
        }
        private void BuyHistoryForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from BuyInfo where MID = @uid";
            SqlParameter parameter = new SqlParameter("@uid", SqlDbType.Int) { Value = mid };
            using(SqlDataReader reader = SqlHelper.ExecuteReader(sql,parameter))
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
                        buyInfos.Add(model);
                    }
                }
            }
            dgvHistory.DataSource = buyInfos;
        }
    }
}
