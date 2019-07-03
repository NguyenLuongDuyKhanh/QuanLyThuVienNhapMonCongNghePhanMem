namespace GUI
{
    partial class ucTimSach
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
            this.cbTimTheo = new System.Windows.Forms.ComboBox();
            this.txtTimTuKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.dtgThongTinSach = new System.Windows.Forms.DataGridView();
            this.Ten_TheLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongTinSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo";
            // 
            // cbTimTheo
            // 
            this.cbTimTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimTheo.FormattingEnabled = true;
            this.cbTimTheo.Items.AddRange(new object[] {
            "Thể loại sách",
            "Tên sách",
            "Tác giả",
            "Nhà xuất bản"});
            this.cbTimTheo.Location = new System.Drawing.Point(158, 46);
            this.cbTimTheo.Name = "cbTimTheo";
            this.cbTimTheo.Size = new System.Drawing.Size(167, 32);
            this.cbTimTheo.TabIndex = 1;
            this.cbTimTheo.SelectedValueChanged += new System.EventHandler(this.CbTimTheo_SelectedValueChanged);
            // 
            // txtTimTuKhoa
            // 
            this.txtTimTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTuKhoa.Location = new System.Drawing.Point(433, 46);
            this.txtTimTuKhoa.Name = "txtTimTuKhoa";
            this.txtTimTuKhoa.Size = new System.Drawing.Size(177, 29);
            this.txtTimTuKhoa.TabIndex = 2;
            this.txtTimTuKhoa.TextChanged += new System.EventHandler(this.TxtTimTuKhoa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ khóa";
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(664, 46);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(127, 32);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.BtTim_Click);
            // 
            // dtgThongTinSach
            // 
            this.dtgThongTinSach.AllowUserToAddRows = false;
            this.dtgThongTinSach.AllowUserToDeleteRows = false;
            this.dtgThongTinSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongTinSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_TheLoaiSach,
            this.Ten_TacGia,
            this.Ten_NXB,
            this.Ten_Sach,
            this.Gia,
            this.NamXuatBan});
            this.dtgThongTinSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgThongTinSach.Location = new System.Drawing.Point(0, 119);
            this.dtgThongTinSach.Name = "dtgThongTinSach";
            this.dtgThongTinSach.ReadOnly = true;
            this.dtgThongTinSach.Size = new System.Drawing.Size(1050, 496);
            this.dtgThongTinSach.TabIndex = 5;
            // 
            // Ten_TheLoaiSach
            // 
            this.Ten_TheLoaiSach.DataPropertyName = "Ten_TheLoaiSach";
            this.Ten_TheLoaiSach.HeaderText = "Tên thể loại";
            this.Ten_TheLoaiSach.Name = "Ten_TheLoaiSach";
            this.Ten_TheLoaiSach.ReadOnly = true;
            // 
            // Ten_TacGia
            // 
            this.Ten_TacGia.DataPropertyName = "Ten_TacGia";
            this.Ten_TacGia.HeaderText = "Tác giả";
            this.Ten_TacGia.Name = "Ten_TacGia";
            this.Ten_TacGia.ReadOnly = true;
            // 
            // Ten_NXB
            // 
            this.Ten_NXB.DataPropertyName = "Ten_NXB";
            this.Ten_NXB.HeaderText = "Tên nhà xuất bản";
            this.Ten_NXB.Name = "Ten_NXB";
            this.Ten_NXB.ReadOnly = true;
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.DataPropertyName = "Ten_Sach";
            this.Ten_Sach.HeaderText = "Tên sách";
            this.Ten_Sach.Name = "Ten_Sach";
            this.Ten_Sach.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm xuất bản";
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            // 
            // ucTimSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgThongTinSach);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimTuKhoa);
            this.Controls.Add(this.cbTimTheo);
            this.Controls.Add(this.label1);
            this.Name = "ucTimSach";
            this.Size = new System.Drawing.Size(1050, 615);
            this.Load += new System.EventHandler(this.UcTimSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongTinSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimTheo;
        private System.Windows.Forms.TextBox txtTimTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridView dtgThongTinSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TheLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
    }
}
