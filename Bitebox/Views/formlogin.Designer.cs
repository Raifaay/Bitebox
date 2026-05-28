namespace Bitebox
{
    partial class formlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formlogin));
            txtemail = new TextBox();
            btnlogin = new Button();
            btndaftarakun = new Button();
            txtpassword = new TextBox();
            SuspendLayout();
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(392, 200);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(488, 29);
            txtemail.TabIndex = 0;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackgroundImage = (Image)resources.GetObject("btnlogin.BackgroundImage");
            btnlogin.Location = new Point(597, 613);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(741, 53);
            btnlogin.TabIndex = 2;
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += button1_Click;
            // 
            // btndaftarakun
            // 
            btndaftarakun.BackColor = Color.FromArgb(255, 249, 243);
            btndaftarakun.BackgroundImage = (Image)resources.GetObject("btndaftarakun.BackgroundImage");
            btndaftarakun.Location = new Point(392, 417);
            btndaftarakun.Name = "btndaftarakun";
            btndaftarakun.Size = new Size(488, 52);
            btndaftarakun.TabIndex = 3;
            btndaftarakun.UseVisualStyleBackColor = false;
            btndaftarakun.Click += button2_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(392, 256);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(488, 31);
            txtpassword.TabIndex = 4;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // formlogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(txtpassword);
            Controls.Add(btndaftarakun);
            Controls.Add(btnlogin);
            Controls.Add(txtemail);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "formlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formlogin";
            Load += formlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtemail;
        private Button btnlogin;
        private Button btndaftarakun;
        private TextBox txtpassword;
    }
}
