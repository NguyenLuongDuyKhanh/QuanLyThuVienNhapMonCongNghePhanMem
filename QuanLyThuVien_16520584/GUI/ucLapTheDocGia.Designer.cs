namespace GUI
{
    partial class ucLapTheDocGia
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
            this.dtpNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.dtpNgaySinhDocGia = new System.Windows.Forms.DateTimePicker();
            this.cboLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgTheDocGia = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTuoiToiThieu = new System.Windows.Forms.TextBox();
            this.txtTuoiToiDa = new System.Windows.Forms.TextBox();
            this.txtThoiHanThe = new System.Windows.Forms.TextBox();
            this.ID_TheDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_LoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai_TheDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayLapThe
            // 
            this.dtpNgayLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLapThe.Location = new System.Drawing.Point(570, 100);
            this.dtpNgayLapThe.Name = "dtpNgayLapThe";
            this.dtpNgayLapThe.Size = new System.Drawing.Size(275, 29);
            this.dtpNgayLapThe.TabIndex = 28;
            this.dtpNgayLapThe.ValueChanged += new System.EventHandler(this.DtpNgayLapThe_ValueChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(158, 140);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(275, 29);
            this.txtDiaChi.TabIndex = 18;
            // 
            // btLuu
            // 
            this.btLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(570, 184);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(275, 34);
            this.btLuu.TabIndex = 27;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.BtLuu_Click);
            // 
            // dtpNgaySinhDocGia
            // 
            this.dtpNgaySinhDocGia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhDocGia.Location = new System.Drawing.Point(158, 100);
            this.dtpNgaySinhDocGia.Name = "dtpNgaySinhDocGia";
            this.dtpNgaySinhDocGia.Size = new System.Drawing.Size(275, 29);
            this.dtpNgaySinhDocGia.TabIndex = 26;
            // 
            // cboLoaiDocGia
            // 
            this.cboLoaiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiDocGia.FormattingEnabled = true;
            this.cboLoaiDocGia.Location = new System.Drawing.Point(570, 62);
            this.cboLoaiDocGia.Name = "cboLoaiDocGia";
            this.cboLoaiDocGia.Size = new System.Drawing.Size(275, 32);
            this.cboLoaiDocGia.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ngày lập thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(158, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 29);
            this.txtEmail.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Loại độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Họ và tên";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTen.Location = new System.Drawing.Point(158, 65);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(275, 29);
            this.txtHoVaTen.TabIndex = 16;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHetHan.Location = new System.Drawing.Point(570, 141);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.ReadOnly = true;
            this.txtNgayHetHan.Size = new System.Drawing.Size(275, 29);
            this.txtNgayHetHan.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ngày hết hạn";
            // 
            // dtgTheDocGia
            // 
            this.dtgTheDocGia.AllowUserToAddRows = false;
            this.dtgTheDocGia.AllowUserToDeleteRows = false;
            this.dtgTheDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTheDocGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTheDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTheDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TheDocGia,
            this.Ten_LoaiDocGia,
            this.HoTen_DocGia,
            this.NgaySinh_DocGia,
            this.DiaChi_DocGia,
            this.Email_DocGia,
            this.NgayLapThe,
            this.NgayHetHan,
            this.TrangThai_TheDocGia});
            this.dtgTheDocGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgTheDocGia.Location = new System.Drawing.Point(0, 298);
            this.dtgTheDocGia.MultiSelect = false;
            this.dtgTheDocGia.Name = "dtgTheDocGia";
            this.dtgTheDocGia.ReadOnly = true;
            this.dtgTheDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTheDocGia.Size = new System.Drawing.Size(1073, 364);
            this.dtgTheDocGia.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 33);
            this.label8.TabIndex = 32;
            this.label8.Text = "Lập thẻ độc giả";
            // 
            // txtTuoiToiThieu
            // 
            this.txtTuoiToiThieu.Location = new System.Drawing.Point(408, 250);
            this.txtTuoiToiThieu.Name = "txtTuoiToiThieu";
            this.txtTuoiToiThieu.ReadOnly = true;
            this.txtTuoiToiThieu.Size = new System.Drawing.Size(100, 20);
            this.txtTuoiToiThieu.TabIndex = 33;
            // 
            // txtTuoiToiDa
            // 
            this.txtTuoiToiDa.Location = new System.Drawing.Point(525, 250);
            this.txtTuoiToiDa.Name = "txtTuoiToiDa";
            this.txtTuoiToiDa.ReadOnly = true;
            this.txtTuoiToiDa.Size = new System.Drawing.Size(100, 20);
            this.txtTuoiToiDa.TabIndex = 34;
            // 
            // txtThoiHanThe
            // 
            this.txtThoiHanThe.Location = new System.Drawing.Point(640, 250);
            this.txtThoiHanThe.Name = "txtThoiHanThe";
            this.txtThoiHanThe.ReadOnly = true;
            this.txtThoiHanThe.Size = new System.Drawing.Size(100, 20);
            this.txtThoiHanThe.TabIndex = 35;
            // 
            // ID_TheDocGia
            // 
            this.ID_TheDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_TheDocGia.DataPropertyName = "ID_TheDocGia";
            this.ID_TheDocGia.HeaderText = "Mã thẻ";
            this.ID_TheDocGia.Name = "ID_TheDocGia";
            this.ID_TheDocGia.ReadOnly = true;
            this.ID_TheDocGia.Width = 50;
            // 
            // Ten_LoaiDocGia
            // 
            this.Ten_LoaiDocGia.DataPropertyName = "Ten_LoaiDocGia";
            this.Ten_LoaiDocGia.HeaderText = "Loại độc giả";
            this.Ten_LoaiDocGia.Name = "Ten_LoaiDocGia";
            this.Ten_LoaiDocGia.ReadOnly = true;
            // 
            // HoTen_DocGia
            // 
            this.HoTen_DocGia.DataPropertyName = "HoTen_DocGia";
            this.HoTen_DocGia.HeaderText = "Họ tên";
            this.HoTen_DocGia.Name = "HoTen_DocGia";
            this.HoTen_DocGia.ReadOnly = true;
            // 
            // NgaySinh_DocGia
            // 
            this.NgaySinh_DocGia.DataPropertyName = "NgaySinh_DocGia";
            this.NgaySinh_DocGia.HeaderText = "Ngày sinh";
            this.NgaySinh_DocGia.Name = "NgaySinh_DocGia";
            this.NgaySinh_DocGia.ReadOnly = true;
            // 
            // DiaChi_DocGia
            // 
            this.DiaChi_DocGia.DataPropertyName = "DiaChi_DocGia";
            this.DiaChi_DocGia.HeaderText = "Địa chỉ độc giả";
            this.DiaChi_DocGia.Name = "DiaChi_DocGia";
            this.DiaChi_DocGia.ReadOnly = true;
            // 
            // Email_DocGia
            // 
            this.Email_DocGia.DataPropertyName = "Email_DocGia";
            this.Email_DocGia.HeaderText = "Email";
            this.Email_DocGia.Name = "Email_DocGia";
            this.Email_DocGia.ReadOnly = true;
            // 
            // NgayLapThe
            // 
            this.NgayLapThe.DataPropertyName = "NgayLapThe";
            this.NgayLapThe.HeaderText = "Ngày lập thẻ";
            this.NgayLapThe.Name = "NgayLapThe";
            this.NgayLapThe.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // TrangThai_TheDocGia
            // 
            this.TrangThai_TheDocGia.DataPropertyName = "TrangThai_TheDocGia";
            this.TrangThai_TheDocGia.HeaderText = "Trạng thái";
            this.TrangThai_TheDocGia.Name = "TrangThai_TheDocGia";
            this.TrangThai_TheDocGia.ReadOnly = true;
            // 
            // ucLapTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtThoiHanThe);
            this.Controls.Add(this.txtTuoiToiDa);
            this.Controls.Add(this.txtTuoiToiThieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgTheDocGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayHetHan);
            this.Controls.Add(this.dtpNgayLapThe);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.dtpNgaySinhDocGia);
            this.Controls.Add(this.cboLoaiDocGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoVaTen);
            this.Name = "ucLapTheDocGia";
            this.Size = new System.Drawing.Size(1073, 662);
            this.Load += new System.EventHandler(this.UcLapTheDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayLapThe;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhDocGia;
        private System.Windows.Forms.ComboBox cboLoaiDocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgTheDocGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTuoiToiThieu;
        private System.Windows.Forms.TextBox txtTuoiToiDa;
        private System.Windows.Forms.TextBox txtThoiHanThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TheDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_LoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_TheDocGia;
    }
}
