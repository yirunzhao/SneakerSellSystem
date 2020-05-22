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
    public partial class ShoeInfoForm : Form
    {
        List<Shoe> shoeList = new List<Shoe>();      //记录鞋子信息，所有List的作用都是这样
        public ShoeInfoForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
        }

        private void ShoeInfoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = "select * from Shoe";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Shoe model = new Shoe();
                        model.SID = reader.GetInt32(0);
                        model.Name = reader.GetString(1);
                        model.Price = reader.GetInt32(2);
                        model.Catagory = reader.GetString(3);
                        model.Count = reader.GetInt32(5);
                        shoeList.Add(model);
                    }
                }
            }
            dgvShoes.DataSource = shoeList;
            dgvShoes.Columns["ImagePath"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = (int)dgvShoes.SelectedCells[0].Value;
                string sname = (string)dgvShoes.SelectedCells[1].Value;
                int sprice = (int)dgvShoes.SelectedCells[2].Value;
                string scate = (string)dgvShoes.SelectedCells[3].Value;
                int scount = (int)dgvShoes.SelectedCells[5].Value;

                string sql = "update Shoe set name = @sname, price = @sprice, category = @scate, count = @scount where SID = @sid";
                SqlParameter[] pms = new SqlParameter[]
                {
                new SqlParameter("@sname",SqlDbType.NVarChar,30){Value = sname},
                new SqlParameter("@sprice",SqlDbType.Int){Value = sprice},
                new SqlParameter("@scate",SqlDbType.NVarChar,20){Value = scate},
                new SqlParameter("@scount",SqlDbType.Int){Value = scount},
                new SqlParameter("@sid",SqlDbType.Int){Value = sid},
                };
                int ret = SqlHelper.ExecuteNonQuery(sql, pms);
                if (ret > 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("发生异常" + ee.Message + "\n要求选中当前修改的行！");
            }
        }
    }
}
