namespace Restaurant
{
    partial class 点菜
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(点菜));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_discount = new System.Windows.Forms.TextBox();
            this.txb_perprice = new System.Windows.Forms.TextBox();
            this.txb_totalnum = new System.Windows.Forms.TextBox();
            this.txb_ordername = new System.Windows.Forms.TextBox();
            this.txb_ordernum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_perorderOK = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_orderDelete = new System.Windows.Forms.Button();
            this.btn_ordersave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(21, 25);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(147, 268);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txb_discount);
            this.groupBox1.Controls.Add(this.txb_perprice);
            this.groupBox1.Controls.Add(this.txb_totalnum);
            this.groupBox1.Controls.Add(this.txb_ordername);
            this.groupBox1.Controls.Add(this.txb_ordernum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(200, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(639, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txb_discount
            // 
            this.txb_discount.Location = new System.Drawing.Point(245, 68);
            this.txb_discount.Margin = new System.Windows.Forms.Padding(4);
            this.txb_discount.Name = "txb_discount";
            this.txb_discount.ReadOnly = true;
            this.txb_discount.Size = new System.Drawing.Size(68, 25);
            this.txb_discount.TabIndex = 5;
            // 
            // txb_perprice
            // 
            this.txb_perprice.Location = new System.Drawing.Point(89, 68);
            this.txb_perprice.Margin = new System.Windows.Forms.Padding(4);
            this.txb_perprice.Name = "txb_perprice";
            this.txb_perprice.ReadOnly = true;
            this.txb_perprice.Size = new System.Drawing.Size(68, 25);
            this.txb_perprice.TabIndex = 5;
            // 
            // txb_totalnum
            // 
            this.txb_totalnum.Location = new System.Drawing.Point(385, 68);
            this.txb_totalnum.Margin = new System.Windows.Forms.Padding(4);
            this.txb_totalnum.Name = "txb_totalnum";
            this.txb_totalnum.Size = new System.Drawing.Size(68, 25);
            this.txb_totalnum.TabIndex = 5;
            this.txb_totalnum.Text = "1";
            // 
            // txb_ordername
            // 
            this.txb_ordername.Location = new System.Drawing.Point(347, 19);
            this.txb_ordername.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ordername.Name = "txb_ordername";
            this.txb_ordername.ReadOnly = true;
            this.txb_ordername.Size = new System.Drawing.Size(105, 25);
            this.txb_ordername.TabIndex = 5;
            // 
            // txb_ordernum
            // 
            this.txb_ordernum.Location = new System.Drawing.Point(89, 19);
            this.txb_ordernum.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ordernum.Name = "txb_ordernum";
            this.txb_ordernum.ReadOnly = true;
            this.txb_ordernum.Size = new System.Drawing.Size(160, 25);
            this.txb_ordernum.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "折扣：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "份数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "单价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "菜品名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "菜单编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(177, 348);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "菜品类别：";
            // 
            // btn_perorderOK
            // 
            this.btn_perorderOK.Location = new System.Drawing.Point(215, 175);
            this.btn_perorderOK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_perorderOK.Name = "btn_perorderOK";
            this.btn_perorderOK.Size = new System.Drawing.Size(100, 29);
            this.btn_perorderOK.TabIndex = 9;
            this.btn_perorderOK.Text = "确认";
            this.btn_perorderOK.UseVisualStyleBackColor = true;
            this.btn_perorderOK.Click += new System.EventHandler(this.btn_perorderOK_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "菜名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "菜系";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "菜单编号";
            this.columnHeader1.Width = 110;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(200, 215);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 169);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "单价";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "折扣";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "数量";
            // 
            // btn_orderDelete
            // 
            this.btn_orderDelete.Location = new System.Drawing.Point(379, 175);
            this.btn_orderDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orderDelete.Name = "btn_orderDelete";
            this.btn_orderDelete.Size = new System.Drawing.Size(100, 29);
            this.btn_orderDelete.TabIndex = 9;
            this.btn_orderDelete.Text = "删除";
            this.btn_orderDelete.UseVisualStyleBackColor = true;
            this.btn_orderDelete.Click += new System.EventHandler(this.btn_orderDelete_Click);
            // 
            // btn_ordersave
            // 
            this.btn_ordersave.Location = new System.Drawing.Point(564, 175);
            this.btn_ordersave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ordersave.Name = "btn_ordersave";
            this.btn_ordersave.Size = new System.Drawing.Size(112, 30);
            this.btn_ordersave.TabIndex = 13;
            this.btn_ordersave.Text = "保存点菜";
            this.btn_ordersave.UseVisualStyleBackColor = true;
            this.btn_ordersave.Click += new System.EventHandler(this.btn_ordersave_Click);
            // 
            // 点菜
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(897, 444);
            this.Controls.Add(this.btn_ordersave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_orderDelete);
            this.Controls.Add(this.btn_perorderOK);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "点菜";
            this.Text = "点菜";
            this.Load += new System.EventHandler(this.Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_discount;
        private System.Windows.Forms.TextBox txb_perprice;
        private System.Windows.Forms.TextBox txb_totalnum;
        private System.Windows.Forms.TextBox txb_ordername;
        private System.Windows.Forms.TextBox txb_ordernum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_perorderOK;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_orderDelete;
        private System.Windows.Forms.Button btn_ordersave;
    }
}