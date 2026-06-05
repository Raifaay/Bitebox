namespace Bitebox.Views.Admin
{
    partial class FormDashboard
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
            panel2 = new Panel();
            lbItem = new Label();
            lbAngka = new Label();
            lbTotalProduk = new Label();
            panel3 = new Panel();
            lbItemTerjual = new Label();
            lbAngka1 = new Label();
            lbTotalPenjualan = new Label();
            panel4 = new Panel();
            lbDariPenjualan = new Label();
            lbAngka2 = new Label();
            lbTotalPenghasilan = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKelolaCustomer);
            panel1.Controls.Add(btnLaporanPenjualan);
            panel1.Controls.Add(btnPengelolaMenu);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(3, 4);
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
            btnLaporanPenjualan.Click += btnLaporanPenjualan_Click;
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
            // 
            // panel2
            // 
            panel2.Controls.Add(lbItem);
            panel2.Controls.Add(lbAngka);
            panel2.Controls.Add(lbTotalProduk);
            panel2.Location = new Point(381, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 150);
            panel2.TabIndex = 1;
            // 
            // lbItem
            // 
            lbItem.AutoSize = true;
            lbItem.Location = new Point(121, 91);
            lbItem.Name = "lbItem";
            lbItem.Size = new Size(48, 25);
            lbItem.TabIndex = 2;
            lbItem.Text = "Item";
            // 
            // lbAngka
            // 
            lbAngka.AutoSize = true;
            lbAngka.Location = new Point(133, 52);
            lbAngka.Name = "lbAngka";
            lbAngka.Size = new Size(22, 25);
            lbAngka.TabIndex = 1;
            lbAngka.Text = "2";
            // 
            // lbTotalProduk
            // 
            lbTotalProduk.AutoSize = true;
            lbTotalProduk.Location = new Point(99, 16);
            lbTotalProduk.Name = "lbTotalProduk";
            lbTotalProduk.Size = new Size(111, 25);
            lbTotalProduk.TabIndex = 0;
            lbTotalProduk.Text = "Total Produk";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbItemTerjual);
            panel3.Controls.Add(lbAngka1);
            panel3.Controls.Add(lbTotalPenjualan);
            panel3.Location = new Point(765, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 2;
            // 
            // lbItemTerjual
            // 
            lbItemTerjual.AutoSize = true;
            lbItemTerjual.Location = new Point(97, 91);
            lbItemTerjual.Name = "lbItemTerjual";
            lbItemTerjual.Size = new Size(102, 25);
            lbItemTerjual.TabIndex = 2;
            lbItemTerjual.Text = "Item Terjual";
            // 
            // lbAngka1
            // 
            lbAngka1.AutoSize = true;
            lbAngka1.Location = new Point(132, 52);
            lbAngka1.Name = "lbAngka1";
            lbAngka1.Size = new Size(22, 25);
            lbAngka1.TabIndex = 1;
            lbAngka1.Text = "0";
            lbAngka1.Click += lbAngka1_Click;
            // 
            // lbTotalPenjualan
            // 
            lbTotalPenjualan.AutoSize = true;
            lbTotalPenjualan.Location = new Point(88, 16);
            lbTotalPenjualan.Name = "lbTotalPenjualan";
            lbTotalPenjualan.Size = new Size(128, 25);
            lbTotalPenjualan.TabIndex = 0;
            lbTotalPenjualan.Text = "Total Penjualan";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbDariPenjualan);
            panel4.Controls.Add(lbAngka2);
            panel4.Controls.Add(lbTotalPenghasilan);
            panel4.Location = new Point(1137, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 3;
            // 
            // lbDariPenjualan
            // 
            lbDariPenjualan.AutoSize = true;
            lbDariPenjualan.Location = new Point(105, 91);
            lbDariPenjualan.Name = "lbDariPenjualan";
            lbDariPenjualan.Size = new Size(128, 25);
            lbDariPenjualan.TabIndex = 2;
            lbDariPenjualan.Text = "Dari Penjualan ";
            // 
            // lbAngka2
            // 
            lbAngka2.AutoSize = true;
            lbAngka2.Location = new Point(134, 52);
            lbAngka2.Name = "lbAngka2";
            lbAngka2.Size = new Size(48, 25);
            lbAngka2.TabIndex = 1;
            lbAngka2.Text = "Rp.0";
            // 
            // lbTotalPenghasilan
            // 
            lbTotalPenghasilan.AutoSize = true;
            lbTotalPenghasilan.Location = new Point(86, 16);
            lbTotalPenghasilan.Name = "lbTotalPenghasilan";
            lbTotalPenghasilan.Size = new Size(147, 25);
            lbTotalPenghasilan.TabIndex = 0;
            lbTotalPenghasilan.Text = "Total Penghasilan";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnKelolaCustomer;
        private Button btnLaporanPenjualan;
        private Button btnPengelolaMenu;
        private Panel panel2;
        private Label lbTotalProduk;
        private Label lbItem;
        private Label lbAngka;
        private Panel panel3;
        private Label lbTotalPenjualan;
        private Label lbAngka1;
        private Label lbItemTerjual;
        private Panel panel4;
        private Label lbDariPenjualan;
        private Label lbAngka2;
        private Label lbTotalPenghasilan;
    }
}