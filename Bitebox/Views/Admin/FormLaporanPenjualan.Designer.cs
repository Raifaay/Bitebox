namespace Bitebox.Views.Admin
{
    partial class FormLaporanPenjualan
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
            pnlTotalPenjualan = new Panel();
            lblAngkaTotalPenjualan = new Label();
            lbTotalPenjualan = new Label();
            panel2 = new Panel();
            lblAngkaTotalTransaksi = new Label();
            lbTotalTransaksi = new Label();
            panel3 = new Panel();
            lblRataratatransaksi = new Label();
            lblRatarata = new Label();
            panel4 = new Panel();
            cmbFilterKatgori = new ComboBox();
            lbFilterKategori = new Label();
            pnlSidebar = new Panel();
            btnPengelolaPesanan = new Button();
            pcbLogo = new PictureBox();
            btnLogout = new Button();
            btnKelolaCustomer = new Button();
            btnLaporanPenjualan = new Button();
            btnPengelolaMenu = new Button();
            btnBeranda = new Button();
            btnHariInibtnHariIni = new Button();
            btnBulanIni = new Button();
            btnTahunIni = new Button();
            dgvPenjualanPermenu = new DataGridView();
            lblPenjualanPerMenu = new Label();
            lblPenjualanPerkategori = new Label();
            dgvPenjualanPerkategori = new DataGridView();
            pnlTotalPenjualan.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualanPermenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualanPerkategori).BeginInit();
            SuspendLayout();
            // 
            // pnlTotalPenjualan
            // 
            pnlTotalPenjualan.BackColor = Color.FromArgb(255, 240, 222);
            pnlTotalPenjualan.Controls.Add(lblAngkaTotalPenjualan);
            pnlTotalPenjualan.Controls.Add(lbTotalPenjualan);
            pnlTotalPenjualan.Location = new Point(380, 36);
            pnlTotalPenjualan.Name = "pnlTotalPenjualan";
            pnlTotalPenjualan.Size = new Size(300, 116);
            pnlTotalPenjualan.TabIndex = 1;
            // 
            // lblAngkaTotalPenjualan
            // 
            lblAngkaTotalPenjualan.AutoSize = true;
            lblAngkaTotalPenjualan.ForeColor = Color.FromArgb(128, 66, 50);
            lblAngkaTotalPenjualan.Location = new Point(126, 61);
            lblAngkaTotalPenjualan.Name = "lblAngkaTotalPenjualan";
            lblAngkaTotalPenjualan.Size = new Size(48, 25);
            lblAngkaTotalPenjualan.TabIndex = 1;
            lblAngkaTotalPenjualan.Text = "Rp.0";
            // 
            // lbTotalPenjualan
            // 
            lbTotalPenjualan.AutoSize = true;
            lbTotalPenjualan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPenjualan.ForeColor = Color.FromArgb(128, 66, 50);
            lbTotalPenjualan.Location = new Point(87, 17);
            lbTotalPenjualan.Name = "lbTotalPenjualan";
            lbTotalPenjualan.Size = new Size(138, 25);
            lbTotalPenjualan.TabIndex = 0;
            lbTotalPenjualan.Text = "Total Penjualan";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 240, 222);
            panel2.Controls.Add(lblAngkaTotalTransaksi);
            panel2.Controls.Add(lbTotalTransaksi);
            panel2.Location = new Point(784, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 116);
            panel2.TabIndex = 2;
            // 
            // lblAngkaTotalTransaksi
            // 
            lblAngkaTotalTransaksi.AutoSize = true;
            lblAngkaTotalTransaksi.ForeColor = Color.FromArgb(128, 66, 50);
            lblAngkaTotalTransaksi.Location = new Point(149, 61);
            lblAngkaTotalTransaksi.Name = "lblAngkaTotalTransaksi";
            lblAngkaTotalTransaksi.Size = new Size(22, 25);
            lblAngkaTotalTransaksi.TabIndex = 1;
            lblAngkaTotalTransaksi.Text = "0";
            // 
            // lbTotalTransaksi
            // 
            lbTotalTransaksi.AutoSize = true;
            lbTotalTransaksi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalTransaksi.ForeColor = Color.FromArgb(128, 66, 50);
            lbTotalTransaksi.Location = new Point(97, 17);
            lbTotalTransaksi.Name = "lbTotalTransaksi";
            lbTotalTransaksi.Size = new Size(132, 25);
            lbTotalTransaksi.TabIndex = 0;
            lbTotalTransaksi.Text = "Total Transaksi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 240, 222);
            panel3.Controls.Add(lblRataratatransaksi);
            panel3.Controls.Add(lblRatarata);
            panel3.Location = new Point(1187, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 116);
            panel3.TabIndex = 3;
            // 
            // lblRataratatransaksi
            // 
            lblRataratatransaksi.AutoSize = true;
            lblRataratatransaksi.ForeColor = Color.FromArgb(128, 66, 50);
            lblRataratatransaksi.Location = new Point(139, 61);
            lblRataratatransaksi.Name = "lblRataratatransaksi";
            lblRataratatransaksi.Size = new Size(48, 25);
            lblRataratatransaksi.TabIndex = 1;
            lblRataratatransaksi.Text = "Rp.0";
            // 
            // lblRatarata
            // 
            lblRatarata.AutoSize = true;
            lblRatarata.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRatarata.ForeColor = Color.FromArgb(128, 66, 50);
            lblRatarata.Location = new Point(79, 17);
            lblRatarata.Name = "lblRatarata";
            lblRatarata.Size = new Size(167, 25);
            lblRatarata.TabIndex = 0;
            lblRatarata.Text = "Rata-rata Transaksi";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 249, 243);
            panel4.Controls.Add(btnTahunIni);
            panel4.Controls.Add(btnBulanIni);
            panel4.Controls.Add(cmbFilterKatgori);
            panel4.Controls.Add(btnHariInibtnHariIni);
            panel4.Controls.Add(lbFilterKategori);
            panel4.Location = new Point(380, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(1413, 152);
            panel4.TabIndex = 4;
            // 
            // cmbFilterKatgori
            // 
            cmbFilterKatgori.FormattingEnabled = true;
            cmbFilterKatgori.Items.AddRange(new object[] { "Semua Kategori", "Burger", "Pizza", "Minuman" });
            cmbFilterKatgori.Location = new Point(161, 86);
            cmbFilterKatgori.Name = "cmbFilterKatgori";
            cmbFilterKatgori.Size = new Size(1218, 33);
            cmbFilterKatgori.TabIndex = 4;
            cmbFilterKatgori.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbFilterKategori
            // 
            lbFilterKategori.AutoSize = true;
            lbFilterKategori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFilterKategori.ForeColor = Color.FromArgb(128, 66, 50);
            lbFilterKategori.Location = new Point(24, 86);
            lbFilterKategori.Name = "lbFilterKategori";
            lbFilterKategori.Size = new Size(131, 25);
            lbFilterKategori.TabIndex = 3;
            lbFilterKategori.Text = "Filter Kategori";
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
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(278, 1024);
            pnlSidebar.TabIndex = 6;
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
            // btnHariInibtnHariIni
            // 
            btnHariInibtnHariIni.BackColor = Color.FromArgb(255, 165, 81);
            btnHariInibtnHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHariInibtnHariIni.ForeColor = Color.White;
            btnHariInibtnHariIni.Location = new Point(24, 17);
            btnHariInibtnHariIni.Name = "btnHariInibtnHariIni";
            btnHariInibtnHariIni.Size = new Size(150, 46);
            btnHariInibtnHariIni.TabIndex = 0;
            btnHariInibtnHariIni.Text = "Hari Ini";
            btnHariInibtnHariIni.UseVisualStyleBackColor = false;
            // 
            // btnBulanIni
            // 
            btnBulanIni.BackColor = Color.FromArgb(255, 165, 81);
            btnBulanIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBulanIni.ForeColor = Color.White;
            btnBulanIni.Location = new Point(215, 17);
            btnBulanIni.Name = "btnBulanIni";
            btnBulanIni.Size = new Size(150, 46);
            btnBulanIni.TabIndex = 4;
            btnBulanIni.Text = "Bulan Ini";
            btnBulanIni.UseVisualStyleBackColor = false;
            // 
            // btnTahunIni
            // 
            btnTahunIni.BackColor = Color.FromArgb(255, 165, 81);
            btnTahunIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTahunIni.ForeColor = Color.White;
            btnTahunIni.Location = new Point(404, 17);
            btnTahunIni.Name = "btnTahunIni";
            btnTahunIni.Size = new Size(150, 46);
            btnTahunIni.TabIndex = 5;
            btnTahunIni.Text = "Tahun Ini";
            btnTahunIni.UseVisualStyleBackColor = false;
            // 
            // dgvPenjualanPermenu
            // 
            dgvPenjualanPermenu.BackgroundColor = Color.FromArgb(255, 240, 222);
            dgvPenjualanPermenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualanPermenu.Location = new Point(380, 428);
            dgvPenjualanPermenu.Name = "dgvPenjualanPermenu";
            dgvPenjualanPermenu.RowHeadersWidth = 62;
            dgvPenjualanPermenu.Size = new Size(1413, 236);
            dgvPenjualanPermenu.TabIndex = 7;
            // 
            // lblPenjualanPerMenu
            // 
            lblPenjualanPerMenu.AutoSize = true;
            lblPenjualanPerMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPenjualanPerMenu.ForeColor = Color.FromArgb(128, 66, 50);
            lblPenjualanPerMenu.Location = new Point(380, 370);
            lblPenjualanPerMenu.Name = "lblPenjualanPerMenu";
            lblPenjualanPerMenu.Size = new Size(244, 32);
            lblPenjualanPerMenu.TabIndex = 6;
            lblPenjualanPerMenu.Text = "Penjualan per Menu";
            // 
            // lblPenjualanPerkategori
            // 
            lblPenjualanPerkategori.AutoSize = true;
            lblPenjualanPerkategori.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPenjualanPerkategori.ForeColor = Color.FromArgb(128, 66, 50);
            lblPenjualanPerkategori.Location = new Point(380, 695);
            lblPenjualanPerkategori.Name = "lblPenjualanPerkategori";
            lblPenjualanPerkategori.Size = new Size(276, 32);
            lblPenjualanPerkategori.TabIndex = 8;
            lblPenjualanPerkategori.Text = "Penjualan per Kategori";
            // 
            // dgvPenjualanPerkategori
            // 
            dgvPenjualanPerkategori.BackgroundColor = Color.FromArgb(255, 240, 222);
            dgvPenjualanPerkategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualanPerkategori.Location = new Point(380, 743);
            dgvPenjualanPerkategori.Name = "dgvPenjualanPerkategori";
            dgvPenjualanPerkategori.RowHeadersWidth = 62;
            dgvPenjualanPerkategori.Size = new Size(1413, 236);
            dgvPenjualanPerkategori.TabIndex = 9;
            // 
            // FormLaporanPenjualan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            ClientSize = new Size(1898, 1024);
            Controls.Add(dgvPenjualanPerkategori);
            Controls.Add(lblPenjualanPerkategori);
            Controls.Add(lblPenjualanPerMenu);
            Controls.Add(dgvPenjualanPermenu);
            Controls.Add(pnlSidebar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlTotalPenjualan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLaporanPenjualan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLaporanPenjualan";
            pnlTotalPenjualan.ResumeLayout(false);
            pnlTotalPenjualan.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualanPermenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualanPerkategori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlTotalPenjualan;
        private Label lblAngkaTotalPenjualan;
        private Label lbTotalPenjualan;
        private Panel panel2;
        private Label lbTotalTransaksi;
        private Label lblAngkaTotalTransaksi;
        private Panel panel3;
        private Label lblRataratatransaksi;
        private Label lblRatarata;
        private Panel panel4;
        private ComboBox cmbFilterKatgori;
        private Label lbFilterKategori;
        private Panel pnlSidebar;
        private Button btnPengelolaPesanan;
        private PictureBox pcbLogo;
        private Button btnLogout;
        private Button btnKelolaCustomer;
        private Button btnLaporanPenjualan;
        private Button btnPengelolaMenu;
        private Button btnBeranda;
        private Button btnHariInibtnHariIni;
        private Button btnTahunIni;
        private Button btnBulanIni;
        private DataGridView dgvPenjualanPermenu;
        private Label lblPenjualanPerMenu;
        private Label lblPenjualanPerkategori;
        private DataGridView dgvPenjualanPerkategori;
    }
}