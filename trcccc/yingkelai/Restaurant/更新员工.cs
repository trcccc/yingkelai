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
    public partial class 更新员工 : Form
    {
        public string defid = "";
        public string defname = "";
        public string defcardnum = "";
        public string defsex = "";
        public string defage = "";
        public string deftel = "";
        public string defrole = "";


        public 更新员工()
        {
            InitializeComponent();
        }

        private void btn_upok_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txb_upid.Text);
            string name = txb_upname.Text.Trim();
            string cardnum = txb_upcardnum.Text.Trim();
            string sex = cbx_upsex.Text.Trim();
            string age = txb_upage.Text.Trim();
            string tel = txb_uptel.Text.Trim();
            string role = cbx_role.Text.Trim();
            string password = txb_password.Text.Trim();


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            //建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；
            string sqlcom = string.Format(@"update 员工信息 set 员工姓名 = '" + name + "',身份证号 = '" + cardnum + "',性别 = '" + sex + "',年龄 = '" + age + "',电话 = '" + tel + "' where 员工编号 = '" + id + "'");//插入数据是数字就无  ''。。。

            SqlCommand cmd = new SqlCommand(sqlcom, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();

            string sqlcom2 = string.Format(@"update 登录表 set 用户名 = '" + name + "',身份 = '" + role + "',密码 = '" + password + "' where 员工编号 = '" + id + "'");//插入数据是数字就无  ''。。。

            SqlCommand cmd2 = new SqlCommand(sqlcom2, conn);
            SqlDataReader dr2 = cmd.ExecuteReader();
            dr2.Close();

            MessageBox.Show("成功更新员工！！");
            conn.Close();



        }

        private void btn_upcancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void UpdataWorker_Load(object sender, EventArgs e)
        {
            //根据选择要写改的员工，给赋初值
            txb_upid.Text = defid;
            txb_upname.Text = defname;
            txb_upcardnum.Text = defcardnum;
            cbx_upsex.Text = defsex;
            txb_upage.Text = defage;
            txb_uptel.Text = deftel;
            

        }
    }
}
