namespace GUI
{
    partial class frmTraCuuSach
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
            this.ckbTheLoai = new System.Windows.Forms.CheckBox();
            this.ckbTacGia = new System.Windows.Forms.CheckBox();
            this.ckbNhaXuatBan = new System.Windows.Forms.CheckBox();
            this.ckbTinhTrang = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckbGiaTri = new System.Windows.Forms.CheckBox();
            this.dontcare = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.cboNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.txtGiaBot = new System.Windows.Forms.TextBox();
            this.ckbID_Sach = new System.Windows.Forms.CheckBox();
            this.txtGiaTop = new System.Windows.Forms.TextBox();
            this.ckbNamXuatBan = new System.Windows.Forms.CheckBox();
            this.txtNamXuatBanBot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamXuatBanTop = new System.Windows.Forms.TextBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btHoanTat = new System.Windows.Forms.Button();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbTheLoai
            // 
            this.ckbTheLoai.AutoSize = true;
            this.ckbTheLoai.Location = new System.Drawing.Point(21, 49);
            this.ckbTheLoai.Name = "ckbTheLoai";
            this.ckbTheLoai.Size = new System.Drawing.Size(107, 17);
            this.ckbTheLoai.TabIndex = 0;
            this.ckbTheLoai.Text = "Lọc thể loại sách";
            this.ckbTheLoai.UseVisualStyleBackColor = true;
            this.ckbTheLoai.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // ckbTacGia
            // 
            this.ckbTacGia.AutoSize = true;
            this.ckbTacGia.Location = new System.Drawing.Point(21, 71);
            this.ckbTacGia.Name = "ckbTacGia";
            this.ckbTacGia.Size = new System.Drawing.Size(79, 17);
            this.ckbTacGia.TabIndex = 1;
            this.ckbTacGia.Text = "Lọc tác giả";
            this.ckbTacGia.UseVisualStyleBackColor = true;
            // 
            // ckbNhaXuatBan
            // 
            this.ckbNhaXuatBan.AutoSize = true;
            this.ckbNhaXuatBan.Location = new System.Drawing.Point(21, 93);
            this.ckbNhaXuatBan.Name = "ckbNhaXuatBan";
            this.ckbNhaXuatBan.Size = new System.Drawing.Size(109, 17);
            this.ckbNhaXuatBan.TabIndex = 2;
            this.ckbNhaXuatBan.Text = "Lọc nhà xuất bản";
            this.ckbNhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // ckbTinhTrang
            // 
            this.ckbTinhTrang.AutoSize = true;
            this.ckbTinhTrang.Location = new System.Drawing.Point(21, 115);
            this.ckbTinhTrang.Name = "ckbTinhTrang";
            this.ckbTinhTrang.Size = new System.Drawing.Size(132, 17);
            this.ckbTinhTrang.TabIndex = 3;
            this.ckbTinhTrang.Text = "Lọc sách có thể mượn";
            this.ckbTinhTrang.UseVisualStyleBackColor = true;
            this.ckbTinhTrang.CheckedChanged += new System.EventHandler(this.CkbTinhTrang_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 260);
            this.dataGridView1.TabIndex = 4;
            // 
            // ckbGiaTri
            // 
            this.ckbGiaTri.AutoSize = true;
            this.ckbGiaTri.Location = new System.Drawing.Point(21, 137);
            this.ckbGiaTri.Name = "ckbGiaTri";
            this.ckbGiaTri.Size = new System.Drawing.Size(124, 17);
            this.ckbGiaTri.TabIndex = 5;
            this.ckbGiaTri.Text = "Lọc theo khoảng giá";
            this.ckbGiaTri.UseVisualStyleBackColor = true;
            this.ckbGiaTri.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // dontcare
            // 
            this.dontcare.AutoSize = true;
            this.dontcare.Location = new System.Drawing.Point(226, 133);
            this.dontcare.Name = "dontcare";
            this.dontcare.Size = new System.Drawing.Size(10, 13);
            this.dontcare.TabIndex = 6;
            this.dontcare.Text = "-";
            this.dontcare.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(180, 45);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cboTheLoai.TabIndex = 7;
            // 
            // cboTacGia
            // 
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(180, 67);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(121, 21);
            this.cboTacGia.TabIndex = 8;
            this.cboTacGia.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // cboNhaXuatBan
            // 
            this.cboNhaXuatBan.FormattingEnabled = true;
            this.cboNhaXuatBan.Location = new System.Drawing.Point(180, 89);
            this.cboNhaXuatBan.Name = "cboNhaXuatBan";
            this.cboNhaXuatBan.Size = new System.Drawing.Size(121, 21);
            this.cboNhaXuatBan.TabIndex = 9;
            // 
            // txtGiaBot
            // 
            this.txtGiaBot.Location = new System.Drawing.Point(180, 130);
            this.txtGiaBot.Name = "txtGiaBot";
            this.txtGiaBot.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGiaBot.Size = new System.Drawing.Size(40, 20);
            this.txtGiaBot.TabIndex = 10;
            // 
            // ckbID_Sach
            // 
            this.ckbID_Sach.AutoSize = true;
            this.ckbID_Sach.Location = new System.Drawing.Point(21, 27);
            this.ckbID_Sach.Name = "ckbID_Sach";
            this.ckbID_Sach.Size = new System.Drawing.Size(136, 17);
            this.ckbID_Sach.TabIndex = 11;
            this.ckbID_Sach.Text = "Tìm sách theo mã sách";
            this.ckbID_Sach.UseVisualStyleBackColor = true;
            // 
            // txtGiaTop
            // 
            this.txtGiaTop.Location = new System.Drawing.Point(242, 130);
            this.txtGiaTop.Name = "txtGiaTop";
            this.txtGiaTop.Size = new System.Drawing.Size(45, 20);
            this.txtGiaTop.TabIndex = 12;
            this.txtGiaTop.TextChanged += new System.EventHandler(this.TxtGiaTop_TextChanged);
            // 
            // ckbNamXuatBan
            // 
            this.ckbNamXuatBan.AutoSize = true;
            this.ckbNamXuatBan.Location = new System.Drawing.Point(21, 159);
            this.ckbNamXuatBan.Name = "ckbNamXuatBan";
            this.ckbNamXuatBan.Size = new System.Drawing.Size(135, 17);
            this.ckbNamXuatBan.TabIndex = 13;
            this.ckbNamXuatBan.Text = "Lọc theo năm xuất bản";
            this.ckbNamXuatBan.UseVisualStyleBackColor = true;
            // 
            // txtNamXuatBanBot
            // 
            this.txtNamXuatBanBot.Location = new System.Drawing.Point(180, 156);
            this.txtNamXuatBanBot.Name = "txtNamXuatBanBot";
            this.txtNamXuatBanBot.Size = new System.Drawing.Size(40, 20);
            this.txtNamXuatBanBot.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // txtNamXuatBanTop
            // 
            this.txtNamXuatBanTop.Location = new System.Drawing.Point(242, 156);
            this.txtNamXuatBanTop.Name = "txtNamXuatBanTop";
            this.txtNamXuatBanTop.Size = new System.Drawing.Size(45, 20);
            this.txtNamXuatBanTop.TabIndex = 16;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(180, 111);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cboTinhTrang.TabIndex = 17;
            this.cboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.CboTinhTrang_SelectedIndexChanged);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(45, 197);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 18;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // btHoanTat
            // 
            this.btHoanTat.Location = new System.Drawing.Point(202, 194);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(90, 29);
            this.btHoanTat.TabIndex = 19;
            this.btHoanTat.Text = "Hoàn tất";
            this.btHoanTat.UseVisualStyleBackColor = true;
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(180, 25);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(121, 21);
            this.cboMaSach.TabIndex = 20;
            this.cboMaSach.SelectedIndexChanged += new System.EventHandler(this.ComboBox4_SelectedIndexChanged);
            // 
            // frmTraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 527);
            this.Controls.Add(this.cboMaSach);
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.txtNamXuatBanTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamXuatBanBot);
            this.Controls.Add(this.ckbNamXuatBan);
            this.Controls.Add(this.txtGiaTop);
            this.Controls.Add(this.ckbID_Sach);
            this.Controls.Add(this.txtGiaBot);
            this.Controls.Add(this.cboNhaXuatBan);
            this.Controls.Add(this.cboTacGia);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.dontcare);
            this.Controls.Add(this.ckbGiaTri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ckbTinhTrang);
            this.Controls.Add(this.ckbNhaXuatBan);
            this.Controls.Add(this.ckbTacGia);
            this.Controls.Add(this.ckbTheLoai);
            this.Name = "frmTraCuuSach";
            this.Text = "Tra cứu sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbTheLoai;
        private System.Windows.Forms.CheckBox ckbTacGia;
        private System.Windows.Forms.CheckBox ckbNhaXuatBan;
        private System.Windows.Forms.CheckBox ckbTinhTrang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ckbGiaTri;
        private System.Windows.Forms.Label dontcare;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.ComboBox cboNhaXuatBan;
        private System.Windows.Forms.TextBox txtGiaBot;
        private System.Windows.Forms.CheckBox ckbID_Sach;
        private System.Windows.Forms.TextBox txtGiaTop;
        private System.Windows.Forms.CheckBox ckbNamXuatBan;
        private System.Windows.Forms.TextBox txtNamXuatBanBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamXuatBanTop;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btHoanTat;
        private System.Windows.Forms.ComboBox cboMaSach;
    }
}