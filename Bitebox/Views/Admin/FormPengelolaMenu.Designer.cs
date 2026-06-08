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
            panel1 = new Panel();
            btnLogout = new Button();
            btnKelolaCustomer = new Button();
            btnLaporanPenjualan = new Button();
            btnPengelolaMenu = new Button();
            btnDashboard = new Button();
            lbPengelolaMenu = new Label();
            btnTambah = new Button();
            fLPMenu = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKelolaCustomer);
            panel1.Controls.Add(btnLaporanPenjualan);
            panel1.Controls.Add(btnPengelolaMenu);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(1, 4);
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
            btnLogout.Text = "Logout ";
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
            btnPengelolaMenu.Text = "Pengelola Menu";
            btnPengelolaMenu.UseVisualStyleBackColor = true;
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
            // lbPengelolaMenu
            // 
            lbPengelolaMenu.AutoSize = true;
            lbPengelolaMenu.Location = new Point(382, 100);
            lbPengelolaMenu.Name = "lbPengelolaMenu";
            lbPengelolaMenu.Size = new Size(143, 25);
            lbPengelolaMenu.TabIndex = 1;
            lbPengelolaMenu.Text = "Pengelola Menu ";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(1289, 100);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(165, 54);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "Tambah ";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // fLPMenu
            // 
            fLPMenu.Location = new Point(382, 203);
            fLPMenu.Name = "fLPMenu";
            fLPMenu.Size = new Size(293, 407);
            fLPMenu.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(777, 203);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 407);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(1154, 203);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(300, 407);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // FormPengelolaMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(fLPMenu);
            Controls.Add(btnTambah);
            Controls.Add(lbPengelolaMenu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPengelolaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPengelolaMenu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnDashboard;
        private Button btnPengelolaMenu;
        private Button btnLaporanPenjualan;
        private Button btnKelolaCustomer;
        private Button btnLogout;
        private Label lbPengelolaMenu;
        private Button btnTambah;
        private FlowLayoutPanel fLPMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}