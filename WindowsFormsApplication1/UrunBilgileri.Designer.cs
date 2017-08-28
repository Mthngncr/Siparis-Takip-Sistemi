namespace WindowsFormsApplication1
{
    partial class UrunBilgileri
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
            this.Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Urun_Adi = new System.Windows.Forms.TextBox();
            this.Urun_Fiyat = new System.Windows.Forms.TextBox();
            this.Urun_Stok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.Moccasin;
            this.Kaydet.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.Location = new System.Drawing.Point(175, 328);
            this.Kaydet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(125, 31);
            this.Kaydet.TabIndex = 0;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.UseWaitCursor = true;
            this.Kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok:";
            this.label3.UseWaitCursor = true;
            // 
            // Urun_Adi
            // 
            this.Urun_Adi.BackColor = System.Drawing.Color.Bisque;
            this.Urun_Adi.Location = new System.Drawing.Point(175, 144);
            this.Urun_Adi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Urun_Adi.Name = "Urun_Adi";
            this.Urun_Adi.Size = new System.Drawing.Size(239, 24);
            this.Urun_Adi.TabIndex = 4;
            this.Urun_Adi.UseWaitCursor = true;
            // 
            // Urun_Fiyat
            // 
            this.Urun_Fiyat.BackColor = System.Drawing.Color.Bisque;
            this.Urun_Fiyat.Location = new System.Drawing.Point(175, 201);
            this.Urun_Fiyat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Urun_Fiyat.Name = "Urun_Fiyat";
            this.Urun_Fiyat.Size = new System.Drawing.Size(239, 24);
            this.Urun_Fiyat.TabIndex = 5;
            this.Urun_Fiyat.UseWaitCursor = true;
            // 
            // Urun_Stok
            // 
            this.Urun_Stok.BackColor = System.Drawing.Color.Bisque;
            this.Urun_Stok.Location = new System.Drawing.Point(175, 262);
            this.Urun_Stok.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Urun_Stok.Name = "Urun_Stok";
            this.Urun_Stok.Size = new System.Drawing.Size(239, 24);
            this.Urun_Stok.TabIndex = 6;
            this.Urun_Stok.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Moccasin;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(171, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Bilgileri";
            this.label4.UseWaitCursor = true;
            // 
            // UrunBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(495, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Urun_Stok);
            this.Controls.Add(this.Urun_Fiyat);
            this.Controls.Add(this.Urun_Adi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaydet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UrunBilgileri";
            this.Text = "Ürün Bilgileri";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Urun_Adi;
        private System.Windows.Forms.TextBox Urun_Fiyat;
        private System.Windows.Forms.TextBox Urun_Stok;
        private System.Windows.Forms.Label label4;
    }
}