namespace Bitebox.Views.Admin
{
    partial class FormBeranda
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
            pnlSidebar = new Panel();
            btnPengelolaPesanan = new Button();
            pcbLogo = new PictureBox();
            btnLogout = new Button();
            btnKelolaCustomer = new Button();
            btnLaporanPenjualan = new Button();
            btnPengelolaMenu = new Button();
            btnBeranda = new Button();
            pnlTotalProduk = new Panel();
            lbItem = new Label();
            lblAngkaProduk = new Label();
            lbTotalProduk = new Label();
            pnlTotalPenjualan = new Panel();
            lbItemTerjual = new Label();
            lblAngkaItemTerjual = new Label();
            lbTotalPenjualan = new Label();
            pnlTotalPenghasilan = new Panel();
            lbDariPenjualan = new Label();
            lblAngkaDariPenjualan = new Label();
            lbTotalPenghasilan = new Label();
            pnlmeja = new Panel();
            lblMeja = new Label();
            lblJumlahMeja = new Label();
            lblMejaTersedia = new Label();
            lblBerandaAdmin = new Label();
            lblTanggal = new Label();
            label1 = new Label();
            dgvStatusMeja = new DataGridView();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlTotalProduk.SuspendLayout();
            pnlTotalPenjualan.SuspendLayout();
            pnlTotalPenghasilan.SuspendLayout();
            pnlmeja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatusMeja).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackgroundImage = Properties.Resources.sidebarrr;
            pnlSidebar.Controls.Add(btnPengelolaPesanan);
            pnlSidebar.Controls.Add(pcbLogo);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnKelolaCustomer);
            pnlSidebar.Controls.Add(btnLaporanPenjualan);
            pnlSidebar.Controls.Add(btnPengelolaMenu);
            pnlSidebar.Controls.Add(btnBeranda);
            pnlSidebar.Location = new Point(3, -13);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(278, 1024);
            pnlSidebar.TabIndex = 0;
            // 
            // btnPengelolaPesanan
            // 
            btnPengelolaPesanan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPengelolaPesanan.ForeColor = Color.FromArgb(128, 66, 50);
            btnPengelolaPesanan.Location = new Point(20, 392);
            btnPengelolaPesanan.Name = "btnPengelolaPesanan";
            btnPengelolaPesanan.Size = new Size(232, 53);
            btnPengelolaPesanan.TabIndex = 7;
            btnPengelolaPesanan.Text = "Pengelola Pesanan";
            btnPengelolaPesanan.UseVisualStyleBackColor = true;
            btnPengelolaPesanan.Click += btnPengelolaPesanan_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = Color.Transparent;
            pcbLogo.BackgroundImage = Properties.Resources.logo;
            pcbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcbLogo.Location = new Point(20, 12);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(214, 195);
            pcbLogo.TabIndex = 6;
            pcbLogo.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(20, 844);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(232, 53);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Keluar";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKelolaCustomer
            // 
            btnKelolaCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaCustomer.ForeColor = Color.FromArgb(128, 66, 50);
            btnKelolaCustomer.Location = new Point(20, 558);
            btnKelolaCustomer.Name = "btnKelolaCustomer";
            btnKelolaCustomer.Size = new Size(232, 53);
            btnKelolaCustomer.TabIndex = 3;
            btnKelolaCustomer.Text = "Kelola Customer";
            btnKelolaCustomer.UseVisualStyleBackColor = true;
            btnKelolaCustomer.Click += btnKelolaCustomer_Click;
            // 
            // btnLaporanPenjualan
            // 
            btnLaporanPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaporanPenjualan.ForeColor = Color.FromArgb(128, 66, 50);
            btnLaporanPenjualan.Location = new Point(20, 474);
            btnLaporanPenjualan.Name = "btnLaporanPenjualan";
            btnLaporanPenjualan.Size = new Size(232, 53);
            btnLaporanPenjualan.TabIndex = 2;
            btnLaporanPenjualan.Text = "Laporan Penjualan";
            btnLaporanPenjualan.UseVisualStyleBackColor = true;
            btnLaporanPenjualan.Click += btnLaporanPenjualan_Click;
            // 
            // btnPengelolaMenu
            // 
            btnPengelolaMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPengelolaMenu.ForeColor = Color.FromArgb(128, 66, 50);
            btnPengelolaMenu.Location = new Point(20, 308);
            btnPengelolaMenu.Name = "btnPengelolaMenu";
            btnPengelolaMenu.Size = new Size(232, 53);
            btnPengelolaMenu.TabIndex = 1;
            btnPengelolaMenu.Text = "Pengelola Menu ";
            btnPengelolaMenu.UseVisualStyleBackColor = true;
            btnPengelolaMenu.Click += btnPengelolaMenu_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeranda.ForeColor = Color.FromArgb(128, 66, 50);
            btnBeranda.Location = new Point(20, 229);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(232, 53);
            btnBeranda.TabIndex = 0;
            btnBeranda.Text = "Beranda";
            btnBeranda.UseVisualStyleBackColor = true;
            // 
            // pnlTotalProduk
            // 
            pnlTotalProduk.BackColor = Color.FromArgb(255, 240, 222);
            pnlTotalProduk.Controls.Add(lbItem);
            pnlTotalProduk.Controls.Add(lblAngkaProduk);
            pnlTotalProduk.Controls.Add(lbTotalProduk);
            pnlTotalProduk.Location = new Point(746, 119);
            pnlTotalProduk.Name = "pnlTotalProduk";
            pnlTotalProduk.Size = new Size(302, 150);
            pnlTotalProduk.TabIndex = 1;
            // 
            // lbItem
            // 
            lbItem.AutoSize = true;
            lbItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbItem.ForeColor = Color.FromArgb(128, 66, 50);
            lbItem.Location = new Point(105, 109);
            lbItem.Name = "lbItem";
            lbItem.Size = new Size(105, 25);
            lbItem.TabIndex = 2;
            lbItem.Text = "Item Menu";
            // 
            // lblAngkaProduk
            // 
            lblAngkaProduk.AutoSize = true;
            lblAngkaProduk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAngkaProduk.ForeColor = Color.FromArgb(128, 66, 50);
            lblAngkaProduk.Location = new Point(134, 63);
            lblAngkaProduk.Name = "lblAngkaProduk";
            lblAngkaProduk.Size = new Size(22, 25);
            lblAngkaProduk.TabIndex = 1;
            lblAngkaProduk.Text = "2";
            // 
            // lbTotalProduk
            // 
            lbTotalProduk.AutoSize = true;
            lbTotalProduk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalProduk.ForeColor = Color.FromArgb(128, 66, 50);
            lbTotalProduk.Location = new Point(90, 16);
            lbTotalProduk.Name = "lbTotalProduk";
            lbTotalProduk.Size = new Size(120, 25);
            lbTotalProduk.TabIndex = 0;
            lbTotalProduk.Text = "Total Produk";
            // 
            // pnlTotalPenjualan
            // 
            pnlTotalPenjualan.BackColor = Color.FromArgb(255, 240, 222);
            pnlTotalPenjualan.Controls.Add(lbItemTerjual);
            pnlTotalPenjualan.Controls.Add(lblAngkaItemTerjual);
            pnlTotalPenjualan.Controls.Add(lbTotalPenjualan);
            pnlTotalPenjualan.Location = new Point(1134, 119);
            pnlTotalPenjualan.Name = "pnlTotalPenjualan";
            pnlTotalPenjualan.Size = new Size(300, 150);
            pnlTotalPenjualan.TabIndex = 2;
            // 
            // lbItemTerjual
            // 
            lbItemTerjual.AutoSize = true;
            lbItemTerjual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbItemTerjual.ForeColor = Color.FromArgb(128, 66, 50);
            lbItemTerjual.Location = new Point(101, 109);
            lbItemTerjual.Name = "lbItemTerjual";
            lbItemTerjual.Size = new Size(113, 25);
            lbItemTerjual.TabIndex = 2;
            lbItemTerjual.Text = "Item Terjual";
            // 
            // lblAngkaItemTerjual
            // 
            lblAngkaItemTerjual.AutoSize = true;
            lblAngkaItemTerjual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAngkaItemTerjual.ForeColor = Color.FromArgb(128, 66, 50);
            lblAngkaItemTerjual.Location = new Point(140, 63);
            lblAngkaItemTerjual.Name = "lblAngkaItemTerjual";
            lblAngkaItemTerjual.Size = new Size(22, 25);
            lblAngkaItemTerjual.TabIndex = 1;
            lblAngkaItemTerjual.Text = "0";
            // 
            // lbTotalPenjualan
            // 
            lbTotalPenjualan.AutoSize = true;
            lbTotalPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPenjualan.ForeColor = Color.FromArgb(128, 66, 50);
            lbTotalPenjualan.Location = new Point(86, 16);
            lbTotalPenjualan.Name = "lbTotalPenjualan";
            lbTotalPenjualan.Size = new Size(142, 25);
            lbTotalPenjualan.TabIndex = 0;
            lbTotalPenjualan.Text = "Total Penjualan";
            // 
            // pnlTotalPenghasilan
            // 
            pnlTotalPenghasilan.BackColor = Color.FromArgb(255, 240, 222);
            pnlTotalPenghasilan.Controls.Add(lbDariPenjualan);
            pnlTotalPenghasilan.Controls.Add(lblAngkaDariPenjualan);
            pnlTotalPenghasilan.Controls.Add(lbTotalPenghasilan);
            pnlTotalPenghasilan.Location = new Point(1531, 119);
            pnlTotalPenghasilan.Name = "pnlTotalPenghasilan";
            pnlTotalPenghasilan.Size = new Size(300, 150);
            pnlTotalPenghasilan.TabIndex = 3;
            // 
            // lbDariPenjualan
            // 
            lbDariPenjualan.AutoSize = true;
            lbDariPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDariPenjualan.ForeColor = Color.FromArgb(128, 66, 50);
            lbDariPenjualan.Location = new Point(91, 109);
            lbDariPenjualan.Name = "lbDariPenjualan";
            lbDariPenjualan.Size = new Size(140, 25);
            lbDariPenjualan.TabIndex = 2;
            lbDariPenjualan.Text = "Dari Penjualan ";
            // 
            // lblAngkaDariPenjualan
            // 
            lblAngkaDariPenjualan.AutoSize = true;
            lblAngkaDariPenjualan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAngkaDariPenjualan.ForeColor = Color.FromArgb(128, 66, 50);
            lblAngkaDariPenjualan.Location = new Point(131, 63);
            lblAngkaDariPenjualan.Name = "lblAngkaDariPenjualan";
            lblAngkaDariPenjualan.Size = new Size(48, 25);
            lblAngkaDariPenjualan.TabIndex = 1;
            lblAngkaDariPenjualan.Text = "Rp.0";
            // 
            // lbTotalPenghasilan
            // 
            lbTotalPenghasilan.AutoSize = true;
            lbTotalPenghasilan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPenghasilan.ForeColor = Color.FromArgb(128, 66, 50);
            lbTotalPenghasilan.Location = new Point(74, 16);
            lbTotalPenghasilan.Name = "lbTotalPenghasilan";
            lbTotalPenghasilan.Size = new Size(161, 25);
            lbTotalPenghasilan.TabIndex = 0;
            lbTotalPenghasilan.Text = "Total Penghasilan";
            // 
            // pnlmeja
            // 
            pnlmeja.BackColor = Color.FromArgb(255, 240, 222);
            pnlmeja.Controls.Add(lblMeja);
            pnlmeja.Controls.Add(lblJumlahMeja);
            pnlmeja.Controls.Add(lblMejaTersedia);
            pnlmeja.Location = new Point(340, 119);
            pnlmeja.Name = "pnlmeja";
            pnlmeja.Size = new Size(302, 150);
            pnlmeja.TabIndex = 3;
            // 
            // lblMeja
            // 
            lblMeja.AutoSize = true;
            lblMeja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeja.ForeColor = Color.FromArgb(128, 66, 50);
            lblMeja.Location = new Point(126, 109);
            lblMeja.Name = "lblMeja";
            lblMeja.Size = new Size(54, 25);
            lblMeja.TabIndex = 2;
            lblMeja.Text = "Meja";
            // 
            // lblJumlahMeja
            // 
            lblJumlahMeja.AutoSize = true;
            lblJumlahMeja.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahMeja.ForeColor = Color.FromArgb(128, 66, 50);
            lblJumlahMeja.Location = new Point(126, 63);
            lblJumlahMeja.Name = "lblJumlahMeja";
            lblJumlahMeja.Size = new Size(46, 25);
            lblJumlahMeja.TabIndex = 1;
            lblJumlahMeja.Text = "3/15";
            // 
            // lblMejaTersedia
            // 
            lblMejaTersedia.AutoSize = true;
            lblMejaTersedia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMejaTersedia.ForeColor = Color.FromArgb(128, 66, 50);
            lblMejaTersedia.Location = new Point(90, 16);
            lblMejaTersedia.Name = "lblMejaTersedia";
            lblMejaTersedia.Size = new Size(129, 25);
            lblMejaTersedia.TabIndex = 0;
            lblMejaTersedia.Text = "Meja Tersedia";
            // 
            // lblBerandaAdmin
            // 
            lblBerandaAdmin.AutoSize = true;
            lblBerandaAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBerandaAdmin.ForeColor = Color.FromArgb(128, 66, 50);
            lblBerandaAdmin.Location = new Point(340, 59);
            lblBerandaAdmin.Name = "lblBerandaAdmin";
            lblBerandaAdmin.Size = new Size(191, 32);
            lblBerandaAdmin.TabIndex = 3;
            lblBerandaAdmin.Text = "Beranda Admin";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = Color.FromArgb(128, 66, 50);
            lblTanggal.Location = new Point(1676, 59);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(155, 32);
            lblTanggal.TabIndex = 4;
            lblTanggal.Text = "10 Mei 2026";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 66, 50);
            label1.Location = new Point(340, 316);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 6;
            label1.Text = "Status Meja";
            // 
            // dgvStatusMeja
            // 
            dgvStatusMeja.BackgroundColor = Color.FromArgb(255, 240, 222);
            dgvStatusMeja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatusMeja.Location = new Point(340, 376);
            dgvStatusMeja.Name = "dgvStatusMeja";
            dgvStatusMeja.RowHeadersWidth = 62;
            dgvStatusMeja.Size = new Size(1491, 542);
            dgvStatusMeja.TabIndex = 7;
            // 
            // FormBeranda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            ClientSize = new Size(1898, 1024);
            Controls.Add(dgvStatusMeja);
            Controls.Add(label1);
            Controls.Add(lblTanggal);
            Controls.Add(lblBerandaAdmin);
            Controls.Add(pnlmeja);
            Controls.Add(pnlTotalPenghasilan);
            Controls.Add(pnlTotalPenjualan);
            Controls.Add(pnlTotalProduk);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBeranda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            Load += FormBeranda_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlTotalProduk.ResumeLayout(false);
            pnlTotalProduk.PerformLayout();
            pnlTotalPenjualan.ResumeLayout(false);
            pnlTotalPenjualan.PerformLayout();
            pnlTotalPenghasilan.ResumeLayout(false);
            pnlTotalPenghasilan.PerformLayout();
            pnlmeja.ResumeLayout(false);
            pnlmeja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatusMeja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnBeranda;
        private Button btnLogout;
        private Button btnKelolaCustomer;
        private Button btnLaporanPenjualan;
        private Button btnPengelolaMenu;
        private Panel pnlTotalProduk;
        private Label lbTotalProduk;
        private Label lbItem;
        private Label lblAngkaProduk;
        private Panel pnlTotalPenjualan;
        private Label lbTotalPenjualan;
        private Label lblAngkaItemTerjual;
        private Label lbItemTerjual;
        private Panel pnlTotalPenghasilan;
        private Label lbDariPenjualan;
        private Label lblAngkaDariPenjualan;
        private Label lbTotalPenghasilan;
        private PictureBox pcbLogo;
        private Panel pnlmeja;
        private Label lblMeja;
        private Label lblJumlahMeja;
        private Label lblMejaTersedia;
        private Label lblBerandaAdmin;
        private Label lblTanggal;
        private Label label1;
        private DataGridView dgvStatusMeja;
        private Button btnPengelolaPesanan;
    }
}