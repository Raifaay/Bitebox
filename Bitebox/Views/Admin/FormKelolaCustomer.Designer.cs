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
            panel1 = new Panel();
            btnLogout = new Button();
            btnKelolaCustomer = new Button();
            btnLaporanPenjualan = new Button();
            btnPengelolaMenu = new Button();
            btnDashboard = new Button();
            dGVKelolaCustomer = new DataGridView();
            btnAksi = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVKelolaCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKelolaCustomer);
            panel1.Controls.Add(btnLaporanPenjualan);
            panel1.Controls.Add(btnPengelolaMenu);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 1017);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            btnPengelolaMenu.Text = "Pengelola Menu";
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
            // dGVKelolaCustomer
            // 
            dGVKelolaCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVKelolaCustomer.Columns.AddRange(new DataGridViewColumn[] { btnAksi });
            dGVKelolaCustomer.Location = new Point(361, 151);
            dGVKelolaCustomer.Name = "dGVKelolaCustomer";
            dGVKelolaCustomer.RowHeadersWidth = 62;
            dGVKelolaCustomer.Size = new Size(1054, 514);
            dGVKelolaCustomer.TabIndex = 1;
            // 
            // btnAksi
            // 
            btnAksi.HeaderText = "Column1";
            btnAksi.MinimumWidth = 8;
            btnAksi.Name = "btnAksi";
            btnAksi.Width = 150;
            // 
            // FormKelolaCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(dGVKelolaCustomer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKelolaCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKelolaCustomer";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVKelolaCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnKelolaCustomer;
        private Button btnLaporanPenjualan;
        private Button btnPengelolaMenu;
        private Button btnDashboard;
        private DataGridView dGVKelolaCustomer;
        private DataGridViewButtonColumn btnAksi;
    }
}