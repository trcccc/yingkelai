using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//必须加入
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class 添加菜单 : Form
    {
        public 添加菜单()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();

            String sqlcommondcaixi = String.Format(@"select * from 菜系信息");
            SqlCommand cmdcaixi = new SqlCommand(sqlcommondcaixi, conn);

            SqlDataReader drcaixi = cmdcaixi.ExecuteReader();
            while (drcaixi.Read())
            {
                cbxcaixi.Items.Add(drcaixi["菜系编号"].ToString()+drcaixi["菜系名"].ToString());
            }
            drcaixi.Close();

            conn.Close();





        }

        private void btn_menuok_Click(object sender, EventArgs e)
        {
            string caixi = cbxcaixi.Text.Trim();

            if (caixi[1] >= '0' && caixi[1] <= '9')
            {
                caixi = caixi.Substring(0, 2);

            }
            else 
            {
                caixi = caixi.Substring(0, 1);
            
            }


            string caiming = txbname.Text.Trim();
            float price = float.Parse(txbprice.Text);
            string strConn = @"Data Source=.;Initial Catalog=Restaurant;Integrated Security=SSPI; ";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string sqlcommond = string.Format(@"select * from 菜单信息 where (菜系编号='" + caixi.Substring(0,1) + "') and (菜名 = '" + caiming + "') ");
            SqlCommand cmd = new SqlCommand(sqlcommond, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                dr.Close();

                string sqlcommond1 = string.Format(@"insert into 菜单信息(菜系编号,菜名,价格,折扣)values('{0}','{1}','{2}',1)", caixi, caiming, price);
                SqlCommand cmd1 = new SqlCommand(sqlcommond1, conn);

                SqlDataReader dr1 = cmd1.ExecuteReader();
                MessageBox.Show("成功加入新菜！！");
                dr1.Close();
            }
            else 
            {
                MessageBox.Show("您加的菜已经存在！！");
            
            }
            conn.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
