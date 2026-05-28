namespace Bitebox
{
    partial class Formregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formregister));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btndaftar = new Button();
            btndaftarakun = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(400, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(499, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(400, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(499, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(400, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(499, 31);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(400, 365);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(499, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(400, 442);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(499, 31);
            textBox5.TabIndex = 4;
            // 
            // btndaftar
            // 
            btndaftar.BackgroundImage = (Image)resources.GetObject("btndaftar.BackgroundImage");
            btndaftar.BackgroundImageLayout = ImageLayout.Stretch;
            btndaftar.Location = new Point(400, 504);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(436, 56);
            btndaftar.TabIndex = 5;
            btndaftar.UseVisualStyleBackColor = true;
            // 
            // btndaftarakun
            // 
            btndaftarakun.BackColor = Color.FromArgb(255, 249, 243);
            btndaftarakun.BackgroundImage = (Image)resources.GetObject("btndaftarakun.BackgroundImage");
            btndaftarakun.BackgroundImageLayout = ImageLayout.Stretch;
            btndaftarakun.Location = new Point(659, 566);
            btndaftarakun.Name = "btndaftarakun";
            btndaftarakun.Size = new Size(130, 48);
            btndaftarakun.TabIndex = 6;
            btndaftarakun.UseVisualStyleBackColor = false;
            btndaftarakun.Click += btndaftarakun_Click;
            // 
            // Formregister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 243);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            Controls.Add(btndaftarakun);
            Controls.Add(btndaftar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formregister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formregister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btndaftar;
        private Button btndaftarakun;
    }
}