namespace Restaurant
{
    partial class 增加桌台
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(增加桌台));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_addName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addOK = new System.Windows.Forms.Button();
            this.btn_addCancel = new System.Windows.Forms.Button();
            this.rbn_addfirst = new System.Windows.Forms.RadioButton();
            this.rbn_addsecond = new System.Windows.Forms.RadioButton();
            this.rbn_addthird = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(100, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // txb_addName
            // 
            this.txb_addName.Location = new System.Drawing.Point(169, 41);
            this.txb_addName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_addName.Name = "txb_addName";
            this.txb_addName.Size = new System.Drawing.Size(216, 25);
            this.txb_addName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(100, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "位置：";
            // 
            // btn_addOK
            // 
            this.btn_addOK.Location = new System.Drawing.Point(169, 221);
            this.btn_addOK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addOK.Name = "btn_addOK";
            this.btn_addOK.Size = new System.Drawing.Size(92, 28);
            this.btn_addOK.TabIndex = 2;
            this.btn_addOK.Text = "确认";
            this.btn_addOK.UseVisualStyleBackColor = true;
            this.btn_addOK.Click += new System.EventHandler(this.btn_addOK_Click);
            // 
            // btn_addCancel
            // 
            this.btn_addCancel.Location = new System.Drawing.Point(295, 221);
            this.btn_addCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCancel.Name = "btn_addCancel";
            this.btn_addCancel.Size = new System.Drawing.Size(92, 28);
            this.btn_addCancel.TabIndex = 2;
            this.btn_addCancel.Text = "取消";
            this.btn_addCancel.UseVisualStyleBackColor = true;
            this.btn_addCancel.Click += new System.EventHandler(this.btn_addCancel_Click);
            // 
            // rbn_addfirst
            // 
            this.rbn_addfirst.AutoSize = true;
            this.rbn_addfirst.Checked = true;
            this.rbn_addfirst.Location = new System.Drawing.Point(20, 16);
            this.rbn_addfirst.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_addfirst.Name = "rbn_addfirst";
            this.rbn_addfirst.Size = new System.Drawing.Size(58, 19);
            this.rbn_addfirst.TabIndex = 3;
            this.rbn_addfirst.TabStop = true;
            this.rbn_addfirst.Text = "一楼";
            this.rbn_addfirst.UseVisualStyleBackColor = true;
            // 
            // rbn_addsecond
            // 
            this.rbn_addsecond.AutoSize = true;
            this.rbn_addsecond.Location = new System.Drawing.Point(91, 19);
            this.rbn_addsecond.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_addsecond.Name = "rbn_addsecond";
            this.rbn_addsecond.Size = new System.Drawing.Size(58, 19);
            this.rbn_addsecond.TabIndex = 4;
            this.rbn_addsecond.TabStop = true;
            this.rbn_addsecond.Text = "二楼";
            this.rbn_addsecond.UseVisualStyleBackColor = true;
            // 
            // rbn_addthird
            // 
            this.rbn_addthird.AutoSize = true;
            this.rbn_addthird.Location = new System.Drawing.Point(153, 19);
            this.rbn_addthird.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_addthird.Name = "rbn_addthird";
            this.rbn_addthird.Size = new System.Drawing.Size(58, 19);
            this.rbn_addthird.TabIndex = 5;
            this.rbn_addthird.TabStop = true;
            this.rbn_addthird.Text = "三楼";
            this.rbn_addthird.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbn_addthird);
            this.groupBox1.Controls.Add(this.rbn_addsecond);
            this.groupBox1.Controls.Add(this.rbn_addfirst);
            this.groupBox1.Location = new System.Drawing.Point(169, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(217, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // 增加桌台
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 328);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_addCancel);
            this.Controls.Add(this.btn_addOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_addName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "增加桌台";
            this.Text = "增加餐桌";
            this.Load += new System.EventHandler(this.AddDesk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_addName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addOK;
        private System.Windows.Forms.Button btn_addCancel;
        private System.Windows.Forms.RadioButton rbn_addfirst;
        private System.Windows.Forms.RadioButton rbn_addsecond;
        private System.Windows.Forms.RadioButton rbn_addthird;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}