namespace Bitebox.Views.Admin
{
    partial class FormKelolaCustomer
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
            dgvKelolaCustomer = new DataGridView();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaCustomer).BeginInit();
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
            pnlSidebar.Location = new Point(1, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(278, 1024);
            pnlSidebar.TabIndex = 7;
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
            // dgvKelolaCustomer
            // 
            dgvKelolaCustomer.BackgroundColor = Color.FromArgb(255, 240, 222);
            dgvKelolaCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKelolaCustomer.Location = new Point(383, 90);
            dgvKelolaCustomer.Name = "dgvKelolaCustomer";
            dgvKelolaCustomer.RowHeadersWidth = 62;
            dgvKelolaCustomer.Size = new Size(1415, 844);
            dgvKelolaCustomer.TabIndex = 8;
            // 
            // FormKelolaCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            ClientSize = new Size(1898, 1024);
            Controls.Add(dgvKelolaCustomer);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKelolaCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKelolaCustomer";
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnPengelolaPesanan;
        private PictureBox pcbLogo;
        private Button btnLogout;
        private Button btnKelolaCustomer;
        private Button btnLaporanPenjualan;
        private Button btnPengelolaMenu;
        private Button btnBeranda;
        private DataGridView dgvKelolaCustomer;
    }
}