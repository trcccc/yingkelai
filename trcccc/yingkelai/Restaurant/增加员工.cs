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

namespace Restaurant
{
    public partial class 增加员工 : Form
    {
        public 增加员工()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string id = Worker_ID.Text.Trim();
            string name = Woker_Name.Text.Trim();
            string role = cbx_role.Text.Trim();

            string cardnum = Worker_CardNum.Text.Trim();
            string sex = null;
            string age = Worker_Age.Text.Trim();
            string tel = Worker_Tel.Text.Trim();
            foreach (object sd in this.Controls)
            {
                RadioButton rbt = sd as RadioButton;
                if (rbt != null && rbt.Checked == true)
                {
                    sex = rbt.Text.Trim();
                    break;
                }
            }
            if(id!=""&&role !="")
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

                conn.Open();
                string sqlcom = string.Format(@"insert into 员工信息(密码,员工编号,员工姓名,身份证号,性别,年龄,电话,身份)values('123456','{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id, name, cardnum, sex, age, tel,role);
                SqlCommand cmd = new SqlCommand(sqlcom, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();

                string sqlcom2 = string.Format(@"insert into 登录表(编号,用户名,身份,密码)values('{0}','{1}','{2}','123456')", id, name, role);
                SqlCommand cmd2 = new SqlCommand(sqlcom2, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Close();

                MessageBox.Show("成功插入员工信息！！");
                conn.Close();
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
