namespace GUI
{
    partial class ucPhieuTraSach
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
            this.btKiemTra = new System.Windows.Forms.Button();
            this.dtgPhieuTra = new System.Windows.Forms.DataGridView();
            this.ID_PhieuMuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TheDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NguoiMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sl_SachMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai_PhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSachtra = new System.Windows.Forms.ComboBox();
            this.cboDocgia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuTra)).BeginInit();
            this.SuspendLayout();
            // 
            // BTHoanTat
            // 
            this.BTHoanTat.Location = new System.Drawing.Point(327, 105);
            this.BTHoanTat.Name = "BTHoanTat";
            this.BTHoanTat.Size = new System.Drawing.Size(75, 23);
            this.BTHoanTat.TabIndex = 17;
            this.BTHoanTat.Text = "Hoàn tất";
            this.BTHoanTat.UseVisualStyleBackColor = true;
            // 
            // btKiemTra
            // 
            this.btKiemTra.Location = new System.Drawing.Point(327, 38);
            this.btKiemTra.Name = "btKiemTra";
            this.btKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btKiemTra.TabIndex = 16;
            this.btKiemTra.Text = "Kiểm tra";
            this.btKiemTra.UseVisualStyleBackColor = true;
            // 
            // dtgPhieuTra
            // 
            this.dtgPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PhieuMuonSach,
            this.ID_TheDocGia,
            this.ID_Sach,
            this.Ten_NguoiMuon,
            this.NgayMuon,
            this.Sl_SachMuon,
            this.GhiChu,
            this.TrangThai_PhieuMuon});
            this.dtgPhieuTra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPhieuTra.Location = new System.Drawing.Point(0, 243);
            this.dtgPhieuTra.Name = "dtgPhieuTra";
            this.dtgPhieuTra.Size = new System.Drawing.Size(666, 204);
            this.dtgPhieuTra.TabIndex = 15;
            // 
            // ID_PhieuMuonSach
            // 
            this.ID_PhieuMuonSach.DataPropertyName = "ID_PhieuMuonSach";
            this.ID_PhieuMuonSach.HeaderText = "ID_PhieuMuonSach";
            this.ID_PhieuMuonSach.Name = "ID_PhieuMuonSach";
            // 
            // ID_TheDocGia
            // 
            this.ID_TheDocGia.DataPropertyName = "ID_TheDocGia";
            this.ID_TheDocGia.HeaderText = "ID_TheDocGia";
            this.ID_TheDocGia.Name = "ID_TheDocGia";
            // 
            // ID_Sach
            // 
            this.ID_Sach.DataPropertyName = "ID_Sach";
            this.ID_Sach.HeaderText = "ID_Sach";
            this.ID_Sach.Name = "ID_Sach";
            // 
            // Ten_NguoiMuon
            // 
            this.Ten_NguoiMuon.DataPropertyName = "Ten_NguoiMuon";
            this.Ten_NguoiMuon.HeaderText = "Ten_NguoiMuon";
            this.Ten_NguoiMuon.Name = "Ten_NguoiMuon";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "NgayMuon";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // Sl_SachMuon
            // 
            this.Sl_SachMuon.DataPropertyName = "Sl_SachMuon";
            this.Sl_SachMuon.HeaderText = "Sl_SachMuon";
            this.Sl_SachMuon.Name = "Sl_SachMuon";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            // 
            // TrangThai_PhieuMuon
            // 
            this.TrangThai_PhieuMuon.DataPropertyName = "TrangThai_PhieuMuon";
            this.TrangThai_PhieuMuon.HeaderText = "TrangThai_PhieuMuon";
            this.TrangThai_PhieuMuon.Name = "TrangThai_PhieuMuon";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Location = new System.Drawing.Point(153, 156);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(200, 29);
            this.dtpNgayTra.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày trả";
            // 
            // cboSachtra
            // 
            this.cboSachtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSachtra.FormattingEnabled = true;
            this.cboSachtra.Location = new System.Drawing.Point(153, 105);
            this.cboSachtra.Name = "cboSachtra";
            this.cboSachtra.Size = new System.Drawing.Size(121, 32);
            this.cboSachtra.TabIndex = 12;
            // 
            // cboDocgia
            // 
            this.cboDocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDocgia.FormattingEnabled = true;
            this.cboDocgia.Location = new System.Drawing.Point(153, 53);
            this.cboDocgia.Name = "cboDocgia";
            this.cboDocgia.Size = new System.Drawing.Size(121, 32);
            this.cboDocgia.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã sách trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phiếu trả sách";
            // 
            // ucPhieuTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTHoanTat);
            this.Controls.Add(this.btKiemTra);
            this.Controls.Add(this.dtgPhieuTra);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSachtra);
            this.Controls.Add(this.cboDocgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucPhieuTraSach";
            this.Size = new System.Drawing.Size(666, 447);
            this.Load += new System.EventHandler(this.UcPhieuTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTHoanTat;
        private System.Windows.Forms.Button btKiemTra;
        private System.Windows.Forms.DataGridView dtgPhieuTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSachtra;
        private System.Windows.Forms.ComboBox cboDocgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PhieuMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TheDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NguoiMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl_SachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_PhieuMuon;
    }
}
