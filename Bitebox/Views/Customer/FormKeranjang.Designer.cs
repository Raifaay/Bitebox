namespace Bitebox.Views.Customer
{
    partial class FormKeranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeranjang));
            pnlsidebar = new Panel();
            btnkeluar = new Button();
            btnpengaturan = new Button();
            btnriwayat = new Button();
            btnkeranjang = new Button();
            btnberanda = new Button();
            pcblogo = new PictureBox();
            lblKeranjangPesanan = new Label();
            FlowKeranjang = new FlowLayoutPanel();
            lblharga = new Label();
            lbltotalpembayaran = new Label();
            button2 = new Button();
            pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
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
            pnlsidebar.Location = new Point(2, 3);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(278, 1024);
            pnlsidebar.TabIndex = 1;
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
            btnberanda.Click += btnberanda_Click;
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
            // lblKeranjangPesanan
            // 
            lblKeranjangPesanan.AutoSize = true;
            lblKeranjangPesanan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeranjangPesanan.ForeColor = Color.FromArgb(128, 66, 50);
            lblKeranjangPesanan.Location = new Point(317, 55);
            lblKeranjangPesanan.Name = "lblKeranjangPesanan";
            lblKeranjangPesanan.Size = new Size(265, 38);
            lblKeranjangPesanan.TabIndex = 2;
            lblKeranjangPesanan.Text = "Keranjang Pesanan";
            lblKeranjangPesanan.Click += lblKeranjangPesanan_Click;
            // 
            // FlowKeranjang
            // 
            FlowKeranjang.AutoScroll = true;
            FlowKeranjang.BackColor = Color.FromArgb(255, 240, 222);
            FlowKeranjang.FlowDirection = FlowDirection.TopDown;
            FlowKeranjang.Location = new Point(317, 119);
            FlowKeranjang.Name = "FlowKeranjang";
            FlowKeranjang.Size = new Size(1381, 613);
            FlowKeranjang.TabIndex = 3;
            FlowKeranjang.WrapContents = false;
            // 
            // lblharga
            // 
            lblharga.AutoSize = true;
            lblharga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblharga.ForeColor = Color.FromArgb(128, 66, 50);
            lblharga.Location = new Point(1311, 792);
            lblharga.Name = "lblharga";
            lblharga.Size = new Size(66, 32);
            lblharga.TabIndex = 5;
            lblharga.Text = "Rp 0";
            // 
            // lbltotalpembayaran
            // 
            lbltotalpembayaran.AutoSize = true;
            lbltotalpembayaran.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalpembayaran.ForeColor = Color.FromArgb(128, 66, 50);
            lbltotalpembayaran.Location = new Point(329, 786);
            lbltotalpembayaran.Name = "lbltotalpembayaran";
            lbltotalpembayaran.Size = new Size(251, 38);
            lbltotalpembayaran.TabIndex = 6;
            lbltotalpembayaran.Text = "Total Pembayaran";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 165, 81);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(317, 834);
            button2.Name = "button2";
            button2.Size = new Size(1381, 92);
            button2.TabIndex = 7;
            button2.Text = "Check Out";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormKeranjang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button2);
            Controls.Add(lbltotalpembayaran);
            Controls.Add(lblharga);
            Controls.Add(FlowKeranjang);
            Controls.Add(lblKeranjangPesanan);
            Controls.Add(pnlsidebar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKeranjang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKeranjang";
            Load += FormKeranjang_Load;
            pnlsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
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
        private Label lblKeranjangPesanan;
        private FlowLayoutPanel FlowKeranjang;
        private Label lblharga;
        private Label lbltotalpembayaran;
        private Button button2;
    }
}