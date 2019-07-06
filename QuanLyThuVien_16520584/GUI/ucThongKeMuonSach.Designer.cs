namespace GUI
{
    partial class ucThongKeMuonSach
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPhieuMuon = new System.Windows.Forms.DataGridView();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_PhieuMuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TheLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai_PhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng số lượt mượn";
            // 
            // dtgPhieuMuon
            // 
            this.dtgPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PhieuMuonSach,
            this.HoTen_DocGia,
            this.Ten_Sach,
            this.Ten_TheLoaiSach,
            this.NgayMuon,
            this.GhiChu,
            this.TrangThai_PhieuMuon});
            this.dtgPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPhieuMuon.Location = new System.Drawing.Point(0, 283);
            this.dtgPhieuMuon.Name = "dtgPhieuMuon";
            this.dtgPhieuMuon.Size = new System.Drawing.Size(878, 353);
            this.dtgPhieuMuon.TabIndex = 8;
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(166, 121);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 32);
            this.cboThang.TabIndex = 7;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.CboThang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Báo Cáo Thống Kê Tình Hình Mượn Sách Theo Thể Loại";
            // 
            // ID_PhieuMuonSach
            // 
            this.ID_PhieuMuonSach.DataPropertyName = "ID_PhieuMuonSach";
            this.ID_PhieuMuonSach.HeaderText = "Mã phiếu mượn sách";
            this.ID_PhieuMuonSach.Name = "ID_PhieuMuonSach";
            // 
            // HoTen_DocGia
            // 
            this.HoTen_DocGia.DataPropertyName = "HoTen_DocGia";
            this.HoTen_DocGia.HeaderText = "Tên độc giả";
            this.HoTen_DocGia.Name = "HoTen_DocGia";
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.DataPropertyName = "Ten_Sach";
            this.Ten_Sach.HeaderText = "Tên sách";
            this.Ten_Sach.Name = "Ten_Sach";
            // 
            // Ten_TheLoaiSach
            // 
            this.Ten_TheLoaiSach.DataPropertyName = "Ten_TheLoaiSach";
            this.Ten_TheLoaiSach.HeaderText = "Thể loại sách";
            this.Ten_TheLoaiSach.Name = "Ten_TheLoaiSach";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thể loại sách";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(166, 181);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cboTheLoai.TabIndex = 11;
            this.cboTheLoai.SelectedIndexChanged += new System.EventHandler(this.CboTheLoai_SelectedIndexChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(264, 237);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(39, 20);
            this.txtKetQua.TabIndex = 12;
            // 
            // ucThongKeMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgPhieuMuon);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucThongKeMuonSach";
            this.Size = new System.Drawing.Size(878, 636);
            this.Load += new System.EventHandler(this.UcThongKeMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgPhieuMuon;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PhieuMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TheLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_PhieuMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}
