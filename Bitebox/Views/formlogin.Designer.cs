namespace Bitebox.Views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnClose = new Button();
            BtnLogin = new Button();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(89, 224);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 422);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(TbPassword);
            panel1.Controls.Add(TbUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(53, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1837, 1042);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Gill Sans Ultra Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(128, 64, 64);
            btnClose.Location = new Point(1498, 130);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 60);
            btnClose.TabIndex = 7;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DarkOrange;
            BtnLogin.Font = new Font("Cooper Black", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(579, 756);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(655, 99);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(755, 527);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(392, 31);
            TbPassword.TabIndex = 5;
            // 
            // TbUsername
            // 
            TbUsername.Location = new Point(751, 384);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(396, 31);
            TbUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(739, 452);
            label3.Name = "label3";
            label3.Size = new Size(253, 50);
            label3.TabIndex = 3;
            label3.Text = "Password ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(739, 302);
            label2.Name = "label2";
            label2.Size = new Size(396, 50);
            label2.TabIndex = 2;
            label2.Text = "Email/Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(609, 224);
            label1.Name = "label1";
            label1.Size = new Size(0, 44);
            label1.TabIndex = 1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Button BtnLogin;
        private Button btnClose;
    }
}