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
    public partial class 更新桌台 : Form
    {
        public string num ="";
        public string defname = "";
        public string deflocation = "";

        public 更新桌台()
        {
            InitializeComponent();
        }
        private void UpdateDesk_Load(object sender, EventArgs e)
        {
            //根据选择要写改的桌台，给赋初值
            txb_num.Text = num;
            txb_updateName.Text = defname;
            foreach (object sd in this.Controls)
            {
                RadioButton rbt = sd as RadioButton;
                if (rbt != null && rbt.Text== deflocation)
                {
                    rbt.Checked = true;
                    break;
                }


            }

            //MessageBox.Show(num);

        }
        private void btn_addOK_Click(object sender, EventArgs e)
        {
            string name = txb_updateName.Text.Trim();
            int num = Convert.ToInt32( txb_num.Text);

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

            string sqlcom = string.Format(@"update 桌台信息 set 名称 = '"+name+"',位置 = '"+location+"' where 编号 = '"+num+"'");//插入数据是数字就无  ''。。。

            SqlCommand cmd = new SqlCommand(sqlcom, conn);
            //d.CommandType = CommandType.Text;
            //d.CommandText = "insert into DeskInformation(Num，Price) values('{0}','{1}')txb_addPrice.Text;)";////注意values后的'''
            //cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            MessageBox.Show("成功更新桌台！！");
            conn.Close();
        }

        private void btn_addCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
