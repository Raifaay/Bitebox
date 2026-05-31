namespace Bitebox.Views
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            lblBuatAkunBaru = new Label();
            label1 = new Label();
            pnlnamalengkap = new Panel();
            lblnamalengkap = new Label();
            txtnamalengkap = new TextBox();
            pnlemail = new Panel();
            txtemail = new TextBox();
            lblemail = new Label();
            pnlusername = new Panel();
            txtusername = new TextBox();
            lblusername = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            btndaftar = new Button();
            label3 = new Label();
            button1 = new Button();
            pnlnamalengkap.SuspendLayout();
            pnlemail.SuspendLayout();
            pnlusername.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBuatAkunBaru
            // 
            lblBuatAkunBaru.AutoSize = true;
            lblBuatAkunBaru.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuatAkunBaru.Location = new Point(878, 85);
            lblBuatAkunBaru.Name = "lblBuatAkunBaru";
            lblBuatAkunBaru.Size = new Size(200, 32);
            lblBuatAkunBaru.TabIndex = 0;
            lblBuatAkunBaru.Text = "Buat Akun Baru";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(746, 126);
            label1.Name = "label1";
            label1.Size = new Size(444, 30);
            label1.TabIndex = 1;
            label1.Text = "Daftar untuk memulai menggunakan Bitebox";
            // 
            // pnlnamalengkap
            // 
            pnlnamalengkap.BackColor = Color.FromArgb(255, 224, 188);
            pnlnamalengkap.Controls.Add(txtnamalengkap);
            pnlnamalengkap.Controls.Add(lblnamalengkap);
            pnlnamalengkap.Location = new Point(548, 185);
            pnlnamalengkap.Name = "pnlnamalengkap";
            pnlnamalengkap.Size = new Size(853, 86);
            pnlnamalengkap.TabIndex = 2;
            pnlnamalengkap.Paint += panel1_Paint;
            // 
            // lblnamalengkap
            // 
            lblnamalengkap.AutoSize = true;
            lblnamalengkap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnamalengkap.Location = new Point(34, 10);
            lblnamalengkap.Name = "lblnamalengkap";
            lblnamalengkap.Size = new Size(139, 25);
            lblnamalengkap.TabIndex = 1;
            lblnamalengkap.Text = "Nama Lengkap";
            lblnamalengkap.Click += lblnamalengkap_Click;
            // 
            // txtnamalengkap
            // 
            txtnamalengkap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnamalengkap.Location = new Point(34, 38);
            txtnamalengkap.Name = "txtnamalengkap";
            txtnamalengkap.Size = new Size(784, 37);
            txtnamalengkap.TabIndex = 2;
            // 
            // pnlemail
            // 
            pnlemail.BackColor = Color.FromArgb(255, 224, 188);
            pnlemail.Controls.Add(txtemail);
            pnlemail.Controls.Add(lblemail);
            pnlemail.Location = new Point(548, 304);
            pnlemail.Name = "pnlemail";
            pnlemail.Size = new Size(853, 86);
            pnlemail.TabIndex = 3;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(34, 38);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(784, 37);
            txtemail.TabIndex = 2;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblemail.Location = new Point(34, 10);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(58, 25);
            lblemail.TabIndex = 1;
            lblemail.Text = "Email";
            // 
            // pnlusername
            // 
            pnlusername.BackColor = Color.FromArgb(255, 224, 188);
            pnlusername.Controls.Add(txtusername);
            pnlusername.Controls.Add(lblusername);
            pnlusername.Location = new Point(548, 420);
            pnlusername.Name = "pnlusername";
            pnlusername.Size = new Size(853, 86);
            pnlusername.TabIndex = 4;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(34, 38);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(784, 37);
            txtusername.TabIndex = 2;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(34, 10);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(97, 25);
            lblusername.TabIndex = 1;
            lblusername.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 188);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(548, 533);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 86);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(34, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(784, 37);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 10);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btndaftar
            // 
            btndaftar.BackColor = Color.FromArgb(255, 165, 81);
            btndaftar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndaftar.ForeColor = Color.White;
            btndaftar.Location = new Point(601, 641);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(739, 73);
            btndaftar.TabIndex = 5;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(810, 732);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 6;
            label3.Text = "Sudah punya akun?";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 165, 81);
            button1.Location = new Point(994, 727);
            button1.Name = "button1";
            button1.Size = new Size(128, 34);
            button1.TabIndex = 7;
            button1.Text = "Login di sini";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(btndaftar);
            Controls.Add(panel1);
            Controls.Add(pnlusername);
            Controls.Add(pnlemail);
            Controls.Add(pnlnamalengkap);
            Controls.Add(label1);
            Controls.Add(lblBuatAkunBaru);
            ForeColor = Color.FromArgb(128, 66, 50);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormRegister_Load;
            pnlnamalengkap.ResumeLayout(false);
            pnlnamalengkap.PerformLayout();
            pnlemail.ResumeLayout(false);
            pnlemail.PerformLayout();
            pnlusername.ResumeLayout(false);
            pnlusername.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuatAkunBaru;
        private Label label1;
        private Panel pnlnamalengkap;
        private Label lblnamalengkap;
        private TextBox txtnamalengkap;
        private Panel pnlemail;
        private TextBox txtemail;
        private Label lblemail;
        private Panel pnlusername;
        private TextBox txtusername;
        private Label lblusername;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Button btndaftar;
        private Label label3;
        private Button button1;
    }
}