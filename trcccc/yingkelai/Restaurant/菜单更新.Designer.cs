namespace Restaurant
{
    partial class btn_fresh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_fresh));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.txb_newdiscount = new System.Windows.Forms.TextBox();
            this.txb_olddiscount = new System.Windows.Forms.TextBox();
            this.txb_newperprice = new System.Windows.Forms.TextBox();
            this.txb_oldperprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ordername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 22);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(189, 210);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_ok);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_change);
            this.groupBox1.Controls.Add(this.txb_newdiscount);
            this.groupBox1.Controls.Add(this.txb_olddiscount);
            this.groupBox1.Controls.Add(this.txb_newperprice);
            this.groupBox1.Controls.Add(this.txb_oldperprice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_ordername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(224, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(565, 219);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(351, 130);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(83, 26);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Visible = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(456, 68);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 29);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(351, 68);
            this.btn_change.Margin = new System.Windows.Forms.Padding(4);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(84, 29);
            this.btn_change.TabIndex = 6;
            this.btn_change.Text = "更改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // txb_newdiscount
            // 
            this.txb_newdiscount.Location = new System.Drawing.Point(256, 130);
            this.txb_newdiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txb_newdiscount.Name = "txb_newdiscount";
            this.txb_newdiscount.Size = new System.Drawing.Size(68, 25);
            this.txb_newdiscount.TabIndex = 5;
            this.txb_newdiscount.Visible = false;
            // 
            // txb_olddiscount
            // 
            this.txb_olddiscount.Location = new System.Drawing.Point(256, 68);
            this.txb_olddiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txb_olddiscount.Name = "txb_olddiscount";
            this.txb_olddiscount.ReadOnly = true;
            this.txb_olddiscount.Size = new System.Drawing.Size(85, 25);
            this.txb_olddiscount.TabIndex = 5;
            // 
            // txb_newperprice
            // 
            this.txb_newperprice.Location = new System.Drawing.Point(89, 130);
            this.txb_newperprice.Margin = new System.Windows.Forms.Padding(4);
            this.txb_newperprice.Name = "txb_newperprice";
            this.txb_newperprice.Size = new System.Drawing.Size(68, 25);
            this.txb_newperprice.TabIndex = 5;
            this.txb_newperprice.Visible = false;
            // 
            // txb_oldperprice
            // 
            this.txb_oldperprice.Location = new System.Drawing.Point(89, 68);
            this.txb_oldperprice.Margin = new System.Windows.Forms.Padding(4);
            this.txb_oldperprice.Name = "txb_oldperprice";
            this.txb_oldperprice.ReadOnly = true;
            this.txb_oldperprice.Size = new System.Drawing.Size(79, 25);
            this.txb_oldperprice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "现折扣：";
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "原折扣：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "现单价：";
            this.label2.Visible = false;
            // 
            // txb_ordername
            // 
            this.txb_ordername.Location = new System.Drawing.Point(89, 14);
            this.txb_ordername.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ordername.Name = "txb_ordername";
            this.txb_ordername.ReadOnly = true;
            this.txb_ordername.Size = new System.Drawing.Size(157, 25);
            this.txb_ordername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "原单价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "菜品名：";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(51, 241);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(133, 41);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.ViewOrder_Load);
            // 
            // btn_fresh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(827, 356);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "btn_fresh";
            this.Text = "菜单更新";
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_newdiscount;
        private System.Windows.Forms.TextBox txb_olddiscount;
        private System.Windows.Forms.TextBox txb_newperprice;
        private System.Windows.Forms.TextBox txb_oldperprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ordername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_change;
    }
}