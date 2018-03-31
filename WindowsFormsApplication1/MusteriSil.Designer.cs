namespace WindowsFormsApplication1
{
    partial class MusteriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSil));
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kullanici_adi.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi.Location = new System.Drawing.Point(228, 116);
            this.kullanici_adi.Margin = new System.Windows.Forms.Padding(4);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(174, 25);
            this.kullanici_adi.TabIndex = 2;
            this.kullanici_adi.Text = "Kullanıcı Adı Giriniz...";
            this.kullanici_adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sil.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Sil.Location = new System.Drawing.Point(260, 282);
            this.Sil.Margin = new System.Windows.Forms.Padding(4);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(112, 32);
            this.Sil.TabIndex = 1;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // MusteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 480);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.kullanici_adi);
            this.Name = "MusteriSil";
            this.Text = "MusteriSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.Button Sil;
    }
}