namespace WindowsFormsApplication1
{
    partial class UrunGuncelleme
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
            this.Guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Urun_Adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Urun_Fiyat = new System.Windows.Forms.TextBox();
            this.Urun_Stok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.Color.Linen;
            this.Guncelle.Location = new System.Drawing.Point(193, 313);
            this.Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(112, 34);
            this.Guncelle.TabIndex = 0;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı Giriniz:";
            // 
            // Urun_Adi
            // 
            this.Urun_Adi.Location = new System.Drawing.Point(157, 101);
            this.Urun_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.Urun_Adi.Name = "Urun_Adi";
            this.Urun_Adi.Size = new System.Drawing.Size(148, 26);
            this.Urun_Adi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Fiyatını Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(13, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Stoğunu Giriniz:";
            // 
            // Urun_Fiyat
            // 
            this.Urun_Fiyat.Location = new System.Drawing.Point(217, 167);
            this.Urun_Fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.Urun_Fiyat.Name = "Urun_Fiyat";
            this.Urun_Fiyat.Size = new System.Drawing.Size(88, 26);
            this.Urun_Fiyat.TabIndex = 5;
            // 
            // Urun_Stok
            // 
            this.Urun_Stok.Location = new System.Drawing.Point(217, 226);
            this.Urun_Stok.Margin = new System.Windows.Forms.Padding(4);
            this.Urun_Stok.Name = "Urun_Stok";
            this.Urun_Stok.Size = new System.Drawing.Size(88, 26);
            this.Urun_Stok.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(82, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Güncelleme Bilgileri";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UrunGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(316, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Urun_Stok);
            this.Controls.Add(this.Urun_Fiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Urun_Adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guncelle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunGuncelleme";
            this.Text = "Ürün Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Urun_Adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Urun_Fiyat;
        private System.Windows.Forms.TextBox Urun_Stok;
        private System.Windows.Forms.Label label4;
    }
}