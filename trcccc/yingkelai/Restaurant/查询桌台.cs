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
    public partial class 查询桌台 : Form
    {
        public 查询桌台()
        {
            InitializeComponent();
        }

        private void DeskInformation_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             
    第一，使用SqlConnection对象连接数据库；
    第二，建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；
    第三，对SQL或存储过程执行后返回的“结果”进行操作。             
             
             
             */







            //使用SqlConnection对象连接数据库，Data Source为服务器，，Initial Catalog为要用的数据库的名称，，
            //Integrated Security=SSPI 表示在windows验证模式下的打开Sql(在使用SQL server2008软件时是有身份验证)
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();

            string strname = txb_searchname.Text;//名称
            string strlocation = cbx_searchlocation.Text;//位置 
            string strstatus = cbx_searchstatus.Text;//状态

            string sqlcommond = string.Format(@"select * from 桌台信息");//都没填时查全部信息
            if(strname==""&&strlocation==""&&strstatus!="")
            {
                sqlcommond = string.Format(@"select * from 桌台信息 where 状态 ='" + strstatus + "'");//注意where两侧要有空格

            }
            else if(strname==""&&strlocation!=""&&strstatus=="")
            {
                sqlcommond = string.Format(@"select * from 桌台信息 where 位置 ='" + strlocation + "'");//注意where两侧要有空格

            }
            else if (strname != "" && strlocation == "" && strstatus == "")
            {
                sqlcommond = string.Format(@"select * from 桌台信息 where 名称 ='" + strname + "'");//注意where两侧要有空格

            }
            else if (strname != "" && strlocation != "" && strstatus == "")
            {
                sqlcommond = string.Format(@"select * from 桌台信息 where (名称 ='" + strname + "') and(位置 ='" + strlocation + "')");//注意where两侧要有空格

            }
            else if (strname != "" && strlocation == "" && strstatus != "")
            {
                sqlcommond = string.Format(@"select * from 桌台信息 where (名称 ='" + strname + "') and(状态 ='" + strstatus + "')");//注意where两侧要有空格

            }
            else if (strname == "" && strlocation != "" && strstatus != "")
            {
                sqlcommond = string.Format(@"select * from 桌台信息 where (位置 ='" + strlocation + "') and(状态 ='" + strstatus + "')");//注意where两侧要有空格

            }
            else if (strname != "" && strlocation != "" && strstatus != "")
            {
                sqlcommond = string.Format(@"select * from 桌台信息 where (名称 ='" + strname + "')and(位置 ='" + strlocation + "') and(状态 ='" + strstatus + "')");//注意where两侧要有空格

            }
            //建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；
            SqlCommand cmd = new SqlCommand(sqlcommond,conn);

            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            SqlDataReader dr = cmd.ExecuteReader();
            listView1.Items.Clear();//再次按查询时将上次的查询结果清除
            
            while (dr.Read())
            {
                //MessageBox.Show("1111");
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem it = new ListViewItem();
                it.Text = dr["编号"].ToString();
                it.SubItems.Add(dr["名称"].ToString());

                it.SubItems.Add(dr["位置"].ToString());
                it.SubItems.Add(dr["状态"].ToString());


                //将lt数据添加到listView1控件中
                listView1.Items.Add(it);
            }




            conn.Close();










        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                更新桌台 updesk = new 更新桌台();
                updesk.num = listView1.SelectedItems[0].SubItems[0].Text;
                updesk.defname = listView1.SelectedItems[0].SubItems[1].Text;
                updesk.deflocation = listView1.SelectedItems[0].SubItems[2].Text;
                updesk.ShowDialog();
                


                string str = listView1.SelectedItems[0].SubItems[0].Text;
                
                //MessageBox.Show(str);
                listView1.SelectedItems.Clear();//将选择的项改为为选择
            }
            else 
            {
                MessageBox.Show("请选择你要更新的桌台！");
            
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int num = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";
                conn.Open();
                string sqlcommond = string.Format(@"delete from 桌台信息 where 编号 = '" + num + "'");

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
                MessageBox.Show("请选择你要删除的桌台！");

            }
        }


        private void btn_adddesk_Click(object sender, EventArgs e)
        {
            增加桌台 adk = new 增加桌台();
            adk.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
