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
    public partial class btn_fresh : Form
    {
        string strcaixi ="";
        public btn_fresh()
        {
            InitializeComponent();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";

            conn.Open();

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
                string str = dt.Rows[i]["菜系编号"].ToString();

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
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            
            if (e.Node.Parent != null)
            {
                //将选择的菜名显示在菜名框里
                if (e.Node.Parent.Text[1] >= '0' && e.Node.Parent.Text[1] <= '9')//第二个字符是数字，菜系就是两位数
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
                    txb_oldperprice.Text = dr["价格"].ToString();
                    txb_olddiscount.Text = dr["折扣"].ToString();

                    break;
                }


                conn.Close();

            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            //将填写更新的价格折扣框显示出来
            label2.Visible = true;
            label4.Visible = true;

            txb_newdiscount.Visible = true;
            txb_newperprice.Visible = true;
            btn_ok.Visible = true;



        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string caiming = txb_ordername.Text.Trim();
            string newprice = txb_newperprice.Text.Trim();
            string newdiscount = txb_newdiscount.Text.Trim();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
            //建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；
            string sqlcom = string.Format(@"update 菜单信息 set 价格 = '" + newprice + "',折扣 = '" + newdiscount + "' where 菜名 = '" + caiming + "'");//插入数据是数字就无  ''。。。

            SqlCommand cmd = new SqlCommand(sqlcom, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            conn.Close();
            MessageBox.Show(caiming+"  菜品更新成功！！");



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string caiming = txb_ordername.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\25236\Desktop\Restaurant-Management-master\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
            string sqlcommond = string.Format(@"delete from 菜单信息 where 菜名 = '" + caiming + "'");

            //建立SqlCommand对象，负责SQL语句的执行和存储过程的调用；
            SqlCommand cmd = new SqlCommand(sqlcommond, conn);

            //对SQL或存储过程执行后返回的“结果”进行操作
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            cmd.ExecuteReader();
            MessageBox.Show(caiming+"  成功从菜单中删除菜品！！");
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
