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
    public partial class 主界面 : Form
    {
        登陆 loginform = null;
        public string userrole = "";
        public string username = "";
        //传登录窗体参数
        public 主界面(登陆 lg)
        {
            this.loginform = lg;
            InitializeComponent();

        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询桌台 Dskinf = new 查询桌台();

            Dskinf.ShowDialog();
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            增加桌台 adddesk = new 增加桌台();
            adddesk.ShowDialog();
        }

        private void 显示开台表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            结账和查询 opentable = new 结账和查询();
            opentable.ShowDialog();
        }

        private void 新开台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            开台 open = new 开台();
            open.ShowDialog();
        }

        private void 查询开台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            结账和查询 opentable = new 结账和查询();
            opentable.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lbluser.Text = "登录人员:" + username;
            label1.Text = "当前时间： " + Convert.ToString(DateTime.Now).Trim();
            if(userrole=="服务员")
            { 

                开台ToolStripMenuItem.Visible = true;
                员工信息ToolStripMenuItem.Visible = false;
                桌台信息ToolStripMenuItem.Visible = false;
                录入菜ToolStripMenuItem.Visible = false;


            }
        }


        private void 增加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            增加员工 addworker = new 增加员工();
            addworker.ShowDialog();

        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            员工信息 workerinformation = new 员工信息();
            workerinformation.ShowDialog();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            label1.Text = "当前时间： "+ Convert.ToString(DateTime.Now).Trim();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginform.Close();
        }
        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_fresh vword = new btn_fresh();
            vword.ShowDialog();
        }

        private void 录入菜ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            添加菜单 adm = new 添加菜单();
            adm.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
