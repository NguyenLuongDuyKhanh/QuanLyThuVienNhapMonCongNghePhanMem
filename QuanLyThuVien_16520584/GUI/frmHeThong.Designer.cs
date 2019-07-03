namespace GUI
{
    partial class frmHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLapPhieuPhat = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btNhanTraSach = new System.Windows.Forms.Button();
            this.btChoMuonSach = new System.Windows.Forms.Button();
            this.btTraCuuSach = new System.Windows.Forms.Button();
            this.btNTiepNhanSachMoi = new System.Windows.Forms.Button();
            this.btLapTheDocGia = new System.Windows.Forms.Button();
            this.pnSlide_R = new System.Windows.Forms.Panel();
            this.btTrangChu = new System.Windows.Forms.Button();
            this.pnSlide_L = new System.Windows.Forms.Panel();
            this.pnRibbon = new System.Windows.Forms.Panel();
            this.pnBangDieuKhien_Show = new System.Windows.Forms.Panel();
            this.btChinhSua = new System.Windows.Forms.Button();
            this.btThongKeSachMuon = new System.Windows.Forms.Button();
            this.btThongKeSachTre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbNgay = new System.Windows.Forms.Label();
            this.pnBangDieuKhien_Hide = new System.Windows.Forms.Panel();
            this.btMenu = new System.Windows.Forms.Button();
            this.ucLapTheDocGia1 = new GUI.ucLapTheDocGia();
            this.ucTiepNhanSachMoi1 = new GUI.ucTiepNhanSachMoi();
            this.ucPhieuMuonSach1 = new GUI.ucPhieuMuonSach();
            this.ucPhieuTraSach1 = new GUI.ucPhieuTraSach();
            this.ucPhieuPhat1 = new GUI.ucPhieuPhat();
            this.ucThongKeMuonSach1 = new GUI.ucThongKeMuonSach();
            this.ucTraCuuSach1 = new GUI.ucTraCuuSach();
            this.ucThongKeTraSachTre1 = new GUI.ucThongKeTraSachTre();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnBangDieuKhien_Show.SuspendLayout();
            this.pnBangDieuKhien_Hide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 80);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btLapPhieuPhat
            // 
            this.btLapPhieuPhat.BackColor = System.Drawing.Color.Transparent;
            this.btLapPhieuPhat.FlatAppearance.BorderSize = 0;
            this.btLapPhieuPhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btLapPhieuPhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLapPhieuPhat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapPhieuPhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLapPhieuPhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLapPhieuPhat.Location = new System.Drawing.Point(29, 416);
            this.btLapPhieuPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLapPhieuPhat.Name = "btLapPhieuPhat";
            this.btLapPhieuPhat.Size = new System.Drawing.Size(154, 42);
            this.btLapPhieuPhat.TabIndex = 10;
            this.btLapPhieuPhat.Text = "Lập phiếu phạt";
            this.btLapPhieuPhat.UseVisualStyleBackColor = false;
            this.btLapPhieuPhat.Click += new System.EventHandler(this.BtLapPhieuPhat_Click);
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.Transparent;
            this.btHelp.FlatAppearance.BorderSize = 0;
            this.btHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHelp.Location = new System.Drawing.Point(29, 490);
            this.btHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(41, 32);
            this.btHelp.TabIndex = 6;
            this.btHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHelp.UseVisualStyleBackColor = false;
            // 
            // btNhanTraSach
            // 
            this.btNhanTraSach.BackColor = System.Drawing.Color.Transparent;
            this.btNhanTraSach.FlatAppearance.BorderSize = 0;
            this.btNhanTraSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btNhanTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhanTraSach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanTraSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNhanTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhanTraSach.Location = new System.Drawing.Point(29, 369);
            this.btNhanTraSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNhanTraSach.Name = "btNhanTraSach";
            this.btNhanTraSach.Size = new System.Drawing.Size(154, 42);
            this.btNhanTraSach.TabIndex = 7;
            this.btNhanTraSach.Text = "Nhận trả sách";
            this.btNhanTraSach.UseVisualStyleBackColor = false;
            this.btNhanTraSach.Click += new System.EventHandler(this.BtNhanTraSach_Click);
            // 
            // btChoMuonSach
            // 
            this.btChoMuonSach.BackColor = System.Drawing.Color.Transparent;
            this.btChoMuonSach.FlatAppearance.BorderSize = 0;
            this.btChoMuonSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btChoMuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChoMuonSach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoMuonSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChoMuonSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChoMuonSach.Location = new System.Drawing.Point(29, 322);
            this.btChoMuonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChoMuonSach.Name = "btChoMuonSach";
            this.btChoMuonSach.Size = new System.Drawing.Size(154, 42);
            this.btChoMuonSach.TabIndex = 6;
            this.btChoMuonSach.Text = "Cho  mượn sách";
            this.btChoMuonSach.UseVisualStyleBackColor = false;
            this.btChoMuonSach.Click += new System.EventHandler(this.BtChoMuonSach_Click);
            // 
            // btTraCuuSach
            // 
            this.btTraCuuSach.BackColor = System.Drawing.Color.Transparent;
            this.btTraCuuSach.FlatAppearance.BorderSize = 0;
            this.btTraCuuSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btTraCuuSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraCuuSach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraCuuSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTraCuuSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTraCuuSach.Location = new System.Drawing.Point(29, 275);
            this.btTraCuuSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTraCuuSach.Name = "btTraCuuSach";
            this.btTraCuuSach.Size = new System.Drawing.Size(154, 42);
            this.btTraCuuSach.TabIndex = 6;
            this.btTraCuuSach.Text = "Tra cứu sách";
            this.btTraCuuSach.UseVisualStyleBackColor = false;
            this.btTraCuuSach.Click += new System.EventHandler(this.BtTraCuuSach_Click);
            // 
            // btNTiepNhanSachMoi
            // 
            this.btNTiepNhanSachMoi.BackColor = System.Drawing.Color.Transparent;
            this.btNTiepNhanSachMoi.FlatAppearance.BorderSize = 0;
            this.btNTiepNhanSachMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btNTiepNhanSachMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNTiepNhanSachMoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNTiepNhanSachMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNTiepNhanSachMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNTiepNhanSachMoi.Location = new System.Drawing.Point(29, 228);
            this.btNTiepNhanSachMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNTiepNhanSachMoi.Name = "btNTiepNhanSachMoi";
            this.btNTiepNhanSachMoi.Size = new System.Drawing.Size(154, 42);
            this.btNTiepNhanSachMoi.TabIndex = 6;
            this.btNTiepNhanSachMoi.Text = "Tiếp nhận sách mới";
            this.btNTiepNhanSachMoi.UseVisualStyleBackColor = false;
            this.btNTiepNhanSachMoi.Click += new System.EventHandler(this.BtNTiepNhanSachMoi_Click);
            // 
            // btLapTheDocGia
            // 
            this.btLapTheDocGia.BackColor = System.Drawing.Color.Transparent;
            this.btLapTheDocGia.FlatAppearance.BorderSize = 0;
            this.btLapTheDocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btLapTheDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLapTheDocGia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapTheDocGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLapTheDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLapTheDocGia.Location = new System.Drawing.Point(29, 180);
            this.btLapTheDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLapTheDocGia.Name = "btLapTheDocGia";
            this.btLapTheDocGia.Size = new System.Drawing.Size(154, 42);
            this.btLapTheDocGia.TabIndex = 5;
            this.btLapTheDocGia.Text = "  Lập thẻ độc giả";
            this.btLapTheDocGia.UseVisualStyleBackColor = false;
            this.btLapTheDocGia.Click += new System.EventHandler(this.BtLapTheDocGia_Click);
            // 
            // pnSlide_R
            // 
            this.pnSlide_R.BackColor = System.Drawing.Color.Brown;
            this.pnSlide_R.Location = new System.Drawing.Point(182, 133);
            this.pnSlide_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSlide_R.Name = "pnSlide_R";
            this.pnSlide_R.Size = new System.Drawing.Size(11, 42);
            this.pnSlide_R.TabIndex = 4;
            // 
            // btTrangChu
            // 
            this.btTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btTrangChu.FlatAppearance.BorderSize = 0;
            this.btTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTrangChu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrangChu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTrangChu.Location = new System.Drawing.Point(29, 133);
            this.btTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTrangChu.Name = "btTrangChu";
            this.btTrangChu.Size = new System.Drawing.Size(154, 42);
            this.btTrangChu.TabIndex = 3;
            this.btTrangChu.Text = "Trang Chủ";
            this.btTrangChu.UseVisualStyleBackColor = false;
            this.btTrangChu.Click += new System.EventHandler(this.BtTrangChu_Click);
            // 
            // pnSlide_L
            // 
            this.pnSlide_L.BackColor = System.Drawing.Color.Brown;
            this.pnSlide_L.Location = new System.Drawing.Point(19, 133);
            this.pnSlide_L.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSlide_L.Name = "pnSlide_L";
            this.pnSlide_L.Size = new System.Drawing.Size(11, 42);
            this.pnSlide_L.TabIndex = 3;
            // 
            // pnRibbon
            // 
            this.pnRibbon.BackColor = System.Drawing.Color.Brown;
            this.pnRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRibbon.Location = new System.Drawing.Point(0, 0);
            this.pnRibbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnRibbon.Name = "pnRibbon";
            this.pnRibbon.Size = new System.Drawing.Size(1189, 18);
            this.pnRibbon.TabIndex = 67;
            // 
            // pnBangDieuKhien_Show
            // 
            this.pnBangDieuKhien_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnBangDieuKhien_Show.Controls.Add(this.btChinhSua);
            this.pnBangDieuKhien_Show.Controls.Add(this.btThongKeSachMuon);
            this.pnBangDieuKhien_Show.Controls.Add(this.btThongKeSachTre);
            this.pnBangDieuKhien_Show.Controls.Add(this.panel1);
            this.pnBangDieuKhien_Show.Controls.Add(this.panel2);
            this.pnBangDieuKhien_Show.Controls.Add(this.btLapPhieuPhat);
            this.pnBangDieuKhien_Show.Controls.Add(this.btHelp);
            this.pnBangDieuKhien_Show.Controls.Add(this.btExit);
            this.pnBangDieuKhien_Show.Controls.Add(this.btNhanTraSach);
            this.pnBangDieuKhien_Show.Controls.Add(this.btChoMuonSach);
            this.pnBangDieuKhien_Show.Controls.Add(this.btTraCuuSach);
            this.pnBangDieuKhien_Show.Controls.Add(this.btNTiepNhanSachMoi);
            this.pnBangDieuKhien_Show.Controls.Add(this.btLapTheDocGia);
            this.pnBangDieuKhien_Show.Controls.Add(this.pnSlide_R);
            this.pnBangDieuKhien_Show.Controls.Add(this.pnSlide_L);
            this.pnBangDieuKhien_Show.Controls.Add(this.btTrangChu);
            this.pnBangDieuKhien_Show.Controls.Add(this.btBack);
            this.pnBangDieuKhien_Show.Location = new System.Drawing.Point(-19, 16);
            this.pnBangDieuKhien_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBangDieuKhien_Show.Name = "pnBangDieuKhien_Show";
            this.pnBangDieuKhien_Show.Size = new System.Drawing.Size(194, 721);
            this.pnBangDieuKhien_Show.TabIndex = 66;
            // 
            // btChinhSua
            // 
            this.btChinhSua.BackColor = System.Drawing.Color.Transparent;
            this.btChinhSua.FlatAppearance.BorderSize = 0;
            this.btChinhSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChinhSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChinhSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChinhSua.Location = new System.Drawing.Point(29, 553);
            this.btChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChinhSua.Name = "btChinhSua";
            this.btChinhSua.Size = new System.Drawing.Size(154, 42);
            this.btChinhSua.TabIndex = 69;
            this.btChinhSua.Text = "Chỉnh sửa";
            this.btChinhSua.UseVisualStyleBackColor = false;
            // 
            // btThongKeSachMuon
            // 
            this.btThongKeSachMuon.BackColor = System.Drawing.Color.Transparent;
            this.btThongKeSachMuon.FlatAppearance.BorderSize = 0;
            this.btThongKeSachMuon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btThongKeSachMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKeSachMuon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKeSachMuon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThongKeSachMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKeSachMuon.Location = new System.Drawing.Point(29, 507);
            this.btThongKeSachMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThongKeSachMuon.Name = "btThongKeSachMuon";
            this.btThongKeSachMuon.Size = new System.Drawing.Size(154, 42);
            this.btThongKeSachMuon.TabIndex = 68;
            this.btThongKeSachMuon.Text = "Thống kê sách mượn";
            this.btThongKeSachMuon.UseVisualStyleBackColor = false;
            this.btThongKeSachMuon.Click += new System.EventHandler(this.BtThongKeSachMuon_Click);
            // 
            // btThongKeSachTre
            // 
            this.btThongKeSachTre.BackColor = System.Drawing.Color.Transparent;
            this.btThongKeSachTre.FlatAppearance.BorderSize = 0;
            this.btThongKeSachTre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btThongKeSachTre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKeSachTre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKeSachTre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThongKeSachTre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKeSachTre.Location = new System.Drawing.Point(29, 460);
            this.btThongKeSachTre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThongKeSachTre.Name = "btThongKeSachTre";
            this.btThongKeSachTre.Size = new System.Drawing.Size(154, 42);
            this.btThongKeSachTre.TabIndex = 68;
            this.btThongKeSachTre.Text = "Thống kê sách trễ";
            this.btThongKeSachTre.UseVisualStyleBackColor = false;
            this.btThongKeSachTre.Click += new System.EventHandler(this.BtThongKeSachTre_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(91, -19);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 63);
            this.panel2.TabIndex = 12;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Location = new System.Drawing.Point(123, 490);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(41, 32);
            this.btExit.TabIndex = 5;
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBack.Image = global::GUI.Properties.Resources.left_arrow;
            this.btBack.Location = new System.Drawing.Point(143, -6);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(51, 50);
            this.btBack.TabIndex = 4;
            this.btBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lbNgay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbNgay.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNgay.Location = new System.Drawing.Point(1189, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(41, 17);
            this.lbNgay.TabIndex = 62;
            this.lbNgay.Text = "Ngày";
            // 
            // pnBangDieuKhien_Hide
            // 
            this.pnBangDieuKhien_Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnBangDieuKhien_Hide.Controls.Add(this.btMenu);
            this.pnBangDieuKhien_Hide.Location = new System.Drawing.Point(-2, 16);
            this.pnBangDieuKhien_Hide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBangDieuKhien_Hide.Name = "pnBangDieuKhien_Hide";
            this.pnBangDieuKhien_Hide.Size = new System.Drawing.Size(50, 687);
            this.pnBangDieuKhien_Hide.TabIndex = 60;
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMenu.Image = global::GUI.Properties.Resources.menu;
            this.btMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMenu.Location = new System.Drawing.Point(6, 6);
            this.btMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(44, 49);
            this.btMenu.TabIndex = 3;
            this.btMenu.Text = "Menu";
            this.btMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMenu.UseVisualStyleBackColor = false;
            this.btMenu.Click += new System.EventHandler(this.BtMenu_Click);
            // 
            // ucLapTheDocGia1
            // 
            this.ucLapTheDocGia1.Location = new System.Drawing.Point(176, 16);
            this.ucLapTheDocGia1.Name = "ucLapTheDocGia1";
            this.ucLapTheDocGia1.Size = new System.Drawing.Size(1142, 612);
            this.ucLapTheDocGia1.TabIndex = 68;
            this.ucLapTheDocGia1.Load += new System.EventHandler(this.UcLapTheDocGia1_Load);
            // 
            // ucTiepNhanSachMoi1
            // 
            this.ucTiepNhanSachMoi1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucTiepNhanSachMoi1.Location = new System.Drawing.Point(176, 16);
            this.ucTiepNhanSachMoi1.Name = "ucTiepNhanSachMoi1";
            this.ucTiepNhanSachMoi1.Size = new System.Drawing.Size(988, 556);
            this.ucTiepNhanSachMoi1.TabIndex = 69;
            this.ucTiepNhanSachMoi1.Load += new System.EventHandler(this.UcTiepNhanSachMoi1_Load);
            // 
            // ucPhieuMuonSach1
            // 
            this.ucPhieuMuonSach1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPhieuMuonSach1.Location = new System.Drawing.Point(173, 15);
            this.ucPhieuMuonSach1.Margin = new System.Windows.Forms.Padding(6);
            this.ucPhieuMuonSach1.Name = "ucPhieuMuonSach1";
            this.ucPhieuMuonSach1.Size = new System.Drawing.Size(1068, 689);
            this.ucPhieuMuonSach1.TabIndex = 70;
            // 
            // ucPhieuTraSach1
            // 
            this.ucPhieuTraSach1.Location = new System.Drawing.Point(176, 18);
            this.ucPhieuTraSach1.Name = "ucPhieuTraSach1";
            this.ucPhieuTraSach1.Size = new System.Drawing.Size(832, 446);
            this.ucPhieuTraSach1.TabIndex = 71;
            // 
            // ucPhieuPhat1
            // 
            this.ucPhieuPhat1.Location = new System.Drawing.Point(173, 15);
            this.ucPhieuPhat1.Name = "ucPhieuPhat1";
            this.ucPhieuPhat1.Size = new System.Drawing.Size(517, 426);
            this.ucPhieuPhat1.TabIndex = 72;
            // 
            // ucThongKeMuonSach1
            // 
            this.ucThongKeMuonSach1.Location = new System.Drawing.Point(173, 15);
            this.ucThongKeMuonSach1.Name = "ucThongKeMuonSach1";
            this.ucThongKeMuonSach1.Size = new System.Drawing.Size(761, 651);
            this.ucThongKeMuonSach1.TabIndex = 73;
            this.ucThongKeMuonSach1.Load += new System.EventHandler(this.UcThongKeMuonSach1_Load);
            // 
            // ucTraCuuSach1
            // 
            this.ucTraCuuSach1.Location = new System.Drawing.Point(177, 18);
            this.ucTraCuuSach1.Name = "ucTraCuuSach1";
            this.ucTraCuuSach1.Size = new System.Drawing.Size(757, 594);
            this.ucTraCuuSach1.TabIndex = 74;
            // 
            // ucThongKeTraSachTre1
            // 
            this.ucThongKeTraSachTre1.Location = new System.Drawing.Point(176, 16);
            this.ucThongKeTraSachTre1.Name = "ucThongKeTraSachTre1";
            this.ucThongKeTraSachTre1.Size = new System.Drawing.Size(781, 532);
            this.ucThongKeTraSachTre1.TabIndex = 75;
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 732);
            this.Controls.Add(this.ucThongKeTraSachTre1);
            this.Controls.Add(this.ucTraCuuSach1);
            this.Controls.Add(this.ucThongKeMuonSach1);
            this.Controls.Add(this.ucPhieuPhat1);
            this.Controls.Add(this.ucPhieuTraSach1);
            this.Controls.Add(this.ucPhieuMuonSach1);
            this.Controls.Add(this.ucTiepNhanSachMoi1);
            this.Controls.Add(this.ucLapTheDocGia1);
            this.Controls.Add(this.pnBangDieuKhien_Show);
            this.Controls.Add(this.pnRibbon);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.pnBangDieuKhien_Hide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHeThong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHeThong_FormClosing);
            this.Load += new System.EventHandler(this.FrmHeThong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnBangDieuKhien_Show.ResumeLayout(false);
            this.pnBangDieuKhien_Hide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLapPhieuPhat;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btNhanTraSach;
        private System.Windows.Forms.Button btChoMuonSach;
        private System.Windows.Forms.Button btTraCuuSach;
        private System.Windows.Forms.Button btNTiepNhanSachMoi;
        private System.Windows.Forms.Button btLapTheDocGia;
        private System.Windows.Forms.Panel pnSlide_R;
        private System.Windows.Forms.Button btTrangChu;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel pnSlide_L;
        private System.Windows.Forms.Panel pnRibbon;
        private System.Windows.Forms.Panel pnBangDieuKhien_Show;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Panel pnBangDieuKhien_Hide;
        private System.Windows.Forms.Button btThongKeSachMuon;
        private System.Windows.Forms.Button btThongKeSachTre;
        private System.Windows.Forms.Button btMenu;
        private ucLapTheDocGia ucLapTheDocGia1;
        private ucTiepNhanSachMoi ucTiepNhanSachMoi1;
        private ucPhieuMuonSach ucPhieuMuonSach1;
        private ucPhieuTraSach ucPhieuTraSach1;
        private ucPhieuPhat ucPhieuPhat1;
        private ucThongKeMuonSach ucThongKeMuonSach1;
        private ucTraCuuSach ucTraCuuSach1;
        private ucThongKeTraSachTre ucThongKeTraSachTre1;
        private System.Windows.Forms.Button btChinhSua;
    }
}