namespace Bitebox.Views.Customer
{
    partial class FormCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckout));
            pnlsidebar = new Panel();
            btnkeluar = new Button();
            btnpengaturan = new Button();
            btnriwayat = new Button();
            btnkeranjang = new Button();
            btnberanda = new Button();
            pcblogo = new PictureBox();
            lblKonfirmasi = new Label();
            pnllayanan = new Panel();
            btnTakeAway = new Button();
            btneatin = new Button();
            lblPilihLayanan = new Label();
            panel1 = new Panel();
            cmbNomorMeja = new ComboBox();
            lblPilihMeja = new Label();
            FlowRingkasan = new FlowLayoutPanel();
            lblTotalPembayaran = new Label();
            lblTotal = new Label();
            btnKonfirmasiPesanan = new Button();
            pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
            pnllayanan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlsidebar
            // 
            pnlsidebar.BackgroundImage = (Image)resources.GetObject("pnlsidebar.BackgroundImage");
            pnlsidebar.BackgroundImageLayout = ImageLayout.Stretch;
            pnlsidebar.Controls.Add(btnkeluar);
            pnlsidebar.Controls.Add(btnpengaturan);
            pnlsidebar.Controls.Add(btnriwayat);
            pnlsidebar.Controls.Add(btnkeranjang);
            pnlsidebar.Controls.Add(btnberanda);
            pnlsidebar.Controls.Add(pcblogo);
            pnlsidebar.Location = new Point(0, 1);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(278, 1024);
            pnlsidebar.TabIndex = 2;
            pnlsidebar.Paint += pnlsidebar_Paint;
            // 
            // btnkeluar
            // 
            btnkeluar.BackColor = Color.Red;
            btnkeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkeluar.ForeColor = Color.White;
            btnkeluar.Location = new Point(24, 816);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(232, 53);
            btnkeluar.TabIndex = 5;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = false;
            // 
            // btnpengaturan
            // 
            btnpengaturan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpengaturan.ForeColor = Color.FromArgb(128, 66, 50);
            btnpengaturan.Location = new Point(24, 471);
            btnpengaturan.Name = "btnpengaturan";
            btnpengaturan.Size = new Size(232, 53);
            btnpengaturan.TabIndex = 4;
            btnpengaturan.Text = "Pengaturan";
            btnpengaturan.UseVisualStyleBackColor = true;
            // 
            // btnriwayat
            // 
            btnriwayat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnriwayat.ForeColor = Color.FromArgb(128, 66, 50);
            btnriwayat.Location = new Point(24, 393);
            btnriwayat.Name = "btnriwayat";
            btnriwayat.Size = new Size(232, 53);
            btnriwayat.TabIndex = 3;
            btnriwayat.Text = "Riwayat";
            btnriwayat.UseVisualStyleBackColor = true;
            btnriwayat.Click += btnriwayat_Click;
            // 
            // btnkeranjang
            // 
            btnkeranjang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkeranjang.ForeColor = Color.FromArgb(128, 66, 50);
            btnkeranjang.Location = new Point(24, 301);
            btnkeranjang.Name = "btnkeranjang";
            btnkeranjang.Size = new Size(232, 53);
            btnkeranjang.TabIndex = 2;
            btnkeranjang.Text = "Keranjang";
            btnkeranjang.UseVisualStyleBackColor = true;
            btnkeranjang.Click += btnkeranjang_Click_1;
            // 
            // btnberanda
            // 
            btnberanda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnberanda.ForeColor = Color.FromArgb(128, 66, 50);
            btnberanda.Location = new Point(24, 222);
            btnberanda.Name = "btnberanda";
            btnberanda.Size = new Size(232, 53);
            btnberanda.TabIndex = 1;
            btnberanda.Text = "Beranda";
            btnberanda.UseVisualStyleBackColor = true;
            // 
            // pcblogo
            // 
            pcblogo.BackColor = Color.Transparent;
            pcblogo.BackgroundImage = Properties.Resources.logo;
            pcblogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcblogo.Location = new Point(30, 0);
            pcblogo.Name = "pcblogo";
            pcblogo.Size = new Size(214, 195);
            pcblogo.TabIndex = 1;
            pcblogo.TabStop = false;
            // 
            // lblKonfirmasi
            // 
            lblKonfirmasi.AutoSize = true;
            lblKonfirmasi.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKonfirmasi.ForeColor = Color.FromArgb(128, 66, 50);
            lblKonfirmasi.Location = new Point(324, 36);
            lblKonfirmasi.Name = "lblKonfirmasi";
            lblKonfirmasi.Size = new Size(275, 38);
            lblKonfirmasi.TabIndex = 3;
            lblKonfirmasi.Text = "Konfirmasi Pesanan";
            // 
            // pnllayanan
            // 
            pnllayanan.BackColor = Color.FromArgb(255, 240, 222);
            pnllayanan.Controls.Add(btnTakeAway);
            pnllayanan.Controls.Add(btneatin);
            pnllayanan.Controls.Add(lblPilihLayanan);
            pnllayanan.Location = new Point(324, 97);
            pnllayanan.Name = "pnllayanan";
            pnllayanan.Size = new Size(1412, 297);
            pnllayanan.TabIndex = 4;
            // 
            // btnTakeAway
            // 
            btnTakeAway.BackColor = Color.FromArgb(255, 249, 243);
            btnTakeAway.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTakeAway.ForeColor = Color.FromArgb(128, 66, 50);
            btnTakeAway.Location = new Point(756, 61);
            btnTakeAway.Name = "btnTakeAway";
            btnTakeAway.Size = new Size(608, 206);
            btnTakeAway.TabIndex = 2;
            btnTakeAway.Text = "Take Away";
            btnTakeAway.UseVisualStyleBackColor = false;
            // 
            // btneatin
            // 
            btneatin.BackColor = Color.FromArgb(255, 249, 243);
            btneatin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneatin.ForeColor = Color.FromArgb(128, 66, 50);
            btneatin.Location = new Point(57, 61);
            btneatin.Name = "btneatin";
            btneatin.Size = new Size(608, 206);
            btneatin.TabIndex = 1;
            btneatin.Text = "Eat In";
            btneatin.UseVisualStyleBackColor = false;
            // 
            // lblPilihLayanan
            // 
            lblPilihLayanan.AutoSize = true;
            lblPilihLayanan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPilihLayanan.ForeColor = Color.FromArgb(128, 66, 50);
            lblPilihLayanan.Location = new Point(648, 14);
            lblPilihLayanan.Name = "lblPilihLayanan";
            lblPilihLayanan.Size = new Size(263, 38);
            lblPilihLayanan.TabIndex = 0;
            lblPilihLayanan.Text = "Pilih Jenis Layanan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 240, 222);
            panel1.Controls.Add(cmbNomorMeja);
            panel1.Controls.Add(lblPilihMeja);
            panel1.Location = new Point(324, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(1412, 121);
            panel1.TabIndex = 5;
            // 
            // cmbNomorMeja
            // 
            cmbNomorMeja.BackColor = Color.FromArgb(255, 249, 243);
            cmbNomorMeja.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbNomorMeja.ForeColor = Color.FromArgb(128, 66, 50);
            cmbNomorMeja.FormattingEnabled = true;
            cmbNomorMeja.Location = new Point(57, 53);
            cmbNomorMeja.Name = "cmbNomorMeja";
            cmbNomorMeja.Size = new Size(1307, 46);
            cmbNomorMeja.TabIndex = 7;
            // 
            // lblPilihMeja
            // 
            lblPilihMeja.AutoSize = true;
            lblPilihMeja.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPilihMeja.ForeColor = Color.FromArgb(128, 66, 50);
            lblPilihMeja.Location = new Point(3, 3);
            lblPilihMeja.Name = "lblPilihMeja";
            lblPilihMeja.Size = new Size(249, 38);
            lblPilihMeja.TabIndex = 6;
            lblPilihMeja.Text = "Pilih Nomor Meja";
            // 
            // FlowRingkasan
            // 
            FlowRingkasan.Location = new Point(324, 564);
            FlowRingkasan.Name = "FlowRingkasan";
            FlowRingkasan.Size = new Size(1412, 198);
            FlowRingkasan.TabIndex = 6;
            // 
            // lblTotalPembayaran
            // 
            lblTotalPembayaran.AutoSize = true;
            lblTotalPembayaran.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPembayaran.ForeColor = Color.FromArgb(128, 66, 50);
            lblTotalPembayaran.Location = new Point(327, 781);
            lblTotalPembayaran.Name = "lblTotalPembayaran";
            lblTotalPembayaran.Size = new Size(251, 38);
            lblTotalPembayaran.TabIndex = 7;
            lblTotalPembayaran.Text = "Total Pembayaran";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(128, 66, 50);
            lblTotal.Location = new Point(1586, 781);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 38);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Rp 0";
            // 
            // btnKonfirmasiPesanan
            // 
            btnKonfirmasiPesanan.BackColor = Color.FromArgb(255, 165, 81);
            btnKonfirmasiPesanan.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasiPesanan.ForeColor = SystemColors.ButtonHighlight;
            btnKonfirmasiPesanan.Location = new Point(327, 837);
            btnKonfirmasiPesanan.Name = "btnKonfirmasiPesanan";
            btnKonfirmasiPesanan.Size = new Size(1409, 82);
            btnKonfirmasiPesanan.TabIndex = 9;
            btnKonfirmasiPesanan.Text = "KONFIRMASI PESANAN";
            btnKonfirmasiPesanan.UseVisualStyleBackColor = false;
            btnKonfirmasiPesanan.Click += btnKonfirmasiPesanan_Click;
            // 
            // FormCheckout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1876, 968);
            Controls.Add(btnKonfirmasiPesanan);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalPembayaran);
            Controls.Add(FlowRingkasan);
            Controls.Add(panel1);
            Controls.Add(pnllayanan);
            Controls.Add(lblKonfirmasi);
            Controls.Add(pnlsidebar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCheckout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCheckout";
            Load += FormCheckout_Load;
            pnlsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
            pnllayanan.ResumeLayout(false);
            pnllayanan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlsidebar;
        private Button btnkeluar;
        private Button btnpengaturan;
        private Button btnriwayat;
        private Button btnkeranjang;
        private Button btnberanda;
        private PictureBox pcblogo;
        private Label lblKonfirmasi;
        private Panel pnllayanan;
        private Button btnTakeAway;
        private Button btneatin;
        private Label lblPilihLayanan;
        private Panel panel1;
        private ComboBox cmbNomorMeja;
        private Label lblPilihMeja;
        private FlowLayoutPanel FlowRingkasan;
        private Label lblTotalPembayaran;
        private Label lblTotal;
        private Button btnKonfirmasiPesanan;
    }
}