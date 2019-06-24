namespace Restaurant
{
    partial class 添加菜单
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(添加菜单));
            this.txbname = new System.Windows.Forms.TextBox();
            this.cbxcaixi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_menuok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(112, 140);
            this.txbname.Margin = new System.Windows.Forms.Padding(4);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(160, 25);
            this.txbname.TabIndex = 0;
            // 
            // cbxcaixi
            // 
            this.cbxcaixi.FormattingEnabled = true;
            this.cbxcaixi.Location = new System.Drawing.Point(112, 78);
            this.cbxcaixi.Margin = new System.Windows.Forms.Padding(4);
            this.cbxcaixi.Name = "cbxcaixi";
            this.cbxcaixi.Size = new System.Drawing.Size(160, 23);
            this.cbxcaixi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "菜系：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "名称：";
            // 
            // btn_menuok
            // 
            this.btn_menuok.Location = new System.Drawing.Point(75, 254);
            this.btn_menuok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menuok.Name = "btn_menuok";
            this.btn_menuok.Size = new System.Drawing.Size(100, 29);
            this.btn_menuok.TabIndex = 4;
            this.btn_menuok.Text = "确认";
            this.btn_menuok.UseVisualStyleBackColor = true;
            this.btn_menuok.Click += new System.EventHandler(this.btn_menuok_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 254);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbprice
            // 
            this.txbprice.Location = new System.Drawing.Point(112, 196);
            this.txbprice.Margin = new System.Windows.Forms.Padding(4);
            this.txbprice.Name = "txbprice";
            this.txbprice.Size = new System.Drawing.Size(160, 25);
            this.txbprice.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "价格：";
            // 
            // 添加菜单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(379, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_menuok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxcaixi);
            this.Controls.Add(this.txbprice);
            this.Controls.Add(this.txbname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "添加菜单";
            this.Text = "新菜";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.ComboBox cbxcaixi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_menuok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbprice;
        private System.Windows.Forms.Label label3;
    }
}