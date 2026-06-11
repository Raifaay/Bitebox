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
            panel1 = new Panel();
            btnLogout = new Button();
            btnKelolaCustomer = new Button();
            btnLaporanPenjualan = new Button();
            btnPengelolaMenu = new Button();
            btnDashboard = new Button();
            pnlTotalPenjualan = new Panel();
            lbHarga = new Label();
            lbTotalPenjualan = new Label();
            panel2 = new Panel();
            lbHarga1 = new Label();
            lbTotalTransaksi = new Label();
            panel3 = new Panel();
            lbHarga2 = new Label();
            lbRataRata1 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            ColNamaMenu = new DataGridViewTextBoxColumn();
            ColKategori = new DataGridViewTextBoxColumn();
            ColJumlahTerjual = new DataGridViewTextBoxColumn();
            ColTotalPendapat = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            lbFilterKategori = new Label();
            panel1.SuspendLayout();
            pnlTotalPenjualan.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKelolaCustomer);
            panel1.Controls.Add(btnLaporanPenjualan);
            panel1.Controls.Add(btnPengelolaMenu);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 1017);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(38, 537);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(197, 54);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKelolaCustomer
            // 
            btnKelolaCustomer.Location = new Point(38, 430);
            btnKelolaCustomer.Name = "btnKelolaCustomer";
            btnKelolaCustomer.Size = new Size(197, 61);
            btnKelolaCustomer.TabIndex = 3;
            btnKelolaCustomer.Text = "Kelola Customer";
            btnKelolaCustomer.UseVisualStyleBackColor = true;
            btnKelolaCustomer.Click += btnKelolaCustomer_Click;
            // 
            // btnLaporanPenjualan
            // 
            btnLaporanPenjualan.Location = new Point(38, 333);
            btnLaporanPenjualan.Name = "btnLaporanPenjualan";
            btnLaporanPenjualan.Size = new Size(197, 58);
            btnLaporanPenjualan.TabIndex = 2;
            btnLaporanPenjualan.Text = "Laporan Penjualan";
            btnLaporanPenjualan.UseVisualStyleBackColor = true;
            // 
            // btnPengelolaMenu
            // 
            btnPengelolaMenu.Location = new Point(38, 240);
            btnPengelolaMenu.Name = "btnPengelolaMenu";
            btnPengelolaMenu.Size = new Size(197, 59);
            btnPengelolaMenu.TabIndex = 1;
            btnPengelolaMenu.Text = "Pengelola Menu ";
            btnPengelolaMenu.UseVisualStyleBackColor = true;
            btnPengelolaMenu.Click += btnPengelolaMenu_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(38, 149);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(197, 57);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlTotalPenjualan
            // 
            pnlTotalPenjualan.Controls.Add(lbHarga);
            pnlTotalPenjualan.Controls.Add(lbTotalPenjualan);
            pnlTotalPenjualan.Location = new Point(380, 91);
            pnlTotalPenjualan.Name = "pnlTotalPenjualan";
            pnlTotalPenjualan.Size = new Size(300, 150);
            pnlTotalPenjualan.TabIndex = 1;
            // 
            // lbHarga
            // 
            lbHarga.AutoSize = true;
            lbHarga.Location = new Point(127, 74);
            lbHarga.Name = "lbHarga";
            lbHarga.Size = new Size(48, 25);
            lbHarga.TabIndex = 1;
            lbHarga.Text = "Rp.0";
            // 
            // lbTotalPenjualan
            // 
            lbTotalPenjualan.AutoSize = true;
            lbTotalPenjualan.Location = new Point(86, 30);
            lbTotalPenjualan.Name = "lbTotalPenjualan";
            lbTotalPenjualan.Size = new Size(128, 25);
            lbTotalPenjualan.TabIndex = 0;
            lbTotalPenjualan.Text = "Total Penjualan";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbHarga1);
            panel2.Controls.Add(lbTotalTransaksi);
            panel2.Location = new Point(784, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 2;
            // 
            // lbHarga1
            // 
            lbHarga1.AutoSize = true;
            lbHarga1.Location = new Point(148, 74);
            lbHarga1.Name = "lbHarga1";
            lbHarga1.Size = new Size(22, 25);
            lbHarga1.TabIndex = 1;
            lbHarga1.Text = "0";
            // 
            // lbTotalTransaksi
            // 
            lbTotalTransaksi.AutoSize = true;
            lbTotalTransaksi.Location = new Point(100, 30);
            lbTotalTransaksi.Name = "lbTotalTransaksi";
            lbTotalTransaksi.Size = new Size(124, 25);
            lbTotalTransaksi.TabIndex = 0;
            lbTotalTransaksi.Text = "Total Transaksi";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbHarga2);
            panel3.Controls.Add(lbRataRata1);
            panel3.Location = new Point(1161, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 3;
            // 
            // lbHarga2
            // 
            lbHarga2.AutoSize = true;
            lbHarga2.Location = new Point(131, 74);
            lbHarga2.Name = "lbHarga2";
            lbHarga2.Size = new Size(48, 25);
            lbHarga2.TabIndex = 1;
            lbHarga2.Text = "Rp.0";
            // 
            // lbRataRata1
            // 
            lbRataRata1.AutoSize = true;
            lbRataRata1.Location = new Point(79, 30);
            lbRataRata1.Name = "lbRataRata1";
            lbRataRata1.Size = new Size(159, 25);
            lbRataRata1.TabIndex = 0;
            lbRataRata1.Text = "Rata-rata Transaksi";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(lbFilterKategori);
            panel4.Location = new Point(391, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(1459, 654);
            panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNamaMenu, ColKategori, ColJumlahTerjual, ColTotalPendapat });
            dataGridView1.Location = new Point(49, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(921, 225);
            dataGridView1.TabIndex = 5;
            // 
            // ColNamaMenu
            // 
            ColNamaMenu.HeaderText = "Nama Menu";
            ColNamaMenu.MinimumWidth = 8;
            ColNamaMenu.Name = "ColNamaMenu";
            ColNamaMenu.Width = 150;
            // 
            // ColKategori
            // 
            ColKategori.HeaderText = "Kategori";
            ColKategori.MinimumWidth = 8;
            ColKategori.Name = "ColKategori";
            ColKategori.Width = 150;
            // 
            // ColJumlahTerjual
            // 
            ColJumlahTerjual.HeaderText = "Jumlah Terjual";
            ColJumlahTerjual.MinimumWidth = 8;
            ColJumlahTerjual.Name = "ColJumlahTerjual";
            ColJumlahTerjual.Width = 150;
            // 
            // ColTotalPendapat
            // 
            ColTotalPendapat.HeaderText = "Total Pendapat";
            ColTotalPendapat.MinimumWidth = 8;
            ColTotalPendapat.Name = "ColTotalPendapat";
            ColTotalPendapat.Width = 150;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Semua Kategori", "Burger", "Pizza", "Minuman" });
            comboBox1.Location = new Point(202, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(768, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbFilterKategori
            // 
            lbFilterKategori.AutoSize = true;
            lbFilterKategori.Location = new Point(61, 54);
            lbFilterKategori.Name = "lbFilterKategori";
            lbFilterKategori.Size = new Size(121, 25);
            lbFilterKategori.TabIndex = 3;
            lbFilterKategori.Text = "Filter Kategori";
            // 
            // FormLaporanPenjualan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlTotalPenjualan);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLaporanPenjualan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLaporanPenjualan";
            panel1.ResumeLayout(false);
            pnlTotalPenjualan.ResumeLayout(false);
            pnlTotalPenjualan.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDashboard;
        private Button btnPengelolaMenu;
        private Button btnLaporanPenjualan;
        private Button btnLogout;
        private Button btnKelolaCustomer;
        private Panel pnlTotalPenjualan;
        private Label lbHarga;
        private Label lbTotalPenjualan;
        private Panel panel2;
        private Label lbTotalTransaksi;
        private Label lbHarga1;
        private Panel panel3;
        private Label lbHarga2;
        private Label lbRataRata1;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label lbFilterKategori;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColNamaMenu;
        private DataGridViewTextBoxColumn ColKategori;
        private DataGridViewTextBoxColumn ColJumlahTerjual;
        private DataGridViewTextBoxColumn ColTotalPendapat;
    }
}