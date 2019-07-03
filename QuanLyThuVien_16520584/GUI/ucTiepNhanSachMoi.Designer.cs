namespace GUI
{
    partial class ucTiepNhanSachMoi
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
            this.btHoanTat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.cboTheLoaiSach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgSach = new System.Windows.Forms.DataGridView();
            this.ID_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TheLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sl_Nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btHoanTat
            // 
            this.btHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoanTat.Location = new System.Drawing.Point(138, 460);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(113, 45);
            this.btHoanTat.TabIndex = 37;
            this.btHoanTat.Text = "Hoàn Tất";
            this.btHoanTat.UseVisualStyleBackColor = true;
            this.btHoanTat.Click += new System.EventHandler(this.BtHoanTat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(195, 212);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(263, 29);
            this.txtMoTa.TabIndex = 35;
            this.txtMoTa.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(195, 403);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(263, 29);
            this.txtSoLuong.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Số lượng nhập";
            // 
            // txtTriGia
            // 
            this.txtTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriGia.Location = new System.Drawing.Point(195, 368);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(263, 29);
            this.txtTriGia.TabIndex = 32;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Location = new System.Drawing.Point(195, 331);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(263, 29);
            this.dtpNgayNhap.TabIndex = 31;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaXuatBan.Location = new System.Drawing.Point(195, 289);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(263, 29);
            this.txtNhaXuatBan.TabIndex = 30;
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXuatBan.Location = new System.Drawing.Point(195, 249);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(263, 29);
            this.txtNamXuatBan.TabIndex = 29;
            // 
            // cboTacGia
            // 
            this.cboTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(195, 174);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(263, 32);
            this.cboTacGia.TabIndex = 28;
            // 
            // cboTheLoaiSach
            // 
            this.cboTheLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTheLoaiSach.FormattingEnabled = true;
            this.cboTheLoaiSach.Location = new System.Drawing.Point(195, 136);
            this.cboTheLoaiSach.Name = "cboTheLoaiSach";
            this.cboTheLoaiSach.Size = new System.Drawing.Size(263, 32);
            this.cboTheLoaiSach.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Trị giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nhà xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Năm xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tác giả";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(195, 92);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(263, 29);
            this.txtTenSach.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 33);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tiếp nhận sách";
            // 
            // dtgSach
            // 
            this.dtgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Sach,
            this.Ten_TheLoaiSach,
            this.Ten_TacGia,
            this.Ten_NXB,
            this.Ten_Sach,
            this.Gia,
            this.Sl_Nhap,
            this.NamXuatBan});
            this.dtgSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgSach.Location = new System.Drawing.Point(0, 556);
            this.dtgSach.Name = "dtgSach";
            this.dtgSach.Size = new System.Drawing.Size(1503, 119);
            this.dtgSach.TabIndex = 39;
            this.dtgSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgSach_CellContentClick);
            // 
            // ID_Sach
            // 
            this.ID_Sach.DataPropertyName = "ID_Sach";
            this.ID_Sach.HeaderText = "ID_Sach";
            this.ID_Sach.Name = "ID_Sach";
            // 
            // Ten_TheLoaiSach
            // 
            this.Ten_TheLoaiSach.DataPropertyName = "Ten_TheLoaiSach";
            this.Ten_TheLoaiSach.HeaderText = "Ten_TheLoaiSach";
            this.Ten_TheLoaiSach.Name = "Ten_TheLoaiSach";
            // 
            // Ten_TacGia
            // 
            this.Ten_TacGia.DataPropertyName = "Ten_TacGia";
            this.Ten_TacGia.HeaderText = "Ten_TacGia";
            this.Ten_TacGia.Name = "Ten_TacGia";
            // 
            // Ten_NXB
            // 
            this.Ten_NXB.DataPropertyName = "Ten_NXB";
            this.Ten_NXB.HeaderText = "Ten_NXB";
            this.Ten_NXB.Name = "Ten_NXB";
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.DataPropertyName = "Ten_Sach";
            this.Ten_Sach.HeaderText = "Ten_Sach";
            this.Ten_Sach.Name = "Ten_Sach";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Gia";
            this.Gia.Name = "Gia";
            // 
            // Sl_Nhap
            // 
            this.Sl_Nhap.DataPropertyName = "Sl_Nhap";
            this.Sl_Nhap.HeaderText = "Sl_Nhap";
            this.Sl_Nhap.Name = "Sl_Nhap";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "NamXuatBan";
            this.NamXuatBan.Name = "NamXuatBan";
            // 
            // ucTiepNhanSachMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dtgSach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTriGia);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.txtNamXuatBan);
            this.Controls.Add(this.cboTacGia);
            this.Controls.Add(this.cboTheLoaiSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucTiepNhanSachMoi";
            this.Size = new System.Drawing.Size(1503, 675);
            this.Load += new System.EventHandler(this.ucTiepNhanSachMoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHoanTat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.ComboBox cboTheLoaiSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TheLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl_Nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
    }
}
