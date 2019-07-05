namespace GUI
{
    partial class ucPhieuMuonSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTHoanTat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboMaSachMuon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPhieuMuonSach = new System.Windows.Forms.DataGridView();
            this.cboMaDocGia = new System.Windows.Forms.ComboBox();
            this.dpkNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_PhieuMuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TheDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHenTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai_PhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // BTHoanTat
            // 
            this.BTHoanTat.Location = new System.Drawing.Point(498, 63);
            this.BTHoanTat.Margin = new System.Windows.Forms.Padding(6);
            this.BTHoanTat.Name = "BTHoanTat";
            this.BTHoanTat.Size = new System.Drawing.Size(114, 38);
            this.BTHoanTat.TabIndex = 17;
            this.BTHoanTat.Text = "Hoàn tất";
            this.BTHoanTat.UseVisualStyleBackColor = true;
            this.BTHoanTat.Click += new System.EventHandler(this.BTHoanTat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, -75);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboMaSachMuon
            // 
            this.cboMaSachMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaSachMuon.FormattingEnabled = true;
            this.cboMaSachMuon.Location = new System.Drawing.Point(164, 114);
            this.cboMaSachMuon.Margin = new System.Windows.Forms.Padding(6);
            this.cboMaSachMuon.Name = "cboMaSachMuon";
            this.cboMaSachMuon.Size = new System.Drawing.Size(219, 32);
            this.cboMaSachMuon.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã sách mượn";
            // 
            // dtgPhieuMuonSach
            // 
            this.dtgPhieuMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPhieuMuonSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PhieuMuonSach,
            this.ID_TheDocGia,
            this.ID_Sach,
            this.NgayMuon,
            this.NgayHenTra,
            this.GhiChu,
            this.TrangThai_PhieuMuon});
            this.dtgPhieuMuonSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPhieuMuonSach.Location = new System.Drawing.Point(0, 332);
            this.dtgPhieuMuonSach.Margin = new System.Windows.Forms.Padding(6);
            this.dtgPhieuMuonSach.Name = "dtgPhieuMuonSach";
            this.dtgPhieuMuonSach.Size = new System.Drawing.Size(850, 355);
            this.dtgPhieuMuonSach.TabIndex = 13;
            // 
            // cboMaDocGia
            // 
            this.cboMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaDocGia.FormattingEnabled = true;
            this.cboMaDocGia.Location = new System.Drawing.Point(164, 69);
            this.cboMaDocGia.Margin = new System.Windows.Forms.Padding(6);
            this.cboMaDocGia.Name = "cboMaDocGia";
            this.cboMaDocGia.Size = new System.Drawing.Size(219, 32);
            this.cboMaDocGia.TabIndex = 12;
            // 
            // dpkNgayMuon
            // 
            this.dpkNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgayMuon.Location = new System.Drawing.Point(157, 158);
            this.dpkNgayMuon.Margin = new System.Windows.Forms.Padding(6);
            this.dpkNgayMuon.Name = "dpkNgayMuon";
            this.dpkNgayMuon.Size = new System.Drawing.Size(363, 29);
            this.dpkNgayMuon.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phiếu mượn sách";
            // 
            // ID_PhieuMuonSach
            // 
            this.ID_PhieuMuonSach.DataPropertyName = "ID_PhieuMuonSach";
            this.ID_PhieuMuonSach.HeaderText = "Mã phiếu mượn sách";
            this.ID_PhieuMuonSach.Name = "ID_PhieuMuonSach";
            // 
            // ID_TheDocGia
            // 
            this.ID_TheDocGia.DataPropertyName = "ID_TheDocGia";
            this.ID_TheDocGia.HeaderText = "Mã độc giả";
            this.ID_TheDocGia.Name = "ID_TheDocGia";
            // 
            // ID_Sach
            // 
            this.ID_Sach.DataPropertyName = "ID_Sach";
            this.ID_Sach.HeaderText = "Mã sách";
            this.ID_Sach.Name = "ID_Sach";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayHenTra
            // 
            this.NgayHenTra.DataPropertyName = "NgayHenTra";
            this.NgayHenTra.HeaderText = "Ngày hẹn trả";
            this.NgayHenTra.Name = "NgayHenTra";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // TrangThai_PhieuMuon
            // 
            this.TrangThai_PhieuMuon.DataPropertyName = "TrangThai_PhieuMuon";
            this.TrangThai_PhieuMuon.HeaderText = "Trạng thái";
            this.TrangThai_PhieuMuon.Name = "TrangThai_PhieuMuon";
            // 
            // ucPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTHoanTat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboMaSachMuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgPhieuMuonSach);
            this.Controls.Add(this.cboMaDocGia);
            this.Controls.Add(this.dpkNgayMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucPhieuMuonSach";
            this.Size = new System.Drawing.Size(850, 687);
            this.Load += new System.EventHandler(this.ucPhieuMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTHoanTat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboMaSachMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgPhieuMuonSach;
        private System.Windows.Forms.ComboBox cboMaDocGia;
        private System.Windows.Forms.DateTimePicker dpkNgayMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PhieuMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TheDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHenTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_PhieuMuon;
    }
}
