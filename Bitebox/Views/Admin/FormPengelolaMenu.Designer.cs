namespace Bitebox.Views.Admin
{
    partial class FormPengelolaMenu
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
            lbPengelolaMenu = new Label();
            btnTambah = new Button();
            dgvPengelolaMenu = new DataGridView();
            pnlTambahMenu = new Panel();
            lblTambahMenu = new Label();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            lblNamaMenu = new Label();
            txtNamaMenu = new TextBox();
            lblKategori = new Label();
            cmbKategori = new ComboBox();
            lblHargaMenu = new Label();
            txtHargaMenu = new TextBox();
            lblDeskripsiMenu = new Label();
            textBox1 = new TextBox();
            lblGambarMenu = new Label();
            btnUploadGambar = new Button();
            btnBatal = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPengelolaMenu).BeginInit();
            pnlTambahMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbPengelolaMenu
            // 
            lbPengelolaMenu.AutoSize = true;
            lbPengelolaMenu.Location = new Point(344, 106);
            lbPengelolaMenu.Margin = new Padding(4, 0, 4, 0);
            lbPengelolaMenu.Name = "lbPengelolaMenu";
            lbPengelolaMenu.Size = new Size(206, 32);
            lbPengelolaMenu.TabIndex = 1;
            lbPengelolaMenu.Text = "Pengelola Menu ";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(255, 165, 81);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(1237, 91);
            btnTambah.Margin = new Padding(4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(189, 47);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "Tambah ";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // dgvPengelolaMenu
            // 
            dgvPengelolaMenu.BackgroundColor = Color.FromArgb(255, 240, 222);
            dgvPengelolaMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengelolaMenu.Location = new Point(344, 155);
            dgvPengelolaMenu.Name = "dgvPengelolaMenu";
            dgvPengelolaMenu.RowHeadersWidth = 62;
            dgvPengelolaMenu.Size = new Size(1082, 831);
            dgvPengelolaMenu.TabIndex = 10;
            dgvPengelolaMenu.CellContentClick += dgvPengelolaMenu_CellContentClick;
            // 
            // pnlTambahMenu
            // 
            pnlTambahMenu.BackColor = Color.FromArgb(255, 240, 222);
            pnlTambahMenu.Controls.Add(button8);
            pnlTambahMenu.Controls.Add(btnBatal);
            pnlTambahMenu.Controls.Add(btnUploadGambar);
            pnlTambahMenu.Controls.Add(lblGambarMenu);
            pnlTambahMenu.Controls.Add(textBox1);
            pnlTambahMenu.Controls.Add(lblDeskripsiMenu);
            pnlTambahMenu.Controls.Add(txtHargaMenu);
            pnlTambahMenu.Controls.Add(lblHargaMenu);
            pnlTambahMenu.Controls.Add(cmbKategori);
            pnlTambahMenu.Controls.Add(lblKategori);
            pnlTambahMenu.Controls.Add(txtNamaMenu);
            pnlTambahMenu.Controls.Add(lblNamaMenu);
            pnlTambahMenu.Controls.Add(lblTambahMenu);
            pnlTambahMenu.Location = new Point(1465, 155);
            pnlTambahMenu.Name = "pnlTambahMenu";
            pnlTambahMenu.Size = new Size(398, 831);
            pnlTambahMenu.TabIndex = 12;
            // 
            // lblTambahMenu
            // 
            lblTambahMenu.AutoSize = true;
            lblTambahMenu.Location = new Point(107, 17);
            lblTambahMenu.Margin = new Padding(4, 0, 4, 0);
            lblTambahMenu.Name = "lblTambahMenu";
            lblTambahMenu.Size = new Size(176, 32);
            lblTambahMenu.TabIndex = 13;
            lblTambahMenu.Text = "Tambah Menu";
            lblTambahMenu.Click += lblTambahMenu_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.sidebarrr;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(3, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 1024);
            panel1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(128, 66, 50);
            button1.Location = new Point(20, 392);
            button1.Name = "button1";
            button1.Size = new Size(232, 53);
            button1.TabIndex = 7;
            button1.Text = "Pengelola Pesanan";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 195);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(20, 844);
            button2.Name = "button2";
            button2.Size = new Size(232, 53);
            button2.TabIndex = 4;
            button2.Text = "Keluar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(128, 66, 50);
            button3.Location = new Point(20, 558);
            button3.Name = "button3";
            button3.Size = new Size(232, 53);
            button3.TabIndex = 3;
            button3.Text = "Kelola Customer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(128, 66, 50);
            button4.Location = new Point(20, 474);
            button4.Name = "button4";
            button4.Size = new Size(232, 53);
            button4.TabIndex = 2;
            button4.Text = "Laporan Penjualan";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(128, 66, 50);
            button5.Location = new Point(20, 308);
            button5.Name = "button5";
            button5.Size = new Size(232, 53);
            button5.TabIndex = 1;
            button5.Text = "Pengelola Menu ";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(128, 66, 50);
            button6.Location = new Point(20, 229);
            button6.Name = "button6";
            button6.Size = new Size(232, 53);
            button6.TabIndex = 0;
            button6.Text = "Beranda";
            button6.UseVisualStyleBackColor = true;
            // 
            // lblNamaMenu
            // 
            lblNamaMenu.AutoSize = true;
            lblNamaMenu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaMenu.Location = new Point(16, 84);
            lblNamaMenu.Margin = new Padding(4, 0, 4, 0);
            lblNamaMenu.Name = "lblNamaMenu";
            lblNamaMenu.Size = new Size(132, 30);
            lblNamaMenu.TabIndex = 14;
            lblNamaMenu.Text = "Nama Menu";
            // 
            // txtNamaMenu
            // 
            txtNamaMenu.Location = new Point(16, 114);
            txtNamaMenu.Name = "txtNamaMenu";
            txtNamaMenu.Size = new Size(369, 39);
            txtNamaMenu.TabIndex = 15;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(16, 156);
            lblKategori.Margin = new Padding(4, 0, 4, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(95, 30);
            lblKategori.TabIndex = 16;
            lblKategori.Text = "Kategori";
            lblKategori.Click += lblKategori_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(16, 189);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(369, 40);
            cmbKategori.TabIndex = 17;
            // 
            // lblHargaMenu
            // 
            lblHargaMenu.AutoSize = true;
            lblHargaMenu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHargaMenu.Location = new Point(16, 232);
            lblHargaMenu.Margin = new Padding(4, 0, 4, 0);
            lblHargaMenu.Name = "lblHargaMenu";
            lblHargaMenu.Size = new Size(72, 30);
            lblHargaMenu.TabIndex = 18;
            lblHargaMenu.Text = "Harga";
            // 
            // txtHargaMenu
            // 
            txtHargaMenu.Location = new Point(16, 265);
            txtHargaMenu.Name = "txtHargaMenu";
            txtHargaMenu.Size = new Size(369, 39);
            txtHargaMenu.TabIndex = 19;
            // 
            // lblDeskripsiMenu
            // 
            lblDeskripsiMenu.AutoSize = true;
            lblDeskripsiMenu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeskripsiMenu.Location = new Point(16, 307);
            lblDeskripsiMenu.Margin = new Padding(4, 0, 4, 0);
            lblDeskripsiMenu.Name = "lblDeskripsiMenu";
            lblDeskripsiMenu.Size = new Size(162, 30);
            lblDeskripsiMenu.TabIndex = 20;
            lblDeskripsiMenu.Text = "Deskripsi Menu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 39);
            textBox1.TabIndex = 21;
            // 
            // lblGambarMenu
            // 
            lblGambarMenu.AutoSize = true;
            lblGambarMenu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGambarMenu.Location = new Point(16, 382);
            lblGambarMenu.Margin = new Padding(4, 0, 4, 0);
            lblGambarMenu.Name = "lblGambarMenu";
            lblGambarMenu.Size = new Size(152, 30);
            lblGambarMenu.TabIndex = 22;
            lblGambarMenu.Text = "Gambar Menu";
            // 
            // btnUploadGambar
            // 
            btnUploadGambar.Location = new Point(16, 415);
            btnUploadGambar.Name = "btnUploadGambar";
            btnUploadGambar.Size = new Size(369, 153);
            btnUploadGambar.TabIndex = 23;
            btnUploadGambar.Text = "Upload Gambar";
            btnUploadGambar.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(16, 722);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(162, 49);
            btnBatal.TabIndex = 24;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 165, 81);
            button8.ForeColor = Color.White;
            button8.Location = new Point(231, 722);
            button8.Name = "button8";
            button8.Size = new Size(154, 49);
            button8.TabIndex = 25;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = false;
            // 
            // FormPengelolaMenu
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(pnlTambahMenu);
            Controls.Add(dgvPengelolaMenu);
            Controls.Add(btnTambah);
            Controls.Add(lbPengelolaMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(128, 66, 50);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormPengelolaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPengelolaMenu";
            Load += FormPengelolaMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPengelolaMenu).EndInit();
            pnlTambahMenu.ResumeLayout(false);
            pnlTambahMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbPengelolaMenu;
        private Button btnTambah;
        private DataGridView dgvPengelolaMenu;
        private Panel pnlTambahMenu;
        private Label lblTambahMenu;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox txtNamaMenu;
        private Label lblNamaMenu;
        private ComboBox cmbKategori;
        private Label lblKategori;
        private TextBox txtHargaMenu;
        private Label lblHargaMenu;
        private TextBox textBox1;
        private Label lblDeskripsiMenu;
        private Button btnUploadGambar;
        private Label lblGambarMenu;
        private Button button8;
        private Button btnBatal;
    }
}