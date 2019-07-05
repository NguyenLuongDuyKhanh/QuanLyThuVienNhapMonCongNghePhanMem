namespace GUI
{
    partial class ucChinhSuaQuyDinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTuoiToiThieu = new System.Windows.Forms.TextBox();
            this.txtThoiHanThe = new System.Windows.Forms.TextBox();
            this.txtNamXuatban = new System.Windows.Forms.TextBox();
            this.txtSoSachMuonToiDa = new System.Windows.Forms.TextBox();
            this.txtSoNgayMuonToiDa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTuoiToiDa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTuoiToiThieuThayDoi = new System.Windows.Forms.TextBox();
            this.txtTuoiToiDaThayDoi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThoiHanTheThayDoi = new System.Windows.Forms.TextBox();
            this.txtNamXuatBanThayDoi = new System.Windows.Forms.TextBox();
            this.txtSoSachMuonToiDaThayDoi = new System.Windows.Forms.TextBox();
            this.txtSoNgayMuonToiDaThayDoi = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThemTheLoai = new System.Windows.Forms.Button();
            this.dtgTheLoai = new System.Windows.Forms.DataGridView();
            this.ID_TheLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TheLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThemTheLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh sửa quy định";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quy định hiện tại";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới hạn tuổi độc giả";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời hạn thẻ độc giả (tháng)";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới hạn năm xuất bản";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số sách tối đa mượn mỗi lần";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số ngày tối đa mỗi lần mượn";
            // 
            // txtTuoiToiThieu
            // 
            this.txtTuoiToiThieu.Location = new System.Drawing.Point(242, 135);
            this.txtTuoiToiThieu.Name = "txtTuoiToiThieu";
            this.txtTuoiToiThieu.ReadOnly = true;
            this.txtTuoiToiThieu.Size = new System.Drawing.Size(28, 20);
            this.txtTuoiToiThieu.TabIndex = 8;
            // 
            // txtThoiHanThe
            // 
            this.txtThoiHanThe.Location = new System.Drawing.Point(242, 164);
            this.txtThoiHanThe.Name = "txtThoiHanThe";
            this.txtThoiHanThe.ReadOnly = true;
            this.txtThoiHanThe.Size = new System.Drawing.Size(100, 20);
            this.txtThoiHanThe.TabIndex = 9;
            // 
            // txtNamXuatban
            // 
            this.txtNamXuatban.Location = new System.Drawing.Point(242, 201);
            this.txtNamXuatban.Name = "txtNamXuatban";
            this.txtNamXuatban.ReadOnly = true;
            this.txtNamXuatban.Size = new System.Drawing.Size(100, 20);
            this.txtNamXuatban.TabIndex = 10;
            // 
            // txtSoSachMuonToiDa
            // 
            this.txtSoSachMuonToiDa.Location = new System.Drawing.Point(242, 234);
            this.txtSoSachMuonToiDa.Name = "txtSoSachMuonToiDa";
            this.txtSoSachMuonToiDa.ReadOnly = true;
            this.txtSoSachMuonToiDa.Size = new System.Drawing.Size(100, 20);
            this.txtSoSachMuonToiDa.TabIndex = 11;
            // 
            // txtSoNgayMuonToiDa
            // 
            this.txtSoNgayMuonToiDa.Location = new System.Drawing.Point(242, 270);
            this.txtSoNgayMuonToiDa.Name = "txtSoNgayMuonToiDa";
            this.txtSoNgayMuonToiDa.ReadOnly = true;
            this.txtSoNgayMuonToiDa.Size = new System.Drawing.Size(100, 20);
            this.txtSoNgayMuonToiDa.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Chỉnh sửa";
            // 
            // txtTuoiToiDa
            // 
            this.txtTuoiToiDa.Location = new System.Drawing.Point(314, 135);
            this.txtTuoiToiDa.Name = "txtTuoiToiDa";
            this.txtTuoiToiDa.ReadOnly = true;
            this.txtTuoiToiDa.Size = new System.Drawing.Size(28, 20);
            this.txtTuoiToiDa.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "-";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // txtTuoiToiThieuThayDoi
            // 
            this.txtTuoiToiThieuThayDoi.Location = new System.Drawing.Point(362, 138);
            this.txtTuoiToiThieuThayDoi.Name = "txtTuoiToiThieuThayDoi";
            this.txtTuoiToiThieuThayDoi.Size = new System.Drawing.Size(28, 20);
            this.txtTuoiToiThieuThayDoi.TabIndex = 16;
            // 
            // txtTuoiToiDaThayDoi
            // 
            this.txtTuoiToiDaThayDoi.Location = new System.Drawing.Point(434, 138);
            this.txtTuoiToiDaThayDoi.Name = "txtTuoiToiDaThayDoi";
            this.txtTuoiToiDaThayDoi.Size = new System.Drawing.Size(28, 20);
            this.txtTuoiToiDaThayDoi.TabIndex = 17;
            this.txtTuoiToiDaThayDoi.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "-";
            // 
            // txtThoiHanTheThayDoi
            // 
            this.txtThoiHanTheThayDoi.Location = new System.Drawing.Point(362, 164);
            this.txtThoiHanTheThayDoi.Name = "txtThoiHanTheThayDoi";
            this.txtThoiHanTheThayDoi.Size = new System.Drawing.Size(100, 20);
            this.txtThoiHanTheThayDoi.TabIndex = 19;
            // 
            // txtNamXuatBanThayDoi
            // 
            this.txtNamXuatBanThayDoi.Location = new System.Drawing.Point(362, 197);
            this.txtNamXuatBanThayDoi.Name = "txtNamXuatBanThayDoi";
            this.txtNamXuatBanThayDoi.Size = new System.Drawing.Size(100, 20);
            this.txtNamXuatBanThayDoi.TabIndex = 20;
            // 
            // txtSoSachMuonToiDaThayDoi
            // 
            this.txtSoSachMuonToiDaThayDoi.Location = new System.Drawing.Point(362, 230);
            this.txtSoSachMuonToiDaThayDoi.Name = "txtSoSachMuonToiDaThayDoi";
            this.txtSoSachMuonToiDaThayDoi.Size = new System.Drawing.Size(100, 20);
            this.txtSoSachMuonToiDaThayDoi.TabIndex = 21;
            // 
            // txtSoNgayMuonToiDaThayDoi
            // 
            this.txtSoNgayMuonToiDaThayDoi.Location = new System.Drawing.Point(362, 267);
            this.txtSoNgayMuonToiDaThayDoi.Name = "txtSoNgayMuonToiDaThayDoi";
            this.txtSoNgayMuonToiDaThayDoi.Size = new System.Drawing.Size(100, 20);
            this.txtSoNgayMuonToiDaThayDoi.TabIndex = 22;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(314, 305);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 24;
            this.btLuu.Text = "Lưu thay đổi";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.BtLuu_Click);
            // 
            // btThemTheLoai
            // 
            this.btThemTheLoai.Location = new System.Drawing.Point(532, 305);
            this.btThemTheLoai.Name = "btThemTheLoai";
            this.btThemTheLoai.Size = new System.Drawing.Size(85, 23);
            this.btThemTheLoai.TabIndex = 25;
            this.btThemTheLoai.Text = "Thêm thể loại";
            this.btThemTheLoai.UseVisualStyleBackColor = true;
            this.btThemTheLoai.Click += new System.EventHandler(this.BtThemTheLoai_Click_1);
            // 
            // dtgTheLoai
            // 
            this.dtgTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TheLoaiSach,
            this.Ten_TheLoaiSach});
            this.dtgTheLoai.Location = new System.Drawing.Point(541, 123);
            this.dtgTheLoai.Name = "dtgTheLoai";
            this.dtgTheLoai.Size = new System.Drawing.Size(247, 127);
            this.dtgTheLoai.TabIndex = 27;
            this.dtgTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgTheLoai_CellContentClick);
            // 
            // ID_TheLoaiSach
            // 
            this.ID_TheLoaiSach.DataPropertyName = "ID_TheLoaiSach";
            this.ID_TheLoaiSach.HeaderText = "Mã thể loại";
            this.ID_TheLoaiSach.Name = "ID_TheLoaiSach";
            // 
            // Ten_TheLoaiSach
            // 
            this.Ten_TheLoaiSach.DataPropertyName = "Ten_TheLoaiSach";
            this.Ten_TheLoaiSach.HeaderText = "Tên thể loại";
            this.Ten_TheLoaiSach.Name = "Ten_TheLoaiSach";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Thêm thể loại sách";
            // 
            // txtThemTheLoai
            // 
            this.txtThemTheLoai.Location = new System.Drawing.Point(654, 97);
            this.txtThemTheLoai.Name = "txtThemTheLoai";
            this.txtThemTheLoai.Size = new System.Drawing.Size(100, 20);
            this.txtThemTheLoai.TabIndex = 30;
            // 
            // ucChinhSuaQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtThemTheLoai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgTheLoai);
            this.Controls.Add(this.btThemTheLoai);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.txtSoNgayMuonToiDaThayDoi);
            this.Controls.Add(this.txtSoSachMuonToiDaThayDoi);
            this.Controls.Add(this.txtNamXuatBanThayDoi);
            this.Controls.Add(this.txtThoiHanTheThayDoi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTuoiToiDaThayDoi);
            this.Controls.Add(this.txtTuoiToiThieuThayDoi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTuoiToiDa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoNgayMuonToiDa);
            this.Controls.Add(this.txtSoSachMuonToiDa);
            this.Controls.Add(this.txtNamXuatban);
            this.Controls.Add(this.txtThoiHanThe);
            this.Controls.Add(this.txtTuoiToiThieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ucChinhSuaQuyDinh";
            this.Size = new System.Drawing.Size(1161, 528);
            this.Load += new System.EventHandler(this.UcChinhSuaQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTuoiToiThieu;
        private System.Windows.Forms.TextBox txtThoiHanThe;
        private System.Windows.Forms.TextBox txtNamXuatban;
        private System.Windows.Forms.TextBox txtSoSachMuonToiDa;
        private System.Windows.Forms.TextBox txtSoNgayMuonToiDa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTuoiToiDa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTuoiToiThieuThayDoi;
        private System.Windows.Forms.TextBox txtTuoiToiDaThayDoi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThoiHanTheThayDoi;
        private System.Windows.Forms.TextBox txtNamXuatBanThayDoi;
        private System.Windows.Forms.TextBox txtSoSachMuonToiDaThayDoi;
        private System.Windows.Forms.TextBox txtSoNgayMuonToiDaThayDoi;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThemTheLoai;
        private System.Windows.Forms.DataGridView dtgTheLoai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThemTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TheLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TheLoaiSach;
    }
}
