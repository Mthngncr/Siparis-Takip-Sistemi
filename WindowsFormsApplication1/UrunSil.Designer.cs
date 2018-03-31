namespace WindowsFormsApplication1
{
    partial class UrunSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSil));
            this.urun_sil = new System.Windows.Forms.Button();
            this.urun_adi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // urun_sil
            // 
            this.urun_sil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.urun_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urun_sil.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.urun_sil.Location = new System.Drawing.Point(262, 291);
            this.urun_sil.Margin = new System.Windows.Forms.Padding(4);
            this.urun_sil.Name = "urun_sil";
            this.urun_sil.Size = new System.Drawing.Size(112, 32);
            this.urun_sil.TabIndex = 1;
            this.urun_sil.Text = "Sil";
            this.urun_sil.UseVisualStyleBackColor = false;
            this.urun_sil.Click += new System.EventHandler(this.urun_sil_Click);
            // 
            // urun_adi
            // 
            this.urun_adi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.urun_adi.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_adi.Location = new System.Drawing.Point(223, 99);
            this.urun_adi.Margin = new System.Windows.Forms.Padding(4);
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(174, 25);
            this.urun_adi.TabIndex = 2;
            this.urun_adi.Text = "Ürün Adı Giriniz...";
            this.urun_adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(595, 488);
            this.Controls.Add(this.urun_adi);
            this.Controls.Add(this.urun_sil);
            this.Name = "UrunSil";
            this.Text = "UrunSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urun_sil;
        private System.Windows.Forms.TextBox urun_adi;
    }
}