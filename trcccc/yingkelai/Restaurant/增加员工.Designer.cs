namespace Restaurant
{
    partial class 增加员工
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(增加员工));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.rbn_woman = new System.Windows.Forms.RadioButton();
            this.rbn_man = new System.Windows.Forms.RadioButton();
            this.Worker_Tel = new System.Windows.Forms.TextBox();
            this.Worker_Age = new System.Windows.Forms.TextBox();
            this.Worker_CardNum = new System.Windows.Forms.TextBox();
            this.Woker_Name = new System.Windows.Forms.TextBox();
            this.Worker_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(221, 405);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(99, 405);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 32);
            this.btn_OK.TabIndex = 20;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // rbn_woman
            // 
            this.rbn_woman.AutoSize = true;
            this.rbn_woman.BackColor = System.Drawing.SystemColors.Menu;
            this.rbn_woman.Location = new System.Drawing.Point(212, 156);
            this.rbn_woman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbn_woman.Name = "rbn_woman";
            this.rbn_woman.Size = new System.Drawing.Size(43, 19);
            this.rbn_woman.TabIndex = 17;
            this.rbn_woman.TabStop = true;
            this.rbn_woman.Text = "女";
            this.rbn_woman.UseVisualStyleBackColor = false;
            // 
            // rbn_man
            // 
            this.rbn_man.AutoSize = true;
            this.rbn_man.BackColor = System.Drawing.SystemColors.Menu;
            this.rbn_man.Location = new System.Drawing.Point(140, 156);
            this.rbn_man.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbn_man.Name = "rbn_man";
            this.rbn_man.Size = new System.Drawing.Size(43, 19);
            this.rbn_man.TabIndex = 18;
            this.rbn_man.TabStop = true;
            this.rbn_man.Text = "男";
            this.rbn_man.UseVisualStyleBackColor = false;
            // 
            // Worker_Tel
            // 
            this.Worker_Tel.Location = new System.Drawing.Point(140, 289);
            this.Worker_Tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Worker_Tel.Name = "Worker_Tel";
            this.Worker_Tel.Size = new System.Drawing.Size(197, 25);
            this.Worker_Tel.TabIndex = 12;
            // 
            // Worker_Age
            // 
            this.Worker_Age.Location = new System.Drawing.Point(140, 240);
            this.Worker_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Worker_Age.Name = "Worker_Age";
            this.Worker_Age.Size = new System.Drawing.Size(115, 25);
            this.Worker_Age.TabIndex = 13;
            // 
            // Worker_CardNum
            // 
            this.Worker_CardNum.Location = new System.Drawing.Point(140, 331);
            this.Worker_CardNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Worker_CardNum.Name = "Worker_CardNum";
            this.Worker_CardNum.Size = new System.Drawing.Size(197, 25);
            this.Worker_CardNum.TabIndex = 14;
            // 
            // Woker_Name
            // 
            this.Woker_Name.Location = new System.Drawing.Point(140, 110);
            this.Woker_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Woker_Name.Name = "Woker_Name";
            this.Woker_Name.Size = new System.Drawing.Size(115, 25);
            this.Woker_Name.TabIndex = 15;
            // 
            // Worker_ID
            // 
            this.Worker_ID.Location = new System.Drawing.Point(140, 60);
            this.Worker_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Worker_ID.Name = "Worker_ID";
            this.Worker_ID.Size = new System.Drawing.Size(115, 25);
            this.Worker_ID.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(49, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "电话:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(49, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "年龄:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(49, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "性别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "身份证号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "员工姓名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "员工编号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(49, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "身份:";
            // 
            // cbx_role
            // 
            this.cbx_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_role.FormattingEnabled = true;
            this.cbx_role.Items.AddRange(new object[] {
            "服务员",
            "经理"});
            this.cbx_role.Location = new System.Drawing.Point(141, 198);
            this.cbx_role.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_role.Name = "cbx_role";
            this.cbx_role.Size = new System.Drawing.Size(112, 23);
            this.cbx_role.TabIndex = 21;
            // 
            // 增加员工
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.cbx_role);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.rbn_woman);
            this.Controls.Add(this.rbn_man);
            this.Controls.Add(this.Worker_Tel);
            this.Controls.Add(this.Worker_Age);
            this.Controls.Add(this.Worker_CardNum);
            this.Controls.Add(this.Woker_Name);
            this.Controls.Add(this.Worker_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "增加员工";
            this.Text = "增加员工";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.RadioButton rbn_woman;
        private System.Windows.Forms.RadioButton rbn_man;
        private System.Windows.Forms.TextBox Worker_Tel;
        private System.Windows.Forms.TextBox Worker_Age;
        private System.Windows.Forms.TextBox Worker_CardNum;
        private System.Windows.Forms.TextBox Woker_Name;
        private System.Windows.Forms.TextBox Worker_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_role;
    }
}