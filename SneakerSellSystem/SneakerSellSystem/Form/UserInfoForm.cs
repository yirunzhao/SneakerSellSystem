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
    public partial class UserInfoForm : Form
    {
        List<Member> memberList = new List<Member>();
        public UserInfoForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = "select * from Member inner join Card on member.cid = card.cid";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Member model = new Member();
                        model.MID = Convert.ToInt32(reader[0]);
                        model.Password = Convert.ToString(reader[1]);
                        model.Address = Convert.ToString(reader[2]);
                        model.Email = Convert.ToString(reader[3]);
                        model.Name = Convert.ToString(reader[4]);
                        model.PhoneNumber = Convert.ToString(reader[5]);
                        model.CID = Convert.ToInt32(reader[6]);
                        model.Level = Convert.ToInt32(reader[8]);
                        model.Balance = Convert.ToInt32(reader[9]);
                        model.Point = Convert.ToInt32(reader[10]);
                        memberList.Add(model);
                    }
                }
            }
            this.dgvUserInfo.DataSource = memberList;
        }
    }
}
