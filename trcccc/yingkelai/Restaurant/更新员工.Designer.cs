namespace Restaurant
{
    partial class 更新员工
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(更新员工));
            this.btn_upcancel = new System.Windows.Forms.Button();
            this.btn_upok = new System.Windows.Forms.Button();
            this.cbx_upsex = new System.Windows.Forms.ComboBox();
            this.txb_uptel = new System.Windows.Forms.TextBox();
            this.txb_upage = new System.Windows.Forms.TextBox();
            this.txb_upcardnum = new System.Windows.Forms.TextBox();
            this.txb_upname = new System.Windows.Forms.TextBox();
            this.txb_upid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_role = new System.Windows.Forms.ComboBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_upcancel
            // 
            this.btn_upcancel.Location = new System.Drawing.Point(279, 498);
            this.btn_upcancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upcancel.Name = "btn_upcancel";
            this.btn_upcancel.Size = new System.Drawing.Size(92, 28);
            this.btn_upcancel.TabIndex = 24;
            this.btn_upcancel.Text = "取消";
            this.btn_upcancel.UseVisualStyleBackColor = true;
            this.btn_upcancel.Click += new System.EventHandler(this.btn_upcancel_Click);
            // 
            // btn_upok
            // 
            this.btn_upok.Location = new System.Drawing.Point(89, 498);
            this.btn_upok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upok.Name = "btn_upok";
            this.btn_upok.Size = new System.Drawing.Size(92, 28);
            this.btn_upok.TabIndex = 25;
            this.btn_upok.Text = "更新";
            this.btn_upok.UseVisualStyleBackColor = true;
            this.btn_upok.Click += new System.EventHandler(this.btn_upok_Click);
            // 
            // cbx_upsex
            // 
            this.cbx_upsex.FormattingEnabled = true;
            this.cbx_upsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbx_upsex.Location = new System.Drawing.Point(132, 276);
            this.cbx_upsex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_upsex.Name = "cbx_upsex";
            this.cbx_upsex.Size = new System.Drawing.Size(213, 23);
            this.cbx_upsex.TabIndex = 23;
            // 
            // txb_uptel
            // 
            this.txb_uptel.Location = new System.Drawing.Point(132, 390);
            this.txb_uptel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_uptel.Name = "txb_uptel";
            this.txb_uptel.Size = new System.Drawing.Size(213, 25);
            this.txb_uptel.TabIndex = 18;
            // 
            // txb_upage
            // 
            this.txb_upage.Location = new System.Drawing.Point(132, 330);
            this.txb_upage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_upage.Name = "txb_upage";
            this.txb_upage.Size = new System.Drawing.Size(213, 25);
            this.txb_upage.TabIndex = 19;
            // 
            // txb_upcardnum
            // 
            this.txb_upcardnum.Location = new System.Drawing.Point(132, 170);
            this.txb_upcardnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_upcardnum.Name = "txb_upcardnum";
            this.txb_upcardnum.Size = new System.Drawing.Size(213, 25);
            this.txb_upcardnum.TabIndex = 20;
            // 
            // txb_upname
            // 
            this.txb_upname.Location = new System.Drawing.Point(132, 118);
            this.txb_upname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_upname.Name = "txb_upname";
            this.txb_upname.Size = new System.Drawing.Size(213, 25);
            this.txb_upname.TabIndex = 21;
            // 
            // txb_upid
            // 
            this.txb_upid.Location = new System.Drawing.Point(132, 65);
            this.txb_upid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_upid.Name = "txb_upid";
            this.txb_upid.ReadOnly = true;
            this.txb_upid.Size = new System.Drawing.Size(213, 25);
            this.txb_upid.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(29, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "年龄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(29, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "身份证号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "员工姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "员工编号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(29, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "身份：";
            // 
            // cbx_role
            // 
            this.cbx_role.FormattingEnabled = true;
            this.cbx_role.Items.AddRange(new object[] {
            "服务员",
            "经理"});
            this.cbx_role.Location = new System.Drawing.Point(132, 224);
            this.cbx_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_role.Name = "cbx_role";
            this.cbx_role.Size = new System.Drawing.Size(213, 23);
            this.cbx_role.TabIndex = 23;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(132, 440);
            this.txb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(213, 25);
            this.txb_password.TabIndex = 27;
            this.txb_password.Text = "123456";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(29, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "密码：";
            // 
            // 更新员工
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(401, 541);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_upcancel);
            this.Controls.Add(this.btn_upok);
            this.Controls.Add(this.cbx_role);
            this.Controls.Add(this.cbx_upsex);
            this.Controls.Add(this.txb_uptel);
            this.Controls.Add(this.txb_upage);
            this.Controls.Add(this.txb_upcardnum);
            this.Controls.Add(this.txb_upname);
            this.Controls.Add(this.txb_upid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "更新员工";
            this.Text = "更新员工";
            this.Load += new System.EventHandler(this.UpdataWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_upcancel;
        private System.Windows.Forms.Button btn_upok;
        private System.Windows.Forms.ComboBox cbx_upsex;
        private System.Windows.Forms.TextBox txb_uptel;
        private System.Windows.Forms.TextBox txb_upage;
        private System.Windows.Forms.TextBox txb_upcardnum;
        private System.Windows.Forms.TextBox txb_upname;
        private System.Windows.Forms.TextBox txb_upid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_role;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label8;
    }
}