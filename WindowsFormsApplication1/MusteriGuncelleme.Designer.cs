namespace WindowsFormsApplication1
{
    partial class MusteriGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelleme));
            this.Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.Kullanici_Soyadi = new System.Windows.Forms.TextBox();
            this.Kullanici_Yasi = new System.Windows.Forms.TextBox();
            this.Kullanici_Maili = new System.Windows.Forms.TextBox();
            this.Kullanici_Eski_Sifre = new System.Windows.Forms.TextBox();
            this.Kullanici_Bakiye = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Ad_Check = new System.Windows.Forms.CheckBox();
            this.Soyad_Check = new System.Windows.Forms.CheckBox();
            this.Yas_Check = new System.Windows.Forms.CheckBox();
            this.Mail__Check = new System.Windows.Forms.CheckBox();
            this.Sifre__Check = new System.Windows.Forms.CheckBox();
            this.Bakiye_Check = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Kullanici_Sifre = new System.Windows.Forms.TextBox();
            this.Kullanici_Sifre_Tekrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kaydet.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.Location = new System.Drawing.Point(245, 421);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(101, 26);
            this.Kaydet.TabIndex = 0;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Eski Şifre:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(51, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bakiye:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kullanici_Adi
            // 
            this.Kullanici_Adi.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Adi.Location = new System.Drawing.Point(210, 90);
            this.Kullanici_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Adi.Name = "Kullanici_Adi";
            this.Kullanici_Adi.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Adi.TabIndex = 5;
            // 
            // Kullanici_Soyadi
            // 
            this.Kullanici_Soyadi.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Soyadi.Location = new System.Drawing.Point(210, 131);
            this.Kullanici_Soyadi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Soyadi.Name = "Kullanici_Soyadi";
            this.Kullanici_Soyadi.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Soyadi.TabIndex = 5;
            // 
            // Kullanici_Yasi
            // 
            this.Kullanici_Yasi.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Yasi.Location = new System.Drawing.Point(210, 173);
            this.Kullanici_Yasi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Yasi.Name = "Kullanici_Yasi";
            this.Kullanici_Yasi.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Yasi.TabIndex = 5;
            // 
            // Kullanici_Maili
            // 
            this.Kullanici_Maili.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Maili.Location = new System.Drawing.Point(210, 212);
            this.Kullanici_Maili.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Maili.Name = "Kullanici_Maili";
            this.Kullanici_Maili.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Maili.TabIndex = 5;
            // 
            // Kullanici_Eski_Sifre
            // 
            this.Kullanici_Eski_Sifre.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Eski_Sifre.Location = new System.Drawing.Point(210, 252);
            this.Kullanici_Eski_Sifre.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Eski_Sifre.Name = "Kullanici_Eski_Sifre";
            this.Kullanici_Eski_Sifre.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Eski_Sifre.TabIndex = 5;
            // 
            // Kullanici_Bakiye
            // 
            this.Kullanici_Bakiye.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Bakiye.Location = new System.Drawing.Point(210, 373);
            this.Kullanici_Bakiye.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Bakiye.Name = "Kullanici_Bakiye";
            this.Kullanici_Bakiye.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Bakiye.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 2;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(210, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Güncelleme Bilgileri";
            // 
            // Ad_Check
            // 
            this.Ad_Check.AutoSize = true;
            this.Ad_Check.Location = new System.Drawing.Point(414, 90);
            this.Ad_Check.Name = "Ad_Check";
            this.Ad_Check.Size = new System.Drawing.Size(15, 14);
            this.Ad_Check.TabIndex = 7;
            this.Ad_Check.UseVisualStyleBackColor = true;
            this.Ad_Check.CheckedChanged += new System.EventHandler(this.Ad_Check_CheckedChanged);
            // 
            // Soyad_Check
            // 
            this.Soyad_Check.AutoSize = true;
            this.Soyad_Check.Location = new System.Drawing.Point(414, 130);
            this.Soyad_Check.Name = "Soyad_Check";
            this.Soyad_Check.Size = new System.Drawing.Size(15, 14);
            this.Soyad_Check.TabIndex = 8;
            this.Soyad_Check.UseVisualStyleBackColor = true;
            this.Soyad_Check.CheckedChanged += new System.EventHandler(this.Soyad_Check_CheckedChanged);
            // 
            // Yas_Check
            // 
            this.Yas_Check.AutoSize = true;
            this.Yas_Check.Location = new System.Drawing.Point(414, 173);
            this.Yas_Check.Name = "Yas_Check";
            this.Yas_Check.Size = new System.Drawing.Size(15, 14);
            this.Yas_Check.TabIndex = 9;
            this.Yas_Check.UseVisualStyleBackColor = true;
            this.Yas_Check.CheckedChanged += new System.EventHandler(this.Yas_Check_CheckedChanged);
            // 
            // Mail__Check
            // 
            this.Mail__Check.AutoSize = true;
            this.Mail__Check.Location = new System.Drawing.Point(414, 212);
            this.Mail__Check.Name = "Mail__Check";
            this.Mail__Check.Size = new System.Drawing.Size(15, 14);
            this.Mail__Check.TabIndex = 10;
            this.Mail__Check.UseVisualStyleBackColor = true;
            this.Mail__Check.CheckedChanged += new System.EventHandler(this.Mail__Check_CheckedChanged);
            // 
            // Sifre__Check
            // 
            this.Sifre__Check.AutoSize = true;
            this.Sifre__Check.Location = new System.Drawing.Point(414, 252);
            this.Sifre__Check.Name = "Sifre__Check";
            this.Sifre__Check.Size = new System.Drawing.Size(15, 14);
            this.Sifre__Check.TabIndex = 11;
            this.Sifre__Check.UseVisualStyleBackColor = true;
            this.Sifre__Check.CheckedChanged += new System.EventHandler(this.Sifre__Check_CheckedChanged);
            // 
            // Bakiye_Check
            // 
            this.Bakiye_Check.AutoSize = true;
            this.Bakiye_Check.Location = new System.Drawing.Point(414, 373);
            this.Bakiye_Check.Name = "Bakiye_Check";
            this.Bakiye_Check.Size = new System.Drawing.Size(15, 14);
            this.Bakiye_Check.TabIndex = 12;
            this.Bakiye_Check.UseVisualStyleBackColor = true;
            this.Bakiye_Check.CheckedChanged += new System.EventHandler(this.Bakiye_Check_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Yeni Şifre Tekrar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(51, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Yeni Şifre:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kullanici_Sifre
            // 
            this.Kullanici_Sifre.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Sifre.Location = new System.Drawing.Point(210, 293);
            this.Kullanici_Sifre.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Sifre.Name = "Kullanici_Sifre";
            this.Kullanici_Sifre.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Sifre.TabIndex = 5;
            // 
            // Kullanici_Sifre_Tekrar
            // 
            this.Kullanici_Sifre_Tekrar.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Sifre_Tekrar.Location = new System.Drawing.Point(210, 333);
            this.Kullanici_Sifre_Tekrar.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Sifre_Tekrar.Name = "Kullanici_Sifre_Tekrar";
            this.Kullanici_Sifre_Tekrar.Size = new System.Drawing.Size(187, 20);
            this.Kullanici_Sifre_Tekrar.TabIndex = 5;
            // 
            // MusteriGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(587, 518);
            this.Controls.Add(this.Kullanici_Sifre_Tekrar);
            this.Controls.Add(this.Kullanici_Sifre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bakiye_Check);
            this.Controls.Add(this.Sifre__Check);
            this.Controls.Add(this.Mail__Check);
            this.Controls.Add(this.Yas_Check);
            this.Controls.Add(this.Soyad_Check);
            this.Controls.Add(this.Ad_Check);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Kullanici_Bakiye);
            this.Controls.Add(this.Kullanici_Eski_Sifre);
            this.Controls.Add(this.Kullanici_Maili);
            this.Controls.Add(this.Kullanici_Yasi);
            this.Controls.Add(this.Kullanici_Soyadi);
            this.Controls.Add(this.Kullanici_Adi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaydet);
            this.Name = "MusteriGuncelleme";
            this.Text = "Müşteri Güncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Kullanici_Adi;
        private System.Windows.Forms.TextBox Kullanici_Soyadi;
        private System.Windows.Forms.TextBox Kullanici_Yasi;
        private System.Windows.Forms.TextBox Kullanici_Maili;
        private System.Windows.Forms.TextBox Kullanici_Eski_Sifre;
        private System.Windows.Forms.TextBox Kullanici_Bakiye;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Ad_Check;
        private System.Windows.Forms.CheckBox Soyad_Check;
        private System.Windows.Forms.CheckBox Yas_Check;
        private System.Windows.Forms.CheckBox Mail__Check;
        private System.Windows.Forms.CheckBox Sifre__Check;
        private System.Windows.Forms.CheckBox Bakiye_Check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Kullanici_Sifre;
        private System.Windows.Forms.TextBox Kullanici_Sifre_Tekrar;
    }
}