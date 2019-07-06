namespace WindowsFormsApp1
{
    partial class fAdmin
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.tabPhuTung = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowPT = new System.Windows.Forms.Button();
            this.btnEditPT = new System.Windows.Forms.Button();
            this.btnDeletePT = new System.Windows.Forms.Button();
            this.btnAddPT = new System.Windows.Forms.Button();
            this.dtgvPT = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbSearchPT = new System.Windows.Forms.TextBox();
            this.btnSearchPT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbHangPT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txbPTName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txbPTID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.dtgvdt = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabBill.SuspendLayout();
            this.tabPhuTung.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPT)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabBill);
            this.tabAdmin.Controls.Add(this.tabPhuTung);
            this.tabAdmin.Location = new System.Drawing.Point(0, 2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(760, 532);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.button1);
            this.tabBill.Controls.Add(this.dtgvdt);
            this.tabBill.Controls.Add(this.DTP2);
            this.tabBill.Controls.Add(this.DTP1);
            this.tabBill.Location = new System.Drawing.Point(4, 22);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(752, 506);
            this.tabBill.TabIndex = 0;
            this.tabBill.Text = "Doanh thu";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // tabPhuTung
            // 
            this.tabPhuTung.Controls.Add(this.panel1);
            this.tabPhuTung.Controls.Add(this.dtgvPT);
            this.tabPhuTung.Controls.Add(this.panel4);
            this.tabPhuTung.Controls.Add(this.panel3);
            this.tabPhuTung.Location = new System.Drawing.Point(4, 22);
            this.tabPhuTung.Name = "tabPhuTung";
            this.tabPhuTung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhuTung.Size = new System.Drawing.Size(752, 506);
            this.tabPhuTung.TabIndex = 1;
            this.tabPhuTung.Text = "Phụ tùng";
            this.tabPhuTung.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowPT);
            this.panel1.Controls.Add(this.btnEditPT);
            this.panel1.Controls.Add(this.btnDeletePT);
            this.panel1.Controls.Add(this.btnAddPT);
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 62);
            this.panel1.TabIndex = 4;
            // 
            // btnShowPT
            // 
            this.btnShowPT.Location = new System.Drawing.Point(246, 4);
            this.btnShowPT.Name = "btnShowPT";
            this.btnShowPT.Size = new System.Drawing.Size(75, 47);
            this.btnShowPT.TabIndex = 3;
            this.btnShowPT.Text = "Xem";
            this.btnShowPT.UseVisualStyleBackColor = true;
            this.btnShowPT.Click += new System.EventHandler(this.BtnShowPT_Click);
            // 
            // btnEditPT
            // 
            this.btnEditPT.Location = new System.Drawing.Point(165, 4);
            this.btnEditPT.Name = "btnEditPT";
            this.btnEditPT.Size = new System.Drawing.Size(75, 47);
            this.btnEditPT.TabIndex = 2;
            this.btnEditPT.Text = "Sửa";
            this.btnEditPT.UseVisualStyleBackColor = true;
            this.btnEditPT.Click += new System.EventHandler(this.BtnEditPT_Click);
            // 
            // btnDeletePT
            // 
            this.btnDeletePT.Location = new System.Drawing.Point(84, 4);
            this.btnDeletePT.Name = "btnDeletePT";
            this.btnDeletePT.Size = new System.Drawing.Size(75, 47);
            this.btnDeletePT.TabIndex = 1;
            this.btnDeletePT.Text = "Xóa";
            this.btnDeletePT.UseVisualStyleBackColor = true;
            this.btnDeletePT.Click += new System.EventHandler(this.BtnDeletePT_Click);
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
            // dtgvPT
            // 
            this.dtgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPT.Location = new System.Drawing.Point(3, 87);
            this.dtgvPT.Name = "dtgvPT";
            this.dtgvPT.Size = new System.Drawing.Size(358, 332);
            this.dtgvPT.TabIndex = 5;
            this.dtgvPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvPT_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbSearchPT);
            this.panel4.Controls.Add(this.btnSearchPT);
            this.panel4.Location = new System.Drawing.Point(376, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 62);
            this.panel4.TabIndex = 7;
            // 
            // txbSearchPT
            // 
            this.txbSearchPT.Location = new System.Drawing.Point(4, 17);
            this.txbSearchPT.Name = "txbSearchPT";
            this.txbSearchPT.Size = new System.Drawing.Size(176, 20);
            this.txbSearchPT.TabIndex = 4;
            // 
            // btnSearchPT
            // 
            this.btnSearchPT.Location = new System.Drawing.Point(186, 5);
            this.btnSearchPT.Name = "btnSearchPT";
            this.btnSearchPT.Size = new System.Drawing.Size(75, 47);
            this.btnSearchPT.TabIndex = 5;
            this.btnSearchPT.Text = "Tìm Kiếm";
            this.btnSearchPT.UseVisualStyleBackColor = true;
            this.btnSearchPT.Click += new System.EventHandler(this.BtnSearchPT_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel24);
            this.panel3.Controls.Add(this.panel25);
            this.panel3.Location = new System.Drawing.Point(376, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 335);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 42);
            this.panel2.TabIndex = 7;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(102, 12);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(167, 20);
            this.txbPrice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbHangPT);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(4, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 42);
            this.panel6.TabIndex = 7;
            // 
            // cbHangPT
            // 
            this.cbHangPT.FormattingEnabled = true;
            this.cbHangPT.Location = new System.Drawing.Point(104, 13);
            this.cbHangPT.Name = "cbHangPT";
            this.cbHangPT.Size = new System.Drawing.Size(167, 21);
            this.cbHangPT.TabIndex = 7;
            this.cbHangPT.SelectedIndexChanged += new System.EventHandler(this.CbHangPT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hãng xe : ";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txbPTName);
            this.panel24.Controls.Add(this.label9);
            this.panel24.Location = new System.Drawing.Point(4, 52);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(285, 42);
            this.panel24.TabIndex = 6;
            // 
            // txbPTName
            // 
            this.txbPTName.Location = new System.Drawing.Point(102, 12);
            this.txbPTName.Name = "txbPTName";
            this.txbPTName.Size = new System.Drawing.Size(167, 20);
            this.txbPTName.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên phụ tùng :";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txbPTID);
            this.panel25.Controls.Add(this.label10);
            this.panel25.Location = new System.Drawing.Point(4, 4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(285, 42);
            this.panel25.TabIndex = 5;
            // 
            // txbPTID
            // 
            this.txbPTID.Location = new System.Drawing.Point(102, 12);
            this.txbPTID.Name = "txbPTID";
            this.txbPTID.ReadOnly = true;
            this.txbPTID.Size = new System.Drawing.Size(167, 20);
            this.txbPTID.TabIndex = 0;
            this.txbPTID.TextChanged += new System.EventHandler(this.TxbPTID_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // DTP1
            // 
            this.DTP1.Location = new System.Drawing.Point(0, 3);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(200, 20);
            this.DTP1.TabIndex = 0;
            // 
            // DTP2
            // 
            this.DTP2.Location = new System.Drawing.Point(254, 3);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(200, 20);
            this.DTP2.TabIndex = 1;
            // 
            // dtgvdt
            // 
            this.dtgvdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdt.Location = new System.Drawing.Point(0, 85);
            this.dtgvdt.Name = "dtgvdt";
            this.dtgvdt.Size = new System.Drawing.Size(755, 406);
            this.dtgvdt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tải_xuống;
            this.ClientSize = new System.Drawing.Size(759, 527);
            this.Controls.Add(this.tabAdmin);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.Load += new System.EventHandler(this.FAdmin_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabBill.ResumeLayout(false);
            this.tabPhuTung.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPT)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TabPage tabPhuTung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowPT;
        private System.Windows.Forms.Button btnEditPT;
        private System.Windows.Forms.Button btnDeletePT;
        private System.Windows.Forms.Button btnAddPT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbSearchPT;
        private System.Windows.Forms.Button btnSearchPT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbHangPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txbPTID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvPT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPTName;
        private System.Windows.Forms.DataGridView dtgvdt;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Button button1;
    }
}