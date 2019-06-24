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
    public partial class 登陆 : Form
    {
        public 登陆()
        {
            InitializeComponent();
        }

        private void btn_login0k_Click(object sender, EventArgs e)
        {
            

            string role = "";
            if (rbn_loginrole1.Checked == true)
            {
                role = rbn_loginrole1.Text.Trim();
            }
            else
            {
                role = rbn_loginrole2.Text.Trim();
            }
            string name = txbLogname.Text.Trim();
            string password = txbPassword.Text.Trim();
            if(name=="")
            {
                MessageBox.Show("请输入用户名！！");
               

            }
            else if(password == "")
            {
                MessageBox.Show("请输入密码！！");
                txbPassword.Focus();
                
            }
            else
            {
               // string strConn = @"Data Source=.;Initial Catalog=Restaurant;Integrated Security=SSPI; ";
               // SqlConnection conn = new SqlConnection("server=.;uid=sa;pwd=123456;database=Restaurant");
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\93751\Documents\Tencent Files\937510025\FileRecv\迎客来\Restraurant.mdf;Integrated Security=True;Connect Timeout=30";
               
                conn.Open();

                string sqlcommond = string.Format("select * from 登录表 where 用户名 = '"+ name +"' ");
                SqlCommand cmd = new SqlCommand(sqlcommond, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                //判断登录信息是否正确，并给出相应的提示
                int flagname = 0, flagrole = 0, flagpassword = 0; 
                if (dr.Read())
                {
                    if(dr["用户名"].ToString()==name)
                    {
                        flagname = 1;
                        if(dr["身份"].ToString() ==role)
                        {
                            flagrole = 1;
                            if(dr["密码"].ToString()==password)
                            {
                                flagpassword = 1;
                            }
                        }
                    }
                 
                }
                conn.Close();

                if (flagname == 0)
                {
                    MessageBox.Show("您输入的用户不存在！！");
                }
                else if (flagrole == 0)
                {
                    MessageBox.Show("您选择的身份不符！！");     
                }
                else if (flagpassword == 0)
                {
                    MessageBox.Show("您输入的密码不正确！！");
                }
                else
                {
                
                    //将登录界面隐藏，显示主界面，，
                    主界面 frm = new 主界面(this);
                    frm.username = name;
                    frm.userrole = role;
                    frm.Show();
                    this.Hide();                
                }

            }

        }

        private void Log_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_logincancel_Click(object sender, EventArgs e)
        {
            txbLogname.Text = "";
            txbPassword.Text = "";
        }

        private void rbn_loginrole1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
