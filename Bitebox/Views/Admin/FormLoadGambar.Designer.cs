namespace Bitebox.Views.Admin
{
    partial class FormLoadGambar
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
            cmbMenu = new ComboBox();
            pcbPreview = new PictureBox();
            btnpilihgambar = new Button();
            btnsimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbPreview).BeginInit();
            SuspendLayout();
            // 
            // cmbMenu
            // 
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new Point(112, 50);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new Size(210, 33);
            cmbMenu.TabIndex = 0;
            // 
            // pcbPreview
            // 
            pcbPreview.Location = new Point(112, 106);
            pcbPreview.Name = "pcbPreview";
            pcbPreview.Size = new Size(210, 147);
            pcbPreview.TabIndex = 1;
            pcbPreview.TabStop = false;
            // 
            // btnpilihgambar
            // 
            btnpilihgambar.Location = new Point(112, 268);
            btnpilihgambar.Name = "btnpilihgambar";
            btnpilihgambar.Size = new Size(210, 34);
            btnpilihgambar.TabIndex = 2;
            btnpilihgambar.Text = "pilih gambar";
            btnpilihgambar.UseVisualStyleBackColor = true;
            btnpilihgambar.Click += btnpilihgambar_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(153, 308);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(112, 34);
            btnsimpan.TabIndex = 3;
            btnsimpan.Text = "simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            // 
            // FormLoadGambar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1876, 968);
            Controls.Add(btnsimpan);
            Controls.Add(btnpilihgambar);
            Controls.Add(pcbPreview);
            Controls.Add(cmbMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoadGambar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLoadGambar";
            Load += FormLoadGambar_Load;
            btnsimpan.Click += btnsimpan_Click;
            ((System.ComponentModel.ISupportInitialize)pcbPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMenu;
        private PictureBox pcbPreview;
        private Button btnpilihgambar;
        private Button btnsimpan;
    }
}