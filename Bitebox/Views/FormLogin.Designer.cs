namespace Bitebox.Views
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pcblogo = new PictureBox();
            lblemail = new Label();
            lblpassword = new Label();
            lblatau = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            btndaftarakun = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
            SuspendLayout();
            // 
            // pcblogo
            // 
            pcblogo.BackColor = Color.Transparent;
            pcblogo.BackgroundImage = Properties.Resources.bitebox2;
            pcblogo.BackgroundImageLayout = ImageLayout.Stretch;
            pcblogo.Location = new Point(811, 12);
            pcblogo.Name = "pcblogo";
            pcblogo.Size = new Size(308, 287);
            pcblogo.TabIndex = 0;
            pcblogo.TabStop = false;
            pcblogo.Click += pcblogo_Click;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblemail.ForeColor = Color.FromArgb(128, 66, 50);
            lblemail.Location = new Point(567, 320);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(187, 32);
            lblemail.TabIndex = 1;
            lblemail.Text = "Email/Username";
            lblemail.Click += lblemail_Click;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpassword.ForeColor = Color.FromArgb(128, 66, 50);
            lblpassword.Location = new Point(567, 427);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(111, 32);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password";
            // 
            // lblatau
            // 
            lblatau.AutoSize = true;
            lblatau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblatau.ForeColor = Color.FromArgb(128, 66, 50);
            lblatau.Location = new Point(567, 634);
            lblatau.Name = "lblatau";
            lblatau.Size = new Size(794, 32);
            lblatau.TabIndex = 3;
            lblatau.Text = "────────────────────────────── atau ──────────────────────────────";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(567, 365);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(806, 50);
            txtemail.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(567, 462);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(806, 50);
            txtpassword.TabIndex = 5;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(255, 165, 81);
            btnlogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnlogin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(567, 545);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(806, 72);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btndaftarakun
            // 
            btndaftarakun.BackColor = Color.FromArgb(255, 249, 243);
            btndaftarakun.BackgroundImageLayout = ImageLayout.Stretch;
            btndaftarakun.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndaftarakun.ForeColor = Color.FromArgb(255, 165, 81);
            btndaftarakun.Location = new Point(567, 685);
            btndaftarakun.Name = "btndaftarakun";
            btndaftarakun.Size = new Size(806, 66);
            btndaftarakun.TabIndex = 7;
            btndaftarakun.Text = "Daftar Akun Baru";
            btndaftarakun.UseVisualStyleBackColor = false;
            btndaftarakun.Click += btndaftarakun_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 249, 243);
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Location = new Point(1792, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(54, 56);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImage = Properties.Resources.login_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnClose);
            Controls.Add(btndaftarakun);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(lblatau);
            Controls.Add(lblpassword);
            Controls.Add(lblemail);
            Controls.Add(pcblogo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcblogo;
        private Label lblemail;
        private Label lblpassword;
        private Label lblatau;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button btndaftarakun;
        private Button btnClose;
    }
}