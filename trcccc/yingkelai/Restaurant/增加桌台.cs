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
    public partial class 增加桌台 : Form
    {
        public 增加桌台()
        {
            InitializeComponent();
        }

        private void AddDesk_Load(object sender, EventArgs e)
        {

        }

        private void btn_addCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addOK_Click(object sender, EventArgs e)
        {
            //char []num  = new char(10) ;
            //Convert.to
          //  num = Convert.ToChar(txb_addNum.ToString());
            //= txb_addNum.ToString();

            string name = txb_addName.Text.Trim();

            string location = null;
            foreach (object sd in this.Controls)
            {
                RadioButton rbt = sd as RadioButton;
                if (rbt != null && rbt.Checked == true)
                {
                    location = rbt.Text.Trim();
                    break;
                }


            }


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            //建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；

            string sqlcom = string.Format(@"insert into 桌台信息(状态,名称,位置)values('空闲','{0}','{1}')",name,location);//插入数据是数字就无  ''。。。

            SqlCommand cmd = new SqlCommand(sqlcom, conn);
            //d.CommandType = CommandType.Text;
            //d.CommandText = "insert into DeskInformation(Num，Price) values('{0}','{1}')txb_addPrice.Text;)";////注意values后的'''
            //cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            MessageBox.Show("成功插入桌台！！");
            conn.Close();



        }
    }
}
