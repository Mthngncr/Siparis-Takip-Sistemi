namespace WindowsFormsApplication1
{
    partial class AdminSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSayfasi));
            this.Musteri_Ekle = new System.Windows.Forms.Button();
            this.Urun_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Urun_Guncelle = new System.Windows.Forms.Button();
            this.Musteri_Detayi = new System.Windows.Forms.Button();
            this.Urun_Detayi = new System.Windows.Forms.Button();
            this.Musteri_Sil = new System.Windows.Forms.Button();
            this.Urun_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Musteri_Ekle
            // 
            this.Musteri_Ekle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Musteri_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Musteri_Ekle.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Musteri_Ekle.Location = new System.Drawing.Point(242, 41);
            this.Musteri_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.Musteri_Ekle.Name = "Musteri_Ekle";
            this.Musteri_Ekle.Size = new System.Drawing.Size(135, 28);
            this.Musteri_Ekle.TabIndex = 0;
            this.Musteri_Ekle.Text = "Müşteri Ekle";
            this.Musteri_Ekle.UseVisualStyleBackColor = false;
            this.Musteri_Ekle.Click += new System.EventHandler(this.musteri_ekle_Click);
            // 
            // Urun_Ekle
            // 
            this.Urun_Ekle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Urun_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Urun_Ekle.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urun_Ekle.Location = new System.Drawing.Point(158, 301);
            this.Urun_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.Urun_Ekle.Name = "Urun_Ekle";
            this.Urun_Ekle.Size = new System.Drawing.Size(135, 26);
            this.Urun_Ekle.TabIndex = 1;
            this.Urun_Ekle.Text = "Ürün Ekle";
            this.Urun_Ekle.UseVisualStyleBackColor = false;
            this.Urun_Ekle.Click += new System.EventHandler(this.urun_bilgi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Urun_Guncelle
            // 
            this.Urun_Guncelle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Urun_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Urun_Guncelle.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urun_Guncelle.Location = new System.Drawing.Point(315, 358);
            this.Urun_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.Urun_Guncelle.Name = "Urun_Guncelle";
            this.Urun_Guncelle.Size = new System.Drawing.Size(135, 28);
            this.Urun_Guncelle.TabIndex = 0;
            this.Urun_Guncelle.Text = "Ürün Güncelle";
            this.Urun_Guncelle.UseVisualStyleBackColor = false;
            this.Urun_Guncelle.Click += new System.EventHandler(this.urun_guncelle_Click);
            // 
            // Musteri_Detayi
            // 
            this.Musteri_Detayi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Musteri_Detayi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Musteri_Detayi.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Musteri_Detayi.Location = new System.Drawing.Point(158, 92);
            this.Musteri_Detayi.Name = "Musteri_Detayi";
            this.Musteri_Detayi.Size = new System.Drawing.Size(135, 26);
            this.Musteri_Detayi.TabIndex = 4;
            this.Musteri_Detayi.Text = "Müşteri Detayı";
            this.Musteri_Detayi.UseVisualStyleBackColor = false;
            this.Musteri_Detayi.Click += new System.EventHandler(this.musteri_detayi_Click);
            // 
            // Urun_Detayi
            // 
            this.Urun_Detayi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Urun_Detayi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Urun_Detayi.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urun_Detayi.Location = new System.Drawing.Point(158, 360);
            this.Urun_Detayi.Name = "Urun_Detayi";
            this.Urun_Detayi.Size = new System.Drawing.Size(135, 26);
            this.Urun_Detayi.TabIndex = 5;
            this.Urun_Detayi.Text = "Ürün Detay";
            this.Urun_Detayi.UseVisualStyleBackColor = false;
            this.Urun_Detayi.Click += new System.EventHandler(this.urun_detayi_Click);
            // 
            // Musteri_Sil
            // 
            this.Musteri_Sil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Musteri_Sil.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Musteri_Sil.Location = new System.Drawing.Point(315, 90);
            this.Musteri_Sil.Name = "Musteri_Sil";
            this.Musteri_Sil.Size = new System.Drawing.Size(135, 28);
            this.Musteri_Sil.TabIndex = 6;
            this.Musteri_Sil.Text = "Müşteri Sil";
            this.Musteri_Sil.UseVisualStyleBackColor = false;
            this.Musteri_Sil.Click += new System.EventHandler(this.Musteri_Sil_Click);
            // 
            // Urun_Sil
            // 
            this.Urun_Sil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Urun_Sil.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Urun_Sil.Location = new System.Drawing.Point(315, 301);
            this.Urun_Sil.Name = "Urun_Sil";
            this.Urun_Sil.Size = new System.Drawing.Size(135, 26);
            this.Urun_Sil.TabIndex = 7;
            this.Urun_Sil.Text = "Ürün Sil";
            this.Urun_Sil.UseVisualStyleBackColor = false;
            this.Urun_Sil.Click += new System.EventHandler(this.Urun_Sil_Click);
            // 
            // AdminSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 464);
            this.Controls.Add(this.Urun_Sil);
            this.Controls.Add(this.Musteri_Sil);
            this.Controls.Add(this.Urun_Detayi);
            this.Controls.Add(this.Musteri_Detayi);
            this.Controls.Add(this.Urun_Guncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Urun_Ekle);
            this.Controls.Add(this.Musteri_Ekle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminSayfasi";
            this.Text = "Admin Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Musteri_Ekle;
        private System.Windows.Forms.Button Urun_Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Urun_Guncelle;
        private System.Windows.Forms.Button Musteri_Detayi;
        private System.Windows.Forms.Button Urun_Detayi;
        private System.Windows.Forms.Button Musteri_Sil;
        private System.Windows.Forms.Button Urun_Sil;
    }
}

