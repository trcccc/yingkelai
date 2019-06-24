namespace Restaurant
{
    partial class 登陆
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登陆));
            this.txbLogname = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbn_loginrole2 = new System.Windows.Forms.RadioButton();
            this.rbn_loginrole1 = new System.Windows.Forms.RadioButton();
            this.btn_login0k = new System.Windows.Forms.Button();
            this.btn_logincancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLogname
            // 
            this.txbLogname.Location = new System.Drawing.Point(196, 65);
            this.txbLogname.Margin = new System.Windows.Forms.Padding(4);
            this.txbLogname.Name = "txbLogname";
            this.txbLogname.Size = new System.Drawing.Size(156, 25);
            this.txbLogname.TabIndex = 0;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(196, 162);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(156, 25);
            this.txbPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(124, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(124, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(124, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "身份：";
            // 
            // rbn_loginrole2
            // 
            this.rbn_loginrole2.AutoSize = true;
            this.rbn_loginrole2.BackColor = System.Drawing.Color.Transparent;
            this.rbn_loginrole2.Location = new System.Drawing.Point(290, 118);
            this.rbn_loginrole2.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_loginrole2.Name = "rbn_loginrole2";
            this.rbn_loginrole2.Size = new System.Drawing.Size(58, 19);
            this.rbn_loginrole2.TabIndex = 2;
            this.rbn_loginrole2.Text = "经理";
            this.rbn_loginrole2.UseVisualStyleBackColor = false;
            // 
            // rbn_loginrole1
            // 
            this.rbn_loginrole1.AutoSize = true;
            this.rbn_loginrole1.BackColor = System.Drawing.Color.Transparent;
            this.rbn_loginrole1.Checked = true;
            this.rbn_loginrole1.Location = new System.Drawing.Point(196, 118);
            this.rbn_loginrole1.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_loginrole1.Name = "rbn_loginrole1";
            this.rbn_loginrole1.Size = new System.Drawing.Size(73, 19);
            this.rbn_loginrole1.TabIndex = 1;
            this.rbn_loginrole1.TabStop = true;
            this.rbn_loginrole1.Text = "服务员";
            this.rbn_loginrole1.UseVisualStyleBackColor = false;
            this.rbn_loginrole1.CheckedChanged += new System.EventHandler(this.rbn_loginrole1_CheckedChanged);
            // 
            // btn_login0k
            // 
            this.btn_login0k.Location = new System.Drawing.Point(127, 242);
            this.btn_login0k.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login0k.Name = "btn_login0k";
            this.btn_login0k.Size = new System.Drawing.Size(80, 29);
            this.btn_login0k.TabIndex = 4;
            this.btn_login0k.Text = "登录";
            this.btn_login0k.UseVisualStyleBackColor = true;
            this.btn_login0k.Click += new System.EventHandler(this.btn_login0k_Click);
            // 
            // btn_logincancel
            // 
            this.btn_logincancel.Location = new System.Drawing.Point(272, 242);
            this.btn_logincancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logincancel.Name = "btn_logincancel";
            this.btn_logincancel.Size = new System.Drawing.Size(80, 29);
            this.btn_logincancel.TabIndex = 5;
            this.btn_logincancel.Text = "取消";
            this.btn_logincancel.UseVisualStyleBackColor = true;
            this.btn_logincancel.Click += new System.EventHandler(this.btn_logincancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("幼圆", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(148, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "迎客来餐饮系统";
            // 
            // 登陆
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_logincancel);
            this.Controls.Add(this.btn_login0k);
            this.Controls.Add(this.rbn_loginrole1);
            this.Controls.Add(this.rbn_loginrole2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbLogname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "登陆";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLogname;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbn_loginrole2;
        private System.Windows.Forms.RadioButton rbn_loginrole1;
        private System.Windows.Forms.Button btn_login0k;
        private System.Windows.Forms.Button btn_logincancel;
        private System.Windows.Forms.Label label4;
    }
}