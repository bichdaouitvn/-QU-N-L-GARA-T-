namespace WindowsFormsApp1
{
    partial class fManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpArea = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbHangXe = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbSearchKH = new System.Windows.Forms.TextBox();
            this.btnSearchPT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowPT = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 594);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.flpArea);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1163, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý khách và xe";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // flpArea
            // 
            this.flpArea.AutoScroll = true;
            this.flpArea.Location = new System.Drawing.Point(503, 3);
            this.flpArea.Name = "flpArea";
            this.flpArea.Size = new System.Drawing.Size(657, 244);
            this.flpArea.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.panel15);
            this.panel8.Location = new System.Drawing.Point(3, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(304, 334);
            this.panel8.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBox7);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(3, 273);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(285, 42);
            this.panel10.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(81, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(195, 20);
            this.textBox7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ :";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.textBox8);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(3, 225);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(285, 42);
            this.panel11.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(110, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(167, 20);
            this.textBox8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại :";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.textBox9);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Location = new System.Drawing.Point(3, 177);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(285, 42);
            this.panel12.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(111, 12);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(167, 20);
            this.textBox9.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên khách hàng :";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cbHangXe);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Location = new System.Drawing.Point(3, 99);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(285, 42);
            this.panel13.TabIndex = 8;
            // 
            // cbHangXe
            // 
            this.cbHangXe.FormattingEnabled = true;
            this.cbHangXe.Location = new System.Drawing.Point(104, 13);
            this.cbHangXe.Name = "cbHangXe";
            this.cbHangXe.Size = new System.Drawing.Size(167, 21);
            this.cbHangXe.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Hãng xe : ";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.textBox10);
            this.panel14.Controls.Add(this.label13);
            this.panel14.Location = new System.Drawing.Point(3, 51);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(285, 42);
            this.panel14.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(102, 12);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(167, 20);
            this.textBox10.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Biển số xe :";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBox11);
            this.panel15.Controls.Add(this.label14);
            this.panel15.Location = new System.Drawing.Point(3, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(285, 42);
            this.panel15.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(102, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(167, 20);
            this.textBox11.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên xe :";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(945, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(367, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 42);
            this.panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 270);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowPT);
            this.panel2.Controls.Add(this.btnAddPT);
            this.panel2.Location = new System.Drawing.Point(3, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 62);
            this.panel2.TabIndex = 5;
            // 
            // btnAddPT
            // 
            this.btnAddPT.Location = new System.Drawing.Point(3, 4);
            this.btnAddPT.Name = "btnAddPT";
            this.btnAddPT.Size = new System.Drawing.Size(75, 47);
            this.btnAddPT.TabIndex = 0;
            this.btnAddPT.Text = "Thêm";
            this.btnAddPT.UseVisualStyleBackColor = true;
            this.btnAddPT.Click += new System.EventHandler(this.BtnAddPT_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbSearchKH);
            this.panel4.Controls.Add(this.btnSearchPT);
            this.panel4.Location = new System.Drawing.Point(3, 414);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 62);
            this.panel4.TabIndex = 8;
            // 
            // txbSearchKH
            // 
            this.txbSearchKH.Location = new System.Drawing.Point(4, 17);
            this.txbSearchKH.Name = "txbSearchKH";
            this.txbSearchKH.Size = new System.Drawing.Size(176, 20);
            this.txbSearchKH.TabIndex = 2;
            // 
            // btnSearchPT
            // 
            this.btnSearchPT.Location = new System.Drawing.Point(186, 5);
            this.btnSearchPT.Name = "btnSearchPT";
            this.btnSearchPT.Size = new System.Drawing.Size(75, 47);
            this.btnSearchPT.TabIndex = 1;
            this.btnSearchPT.Text = "Tìm Kiếm";
            this.btnSearchPT.UseVisualStyleBackColor = true;
            this.btnSearchPT.Click += new System.EventHandler(this.BtnSearchPT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Chọn khu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnShowPT
            // 
            this.btnShowPT.Location = new System.Drawing.Point(84, 4);
            this.btnShowPT.Name = "btnShowPT";
            this.btnShowPT.Size = new System.Drawing.Size(75, 47);
            this.btnShowPT.TabIndex = 3;
            this.btnShowPT.Text = "Xem";
            this.btnShowPT.UseVisualStyleBackColor = true;
            this.btnShowPT.Click += new System.EventHandler(this.BtnShowPT_Click);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManager";
            this.Text = "Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cbHangXe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flpArea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddPT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbSearchKH;
        private System.Windows.Forms.Button btnSearchPT;
        private System.Windows.Forms.Button btnShowPT;
    }
}