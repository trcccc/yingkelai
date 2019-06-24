namespace Restaurant
{
    partial class 主界面
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主界面));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.桌台信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入菜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入菜ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开台ToolStripMenuItem,
            this.员工信息ToolStripMenuItem,
            this.桌台信息ToolStripMenuItem,
            this.录入菜ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开台ToolStripMenuItem
            // 
            this.开台ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新开台ToolStripMenuItem,
            this.查询开台ToolStripMenuItem});
            this.开台ToolStripMenuItem.Name = "开台ToolStripMenuItem";
            this.开台ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.开台ToolStripMenuItem.Text = "开台点菜";
            // 
            // 新开台ToolStripMenuItem
            // 
            this.新开台ToolStripMenuItem.Name = "新开台ToolStripMenuItem";
            this.新开台ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.新开台ToolStripMenuItem.Text = "新开台";
            this.新开台ToolStripMenuItem.Click += new System.EventHandler(this.新开台ToolStripMenuItem_Click);
            // 
            // 查询开台ToolStripMenuItem
            // 
            this.查询开台ToolStripMenuItem.Name = "查询开台ToolStripMenuItem";
            this.查询开台ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.查询开台ToolStripMenuItem.Text = "查询开台";
            this.查询开台ToolStripMenuItem.Click += new System.EventHandler(this.查询开台ToolStripMenuItem_Click);
            // 
            // 员工信息ToolStripMenuItem
            // 
            this.员工信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem1,
            this.查询ToolStripMenuItem1});
            this.员工信息ToolStripMenuItem.Name = "员工信息ToolStripMenuItem";
            this.员工信息ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.员工信息ToolStripMenuItem.Text = "员工信息";
            // 
            // 增加ToolStripMenuItem1
            // 
            this.增加ToolStripMenuItem1.Name = "增加ToolStripMenuItem1";
            this.增加ToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.增加ToolStripMenuItem1.Text = "增加";
            this.增加ToolStripMenuItem1.Click += new System.EventHandler(this.增加ToolStripMenuItem1_Click);
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.查询ToolStripMenuItem1.Text = "查询";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.查询ToolStripMenuItem1_Click);
            // 
            // 桌台信息ToolStripMenuItem
            // 
            this.桌台信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.查询ToolStripMenuItem});
            this.桌台信息ToolStripMenuItem.Name = "桌台信息ToolStripMenuItem";
            this.桌台信息ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.桌台信息ToolStripMenuItem.Text = "桌台信息";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.增加ToolStripMenuItem.Text = "增加";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 录入菜ToolStripMenuItem
            // 
            this.录入菜ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.录入菜ToolStripMenuItem1,
            this.查看ToolStripMenuItem});
            this.录入菜ToolStripMenuItem.Name = "录入菜ToolStripMenuItem";
            this.录入菜ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.录入菜ToolStripMenuItem.Text = "菜单";
            // 
            // 录入菜ToolStripMenuItem1
            // 
            this.录入菜ToolStripMenuItem1.Name = "录入菜ToolStripMenuItem1";
            this.录入菜ToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.录入菜ToolStripMenuItem1.Text = "录入菜";
            this.录入菜ToolStripMenuItem1.Click += new System.EventHandler(this.录入菜ToolStripMenuItem1_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(83, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluser.Location = new System.Drawing.Point(840, 341);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(53, 20);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(298, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "欢迎使用迎客来餐饮管理系统";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // 主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "主界面";
            this.Text = "餐饮管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 桌台信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.ToolStripMenuItem 录入菜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入菜ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

