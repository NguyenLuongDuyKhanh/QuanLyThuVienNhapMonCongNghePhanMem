namespace GUI
{
    partial class ucThongKeTraSachTre
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
            this.dtgThongKeSachTre = new System.Windows.Forms.DataGridView();
            this.ID_PhieuMuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TheLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai_PhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKeSachTre)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgThongKeSachTre
            // 
            this.dtgThongKeSachTre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgThongKeSachTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongKeSachTre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PhieuMuonSach,
            this.HoTen_DocGia,
            this.Ten_Sach,
            this.Ten_TheLoaiSach,
            this.NgayMuon,
            this.GhiChu,
            this.TrangThai_PhieuMuon});
            this.dtgThongKeSachTre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgThongKeSachTre.Location = new System.Drawing.Point(0, 206);
            this.dtgThongKeSachTre.Name = "dtgThongKeSachTre";
            this.dtgThongKeSachTre.Size = new System.Drawing.Size(615, 311);
            this.dtgThongKeSachTre.TabIndex = 7;
            // 
            // ID_PhieuMuonSach
            // 
            this.ID_PhieuMuonSach.DataPropertyName = "ID_PhieuMuonSach";
            this.ID_PhieuMuonSach.HeaderText = "Mã phiếu mượn";
            this.ID_PhieuMuonSach.Name = "ID_PhieuMuonSach";
            // 
            // HoTen_DocGia
            // 
            this.HoTen_DocGia.DataPropertyName = "HoTen_DocGia";
            this.HoTen_DocGia.HeaderText = "Độc giả";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Báo cáo thống kê tình hình trả sách trễ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày";
            // 
            // ucThongKeTraSachTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgThongKeSachTre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucThongKeTraSachTre";
            this.Size = new System.Drawing.Size(615, 517);
            this.Load += new System.EventHandler(this.UcThongKeTraSachTre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKeSachTre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgThongKeSachTre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PhieuMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TheLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_PhieuMuon;
    }
}
