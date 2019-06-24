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
    public partial class 结账和查询 : Form
    {
        private int oldread = 0;
        public static float sum = 0;
        public static string pay_name;
        public static string pay_ordernum;

        public 结账和查询()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            String sqlcommond = "select * from 开台表";
            SqlCommand cmd = new SqlCommand(sqlcommond, conn);

            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            SqlDataReader dr = cmd.ExecuteReader();
            listView1.Items.Clear();//再次
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                //MessageBox.Show("1111");
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem it = new ListViewItem();
                it.Text = dr["编号"].ToString();

                it.SubItems.Add(dr["名称"].ToString());

                it.SubItems.Add(dr["服务员"].ToString());

                it.SubItems.Add(dr["人数"].ToString());

                it.SubItems.Add(dr["日期"].ToString());


                //将lt数据添加到listView1控件中
                listView1.Items.Add(it);

                comboBox1.Items.Add(dr["编号"].ToString());
            }
            conn.Close();

        }
     

        private void button3_Click(object sender, EventArgs e)
        {

                Boolean flag = false;
                for(int i=0;i<listView1.Items.Count;i++)
                {
                    if (listView1.Items[i].SubItems[0].Text.IndexOf(comboBox1.Text.Trim()) >= 0)
                    {
                        flag = true;
                        listView1.Items[oldread].Selected = false;
                        listView1.Items[i].EnsureVisible();
                        listView1.Items[oldread].BackColor = Color.White;
                        listView1.Items[i].BackColor = Color.Blue;
                        listView1.Items[i].Selected = true;
                        oldread = i;
                        break;
                    }
                }
                if(!flag)
                {
                    MessageBox.Show("未找到该桌号");
                }
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            { 
                if(comboBox1.Text.Trim()!=string.Empty)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text.IndexOf(comboBox1.Text.Trim()) >= 0)
                        {
                            listView1.Items[i].Selected = true;
                            listView1.Items[i].EnsureVisible();
                        
                        }
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("请刷新列表");
            }


            pay_name = comboBox1.Text;
            if(pay_name!="")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

                conn.Open();
                string sqlcommond = string.Format(@"select * from 具体点菜信息 where 桌台位置 = '" + pay_name + "'and 状态 = '未结账' ");
                SqlCommand cmd = new SqlCommand(sqlcommond, conn);

                //对SQL或存储过程执行后返回的“结果”进行操作
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    
                    float price = float.Parse(dr["单价"].ToString());
                    int num = Convert.ToInt32(dr["份数"].ToString());
                    int discount = Convert.ToInt32(dr["折扣"].ToString());
                    pay_ordernum = dr["菜单编号"].ToString();
                    sum += price * num * discount;
                }




                conn.Close();
                结账 payment = new 结账();
                payment.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择结账桌台编号！！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            开台 open = new 开台();
            open.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                string desknum = listView1.SelectedItems[0].SubItems[0].Text;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

                conn.Open();
                //删除桌台表中的相关信息
                string sqlcommondkaitai = string.Format(@"delete from 开台表 where 编号 = '" + desknum + "'");            
                SqlCommand cmd = new SqlCommand(sqlcommondkaitai, conn);
                SqlDataReader sr =  cmd.ExecuteReader();
                sr.Close();

                //删除点菜信息中的相关信息
                string sqlcommondorder = string.Format(@"delete from 点菜信息 where 桌台位置 = '" + desknum + "'");
                SqlCommand cmdorder = new SqlCommand(sqlcommondorder, conn);
                SqlDataReader srorder = cmdorder.ExecuteReader();
                srorder.Close();

                //删除具体点菜信息中的相关信息
                string sqlcommondorder1 = string.Format(@"delete from 具体点菜信息 where 桌台位置 = '" + desknum + "'");
                SqlCommand cmdorder1 = new SqlCommand(sqlcommondorder1, conn);
                SqlDataReader srorder1 = cmdorder1.ExecuteReader();
                srorder1.Close();

                //修改桌台信息表中相应的信息由占用到空闲
                int desk = Convert.ToInt32(desknum);
                String sqlcommond3 = string.Format(@"update 桌台信息 set 状态='空闲' where 编号= '"+desk+"' ");
                SqlCommand cmd3 = new SqlCommand(sqlcommond3, conn);
                SqlDataReader sr3 = cmd3.ExecuteReader();
                sr3.Close();



                
                conn.Close();


                //删除选择项
                int lisnum = listView1.Items.IndexOf(listView1.FocusedItem);
                listView1.Items.Remove(listView1.Items[lisnum]);
                MessageBox.Show("删除成功！！");

            }
            else
            {
                MessageBox.Show("请选择你要删除的桌台！");

            }

        }

        private void Opentable_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();
            String sqlcommond = "select * from 开台表";
            SqlCommand cmd = new SqlCommand(sqlcommond, conn);

            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            SqlDataReader dr = cmd.ExecuteReader();
            listView1.Items.Clear();//再次
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                //MessageBox.Show("1111");
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem it = new ListViewItem();
                it.Text = dr["编号"].ToString();

                it.SubItems.Add(dr["名称"].ToString());

                it.SubItems.Add(dr["服务员"].ToString());

                it.SubItems.Add(dr["人数"].ToString());

                it.SubItems.Add(dr["日期"].ToString());


                //将lt数据添加到listView1控件中
                listView1.Items.Add(it);

                comboBox1.Items.Add(dr["编号"].ToString());
            }
            conn.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
