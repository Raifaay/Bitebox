namespace Bitebox.Views.Customer
{
    partial class FormRiwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayat));
            pnlsidebar = new Panel();
            btnkeluar = new Button();
            btnpengaturan = new Button();
            btnriwayat = new Button();
            btnkeranjang = new Button();
            btnberanda = new Button();
            pcblogo = new PictureBox();
            label1 = new Label();
            dgvRiwayat = new DataGridView();
            pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
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
            pnlsidebar.TabIndex = 3;
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
            btnkeluar.Click += btnkeluar_Click;
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
            btnkeranjang.Click += btnkeranjang_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 66, 50);
            label1.Location = new Point(326, 64);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 4;
            label1.Text = "Riwayat Pesanan";
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.FromArgb(255, 240, 222);
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(326, 130);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersWidth = 62;
            dgvRiwayat.Size = new Size(1468, 699);
            dgvRiwayat.TabIndex = 5;
            dgvRiwayat.CellContentClick += dgvRiwayat_CellContentClick;
            // 
            // FormRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1898, 1024);
            Controls.Add(dgvRiwayat);
            Controls.Add(label1);
            Controls.Add(pnlsidebar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRiwayat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRiwayat";
            Load += FormRiwayat_Load;
            pnlsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
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
        private Label label1;
        private DataGridView dgvRiwayat;
    }
}