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
    public partial class 员工信息 : Form
    {
        public 员工信息()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();


            string strid = txb_wid.Text;
            string strname = txb_wname.Text;
            string strsex = cbx_wsex.Text;
            string stragef = txb_wagef.Text;
            string straget = txb_waget.Text;
            string strrole = cbx_wrole.Text;

            string sqlcommond = "select * from 员工信息";
            if (strid != "")
            {
                sqlcommond = string.Format(@"select * from 员工信息 where 员工编号 ='" + strid + "'");
            }
            else if (strname != "")
            {
                sqlcommond = string.Format(@"select * from 员工信息 where 员工姓名 ='" + strname + "'");

            }

            else if (stragef != ""&&straget=="")
            {
                sqlcommond = string.Format(@"select * from 员工信息 where 年龄 >'" + stragef + "'");

            }
            else if (stragef != "" && straget != "")
            {
                sqlcommond = string.Format(@"select * from 员工信息 where 年龄 between '" + stragef + "' and '" + straget + "'");

            }
            else if (strrole != "" && strsex == "")
            {
                sqlcommond = string.Format(@"select * from 员工信息 where 身份 ='" + strrole + "'");

            }

            else if (strsex != "" && strrole != "")
            {
                sqlcommond = string.Format(@"select * from 员工信息 where 性别 ='" + strsex + "' and 身份 ='"+ strrole +"' ");
 
            
            
            }



            //建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；
            SqlCommand cmd = new SqlCommand(sqlcommond, conn);

            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            SqlDataReader dr = cmd.ExecuteReader();
            listView1.Items.Clear();//再次按查询时将上次的查询结果清除
            //if ()
            //{
            //    MessageBox.Show("查无此人！！");

            
            //}
  
            while (dr.Read())
            {
                //MessageBox.Show("1111");
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem it = new ListViewItem();
                it.Text = dr["员工编号"].ToString();
                it.SubItems.Add(dr["员工姓名"].ToString());
                it.SubItems.Add(dr["身份证号"].ToString());
                it.SubItems.Add(dr["性别"].ToString());
                it.SubItems.Add(dr["年龄"].ToString());
                it.SubItems.Add(dr["电话"].ToString());
                it.SubItems.Add(dr["身份"].ToString());

                //将lt数据添加到listView1控件中
                listView1.Items.Add(it);
            }



            conn.Close();//关闭数据库





        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                更新员工 upworker = new 更新员工();
                upworker.defid = listView1.SelectedItems[0].SubItems[0].Text;
                upworker.defname = listView1.SelectedItems[0].SubItems[1].Text;
                upworker.defcardnum = listView1.SelectedItems[0].SubItems[2].Text;
                upworker.defsex = listView1.SelectedItems[0].SubItems[3].Text;
                upworker.defage = listView1.SelectedItems[0].SubItems[4].Text;
                upworker.deftel = listView1.SelectedItems[0].SubItems[5].Text;
                upworker.defrole = listView1.SelectedItems[0].SubItems[6].Text;
                upworker.ShowDialog();



                string str = listView1.SelectedItems[0].SubItems[0].Text;

                //MessageBox.Show(str);
                listView1.SelectedItems.Clear();//将选择的项改为为选择
            }
            else
            {
                MessageBox.Show("请选择你要更新的员工！");

            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

                conn.Open();
                string sqlcommond = string.Format(@"delete from 员工信息 where 员工编号 = '" + id + "'");

                //建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；
                SqlCommand cmd = new SqlCommand(sqlcommond, conn);

                //对SQL或存储过程执行后返回的“结果”进行操作
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                cmd.ExecuteReader();
                MessageBox.Show("成功从数据库中删除");
                conn.Close();


                //删除选择项
                int lisnum = listView1.Items.IndexOf(listView1.FocusedItem);
                listView1.Items.Remove(listView1.Items[lisnum]);

            }
            else
            {
                MessageBox.Show("请选择你要删除的员工！");

            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WorkerInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
