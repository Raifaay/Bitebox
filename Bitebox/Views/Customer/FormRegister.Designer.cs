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
            lbldaftar = new Label();
            pnlnamalengkap = new Panel();
            txtnamalengkap = new TextBox();
            lblnamalengkap = new Label();
            pnlemail = new Panel();
            txtemail = new TextBox();
            lblemail = new Label();
            pnlusername = new Panel();
            txtusername = new TextBox();
            lblusername = new Label();
            pnlpassword = new Panel();
            txtpassword = new TextBox();
            lblpassword = new Label();
            btndaftar = new Button();
            lblsudahpunyaakun = new Label();
            btnlogindisini = new Button();
            pnlnamalengkap.SuspendLayout();
            pnlemail.SuspendLayout();
            pnlusername.SuspendLayout();
            pnlpassword.SuspendLayout();
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
            // lbldaftar
            // 
            lbldaftar.AutoSize = true;
            lbldaftar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldaftar.Location = new Point(746, 126);
            lbldaftar.Name = "lbldaftar";
            lbldaftar.Size = new Size(444, 30);
            lbldaftar.TabIndex = 1;
            lbldaftar.Text = "Daftar untuk memulai menggunakan Bitebox";
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
            // txtnamalengkap
            // 
            txtnamalengkap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnamalengkap.Location = new Point(34, 38);
            txtnamalengkap.Name = "txtnamalengkap";
            txtnamalengkap.Size = new Size(784, 37);
            txtnamalengkap.TabIndex = 2;
            txtnamalengkap.TextChanged += txtnamalengkap_TextChanged;
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
            // pnlpassword
            // 
            pnlpassword.BackColor = Color.FromArgb(255, 224, 188);
            pnlpassword.Controls.Add(txtpassword);
            pnlpassword.Controls.Add(lblpassword);
            pnlpassword.Location = new Point(548, 533);
            pnlpassword.Name = "pnlpassword";
            pnlpassword.Size = new Size(853, 86);
            pnlpassword.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(34, 38);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(784, 37);
            txtpassword.TabIndex = 2;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(34, 10);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(92, 25);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password";
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
            btndaftar.Click += btndaftar_Click;
            // 
            // lblsudahpunyaakun
            // 
            lblsudahpunyaakun.AutoSize = true;
            lblsudahpunyaakun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsudahpunyaakun.Location = new Point(810, 732);
            lblsudahpunyaakun.Name = "lblsudahpunyaakun";
            lblsudahpunyaakun.Size = new Size(178, 25);
            lblsudahpunyaakun.TabIndex = 6;
            lblsudahpunyaakun.Text = "Sudah punya akun?";
            // 
            // btnlogindisini
            // 
            btnlogindisini.BackColor = Color.Transparent;
            btnlogindisini.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogindisini.ForeColor = Color.FromArgb(255, 165, 81);
            btnlogindisini.Location = new Point(994, 727);
            btnlogindisini.Name = "btnlogindisini";
            btnlogindisini.Size = new Size(128, 34);
            btnlogindisini.TabIndex = 7;
            btnlogindisini.Text = "Login di sini";
            btnlogindisini.UseVisualStyleBackColor = false;
            btnlogindisini.Click += btnlogindisini_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnlogindisini);
            Controls.Add(lblsudahpunyaakun);
            Controls.Add(btndaftar);
            Controls.Add(pnlpassword);
            Controls.Add(pnlusername);
            Controls.Add(pnlemail);
            Controls.Add(pnlnamalengkap);
            Controls.Add(lbldaftar);
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
            pnlpassword.ResumeLayout(false);
            pnlpassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBuatAkunBaru;
        private Label lbldaftar;
        private Panel pnlnamalengkap;
        private Label lblnamalengkap;
        private TextBox txtnamalengkap;
        private Panel pnlemail;
        private TextBox txtemail;
        private Label lblemail;
        private Panel pnlusername;
        private TextBox txtusername;
        private Label lblusername;
        private Panel pnlpassword;
        private TextBox txtpassword;
        private Label lblpassword;
        private Button btndaftar;
        private Label lblsudahpunyaakun;
        private Button btnlogindisini;
    }
}