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
    public partial class 结账 : Form
    {
        public 结账()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float s1 = float.Parse(textBox2.Text);
            float s2 = float.Parse(textBox1.Text);

            if (s1 < s2)
            {
                MessageBox.Show("钱数不够，请确认付款！！");
            
            }
            else
            { 

                string renturn = Convert.ToString(s1 - s2);
                textBox3.Text = renturn;


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

                conn.Open();

                int desk = Convert.ToInt32(结账和查询.pay_name);
                String sqlcommond1 = string.Format(@"update 桌台信息 set 状态='空闲' where 编号= '" + desk + "' ");
                SqlCommand cmd1 = new SqlCommand(sqlcommond1, conn);
                SqlDataReader sr1 = cmd1.ExecuteReader();
                sr1.Close();

                string sqlcommond2 = string.Format(@"update 点菜信息 set 找零='" + renturn + "',总价格 ='" + s2 + "',实收 ='" + s1 + "'  where 菜单编号= '" + 结账和查询.pay_ordernum + "' ");
                //String sqlcommond2 = string.Format(@"insert into 点菜信息 set 找零='"+renturn +"' where 编号= '" + desk + "' ");
                SqlCommand cmd2 = new SqlCommand(sqlcommond2, conn);
                SqlDataReader sr2 = cmd2.ExecuteReader();
                sr2.Close();

                string sqlcommond3 = string.Format(@"update 具体点菜信息 set 状态='已结账' where 桌台位置= '" + desk + "' ");
                //String sqlcommond2 = string.Format(@"insert into 点菜信息 set 找零='"+renturn +"' where 编号= '" + desk + "' ");
                SqlCommand cmd3 = new SqlCommand(sqlcommond3, conn);
                SqlDataReader sr3 = cmd3.ExecuteReader();
                sr3.Close();

                string sqlcommondkaitai = string.Format(@"delete from 开台表 where 编号 = '" + desk + "'");
                SqlCommand cmd = new SqlCommand(sqlcommondkaitai, conn);
                SqlDataReader sr = cmd.ExecuteReader();
                sr.Close();

                //注意要将sum 清零！！！！
                结账和查询.sum = 0;
            }

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(结账和查询.sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
