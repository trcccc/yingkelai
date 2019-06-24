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
    public partial class 点菜 : Form
    {
        public string desknum = "";
        public string servername = "";
        public int peocount = 0;
        public string time = "";


        private string strcaixi = "";
        开台 opform = null;
        public 点菜(开台 op)
        {
            InitializeComponent();
            this.opform = op;
        }

        private void Order_Load(object sender, EventArgs e)
        {





            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();

            int desk = Convert.ToInt32(desknum);
            string sqlcommonddesk = string.Format("select 名称 from 桌台信息 where 编号 = '"+ desk +"' ");
            SqlCommand cmddesk = new SqlCommand(sqlcommonddesk, conn);
            SqlDataReader drdesk = cmddesk.ExecuteReader();

            while(drdesk.Read())
            { 
            string deskname = drdesk["名称"].ToString();
            this.Text = deskname + "  " + this.Text;
            break;
            }

            drdesk.Close();





            string sqlcommond = "select  菜系编号,菜系名 from 菜系信息 ";


            SqlCommand cmd = new SqlCommand(sqlcommond, conn);

            //  SqlDataReader dr = cmd.ExecuteReader();

            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.Fill(ds);
            dt = ds.Tables[0];

            // MessageBox.Show(dt.Rows.Count.ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                TreeNode rootnode = new TreeNode();
                 string  str = dt.Rows[i]["菜系编号"].ToString();
                
                rootnode.Text = str + dt.Rows[i]["菜系名"].ToString();//父结点
                



                treeView1.Nodes.Add(rootnode);

                string sqlcommondkid = "select 菜名 from 菜单信息 where 菜系编号 ='" + str + "' ";

                SqlCommand cmdkid = new SqlCommand(sqlcommondkid, conn);

                //  SqlDataReader dr = cmd.ExecuteReader();

                //对SQL或存储过程执行后返回的“结果”进行操作
                SqlDataAdapter dakid = new SqlDataAdapter();
                dakid.SelectCommand = cmdkid;


                DataSet dskid = new DataSet();
                DataTable dtkid = new DataTable();

                dakid.Fill(dskid);
                dtkid = dskid.Tables[0];


                
                for (int j = 0; j < dtkid.Rows.Count; j++)//得到子结点
                {
                    string kid = dtkid.Rows[j]["菜名"].ToString();

                    rootnode.Nodes.Add(kid);


                }



            }

            conn.Close();

            txb_ordernum.Text = time;





        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Parent != null)
            {
                //将选择的菜名显示在菜名框里
                if (e.Node.Parent.Text[1] >= '0' && e.Node.Parent.Text[1] <= '9')
                {
                    strcaixi = e.Node.Parent.Text.Substring(0, 2);
                
                }
                else
                {
                    strcaixi = e.Node.Parent.Text.Substring(0, 1);
                }
                
                txb_ordername.Text = e.Node.ToString().Substring(10);//去除文字中开始的“treenode”和“ ”

                //查询菜的具体信息：价格、折扣等
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

                conn.Open();


                string sqlcommond = string.Format("select * from 菜单信息 where 菜名 = '" + txb_ordername.Text + "' ");
                SqlCommand cmd = new SqlCommand(sqlcommond, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txb_perprice.Text = dr["价格"].ToString();
                    txb_discount.Text = dr["折扣"].ToString();
                    
                    break;
                }
                

                conn.Close();



                







            }

        }

        private void btn_perorderOK_Click(object sender, EventArgs e)
        {
            
            string ordnum = txb_ordernum.Text;
            string orderxi = strcaixi;
            string ordername = txb_ordername.Text;
            float orderperprice =float.Parse( txb_perprice.Text);
            float orderdiscount = float.Parse(txb_discount.Text);
            int ordertotalnum =Convert.ToInt32 ( txb_totalnum.Text);

            //将选菜的具体信息保存在具体点菜信息表中
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();

            string sqlcom = string.Format(@"insert into 具体点菜信息(菜单编号,菜系,菜名,份数,单价,折扣,桌台位置,状态)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','未结账')", ordnum, orderxi, ordername, ordertotalnum, orderperprice, orderdiscount,desknum);
            SqlCommand cmd = new SqlCommand(sqlcom, conn);
            cmd.ExecuteNonQuery();           
            conn.Close();

            //将选菜的信息显示在listview控件中
            ListViewItem it = new ListViewItem();
            it.Text = ordnum;
            it.SubItems.Add(orderxi);
            it.SubItems.Add(ordername);
            it.SubItems.Add(txb_perprice.Text);
            it.SubItems.Add(txb_discount.Text);
            it.SubItems.Add(txb_totalnum.Text);

            listView1.Items.Add(it);
            
            

            
        }

        private void btn_orderDelete_Click(object sender, EventArgs e)
        {
           
            if (listView1.SelectedItems.Count > 0)
            {
                string ordernum = listView1.SelectedItems[0].SubItems[0].Text;
                string ordername = listView1.SelectedItems[0].SubItems[2].Text;


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

                conn.Open();
                string sqlcommond = string.Format(@"delete from 具体点菜信息 where (菜单编号 = '" + ordernum + "')and (菜名 = '"+ ordername +"')");

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
                MessageBox.Show("请选择你要删除的菜！");

            }

        }

        private void btn_ordersave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();

            string sqlcom = string.Format(@"insert into 点菜信息(菜单编号,桌台位置,就餐人数,服务人员)values('{0}','{1}','{2}','{3}')", txb_ordernum.Text, desknum,peocount , servername);
            SqlCommand cmd = new SqlCommand(sqlcom, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("成功保存点菜信息！！");
            conn.Close();
            this.Close();
            opform.Close();

            





        }
    }
}
