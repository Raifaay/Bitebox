namespace Bitebox.Views
{
    partial class FormMenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuUtama));
            panel1 = new Panel();
            btnkeluar = new Button();
            btnpengaturan = new Button();
            btnriwayat = new Button();
            btnkeranjang = new Button();
            btnberanda = new Button();
            pcblogo = new PictureBox();
            lblHai = new Label();
            lblmaumakan = new Label();
            btnClose = new Button();
            txtcarimenufav = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblnikmatin = new Label();
            lbltanggal = new Label();
            label1 = new Label();
            btnburger = new Button();
            btnpizza = new Button();
            btnminuman = new Button();
            lbldaftarmenu = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnkeluar);
            panel1.Controls.Add(btnpengaturan);
            panel1.Controls.Add(btnriwayat);
            panel1.Controls.Add(btnkeranjang);
            panel1.Controls.Add(btnberanda);
            panel1.Controls.Add(pcblogo);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 1024);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            // 
            // pcblogo
            // 
            pcblogo.BackColor = Color.Transparent;
            pcblogo.BackgroundImage = (Image)resources.GetObject("pcblogo.BackgroundImage");
            pcblogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcblogo.Location = new Point(30, 0);
            pcblogo.Name = "pcblogo";
            pcblogo.Size = new Size(214, 195);
            pcblogo.TabIndex = 1;
            pcblogo.TabStop = false;
            // 
            // lblHai
            // 
            lblHai.AutoSize = true;
            lblHai.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHai.ForeColor = Color.FromArgb(128, 66, 50);
            lblHai.Location = new Point(326, 59);
            lblHai.Name = "lblHai";
            lblHai.Size = new Size(77, 38);
            lblHai.TabIndex = 1;
            lblHai.Text = "Hai, ";
            lblHai.Click += label1_Click;
            // 
            // lblmaumakan
            // 
            lblmaumakan.AutoSize = true;
            lblmaumakan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmaumakan.ForeColor = Color.FromArgb(128, 66, 50);
            lblmaumakan.Location = new Point(326, 97);
            lblmaumakan.Name = "lblmaumakan";
            lblmaumakan.Size = new Size(276, 32);
            lblmaumakan.TabIndex = 2;
            lblmaumakan.Text = "Mau makan apa hari ini?";
            lblmaumakan.Click += label2_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 249, 243);
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Location = new Point(1810, 41);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(76, 69);
            btnClose.TabIndex = 9;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtcarimenufav
            // 
            txtcarimenufav.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcarimenufav.ForeColor = Color.FromArgb(128, 66, 50);
            txtcarimenufav.Location = new Point(326, 151);
            txtcarimenufav.Name = "txtcarimenufav";
            txtcarimenufav.Size = new Size(1195, 45);
            txtcarimenufav.TabIndex = 10;
            txtcarimenufav.Tag = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 165, 81);
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblnikmatin);
            panel2.Location = new Point(326, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(1541, 207);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1026, 79);
            label2.Name = "label2";
            label2.Size = new Size(381, 45);
            label2.TabIndex = 15;
            label2.Text = "lebih cepat dan praktis!!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(607, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 279);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lblnikmatin
            // 
            lblnikmatin.AutoSize = true;
            lblnikmatin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnikmatin.ForeColor = Color.White;
            lblnikmatin.Location = new Point(176, 77);
            lblnikmatin.Name = "lblnikmatin";
            lblnikmatin.Size = new Size(441, 45);
            lblnikmatin.TabIndex = 14;
            lblnikmatin.Text = "Nikmati makanan favoritmu";
            // 
            // lbltanggal
            // 
            lbltanggal.AutoSize = true;
            lbltanggal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltanggal.ForeColor = Color.FromArgb(128, 66, 50);
            lbltanggal.Location = new Point(1625, 151);
            lbltanggal.Name = "lbltanggal";
            lbltanggal.Size = new Size(179, 38);
            lbltanggal.TabIndex = 13;
            lbltanggal.Text = "10 Mei 2026";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 66, 50);
            label1.Location = new Point(326, 457);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 14;
            label1.Text = "Kategori Menu";
            // 
            // btnburger
            // 
            btnburger.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnburger.ForeColor = Color.FromArgb(128, 66, 50);
            btnburger.Location = new Point(326, 510);
            btnburger.Name = "btnburger";
            btnburger.Size = new Size(179, 47);
            btnburger.TabIndex = 15;
            btnburger.Text = "Burger";
            btnburger.UseVisualStyleBackColor = true;
            // 
            // btnpizza
            // 
            btnpizza.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpizza.ForeColor = Color.FromArgb(128, 66, 50);
            btnpizza.Location = new Point(550, 510);
            btnpizza.Name = "btnpizza";
            btnpizza.Size = new Size(179, 47);
            btnpizza.TabIndex = 16;
            btnpizza.Text = "Pizza";
            btnpizza.UseVisualStyleBackColor = true;
            // 
            // btnminuman
            // 
            btnminuman.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnminuman.ForeColor = Color.FromArgb(128, 66, 50);
            btnminuman.Location = new Point(773, 510);
            btnminuman.Name = "btnminuman";
            btnminuman.Size = new Size(179, 47);
            btnminuman.TabIndex = 17;
            btnminuman.Text = "Minuman";
            btnminuman.UseVisualStyleBackColor = true;
            // 
            // lbldaftarmenu
            // 
            lbldaftarmenu.AutoSize = true;
            lbldaftarmenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldaftarmenu.ForeColor = Color.FromArgb(128, 66, 50);
            lbldaftarmenu.Location = new Point(326, 580);
            lbldaftarmenu.Name = "lbldaftarmenu";
            lbldaftarmenu.Size = new Size(186, 38);
            lbldaftarmenu.TabIndex = 18;
            lbldaftarmenu.Text = "Daftar Menu";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(326, 649);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(370, 206);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Location = new Point(741, 649);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(377, 206);
            flowLayoutPanel2.TabIndex = 20;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.Location = new Point(1172, 649);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(370, 206);
            flowLayoutPanel3.TabIndex = 20;
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            ClientSize = new Size(1898, 1024);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbldaftarmenu);
            Controls.Add(btnminuman);
            Controls.Add(btnpizza);
            Controls.Add(btnburger);
            Controls.Add(label1);
            Controls.Add(lbltanggal);
            Controls.Add(panel2);
            Controls.Add(txtcarimenufav);
            Controls.Add(btnClose);
            Controls.Add(lblmaumakan);
            Controls.Add(lblHai);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuUtama";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pcblogo;
        private Button btnberanda;
        private Button btnriwayat;
        private Button btnkeranjang;
        private Button btnkeluar;
        private Button btnpengaturan;
        private Label lblHai;
        private Label lblmaumakan;
        private Button btnClose;
        private TextBox txtcarimenufav;
        private Panel panel2;
        private Label lbltanggal;
        private Label label2;
        private Label lblnikmatin;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnburger;
        private Button btnpizza;
        private Button btnminuman;
        private Label lbldaftarmenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}