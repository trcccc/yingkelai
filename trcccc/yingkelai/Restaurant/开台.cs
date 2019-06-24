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

namespace Restaurant
{
    public partial class 开台 : Form
    {
        public 开台()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();

            String strcout = comboBox1.Text;
            String strpeoname = comboBox2 .Text;
            String strpeocout = textBox2.Text;
            String strdate = "";

            if (strcout == "")
            {
                MessageBox.Show("请输入要开台的编号！");
            }
            else if (strpeoname == "")
            {
                MessageBox.Show("请输入服务员姓名！");
            }
            else
            {
                String sqlcommond = string.Format(@"select * from 桌台信息 where 编号 ='" + strcout + "'");
                SqlCommand cmd = new SqlCommand(sqlcommond, conn);

                //对SQL或存储过程执行后返回的“结果”进行操作
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("没有该桌号!");
                }
                else if (dr["状态"].ToString().Equals("占用"))
                {
                    MessageBox.Show("该桌号非空闲");
                }
                else
                {
                    String strname = dr["名称"].ToString();
                    strdate = DateTime.Now.ToString();
                    dr.Close();
                    String sqlcommond2 = string.Format(@"insert into 开台表(编号,名称,服务员,人数,日期) values('" + strcout + "','" + strname + "','" + strpeoname + "','" + strpeocout + "','" + strdate + "')");
                    SqlCommand cmd2 = new SqlCommand(sqlcommond2, conn);
                    cmd2.ExecuteNonQuery();
                    String sqlcommond3 = string.Format(@"update 桌台信息 set 状态='占用' where 编号='" + strcout + "'");
                    SqlCommand cmd3 = new SqlCommand(sqlcommond3, conn);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show(strcout + "号开台成功");
                }
                conn.Close();

                
                //this.Hide();//将开台界面隐藏
                点菜 ord = new 点菜(this);
                ord.desknum = comboBox1.Text.Trim();
                ord.servername = comboBox2.Text.Trim();
                ord.peocount = Convert.ToInt32(textBox2.Text.Trim());
                ord.time = strdate;

                
                ord.Show();
                


            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void OpenForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            String sqlcommond = String.Format(@"select * from 桌台信息 where 状态 ='空闲'");
            SqlCommand cmd = new SqlCommand(sqlcommond, conn);
            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["编号"].ToString());
            }
            dr.Close();


            String sqlcommondwork = String.Format(@"select * from 员工信息");
            SqlCommand cmdwork = new SqlCommand(sqlcommondwork, conn);
            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter dawork = new SqlDataAdapter();
            da.SelectCommand = cmdwork;

            SqlDataReader drwork = cmdwork.ExecuteReader();
            while (drwork.Read())
            {
                comboBox2.Items.Add(drwork["员工姓名"].ToString());
            }
            drwork.Close();


            conn.Close();
        }


    }
}
