namespace WindowsFormsApplication1
{
    partial class MusteriEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkleme));
            this.Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.Kullanici_Soyadi = new System.Windows.Forms.TextBox();
            this.Kullanici_Yasi = new System.Windows.Forms.TextBox();
            this.Kullanici_Maili = new System.Windows.Forms.TextBox();
            this.Kullanici_User = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.Kullanici_Sifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Sifre_Tekrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Kaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.Location = new System.Drawing.Point(257, 412);
            this.Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(112, 32);
            this.Kaydet.TabIndex = 0;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(134, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(134, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mail:";
            // 
            // Kullanici_Adi
            // 
            this.Kullanici_Adi.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Adi.Location = new System.Drawing.Point(223, 62);
            this.Kullanici_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Adi.Name = "Kullanici_Adi";
            this.Kullanici_Adi.Size = new System.Drawing.Size(187, 25);
            this.Kullanici_Adi.TabIndex = 5;
            // 
            // Kullanici_Soyadi
            // 
            this.Kullanici_Soyadi.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Soyadi.Location = new System.Drawing.Point(223, 112);
            this.Kullanici_Soyadi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Soyadi.Name = "Kullanici_Soyadi";
            this.Kullanici_Soyadi.Size = new System.Drawing.Size(187, 25);
            this.Kullanici_Soyadi.TabIndex = 6;
            // 
            // Kullanici_Yasi
            // 
            this.Kullanici_Yasi.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Yasi.Location = new System.Drawing.Point(223, 161);
            this.Kullanici_Yasi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Yasi.Name = "Kullanici_Yasi";
            this.Kullanici_Yasi.Size = new System.Drawing.Size(187, 25);
            this.Kullanici_Yasi.TabIndex = 7;
            // 
            // Kullanici_Maili
            // 
            this.Kullanici_Maili.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Maili.Location = new System.Drawing.Point(223, 211);
            this.Kullanici_Maili.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Maili.Name = "Kullanici_Maili";
            this.Kullanici_Maili.Size = new System.Drawing.Size(187, 25);
            this.Kullanici_Maili.TabIndex = 8;
            // 
            // Kullanici_User
            // 
            this.Kullanici_User.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Kullanici_User.Location = new System.Drawing.Point(223, 264);
            this.Kullanici_User.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_User.Name = "Kullanici_User";
            this.Kullanici_User.Size = new System.Drawing.Size(187, 25);
            this.Kullanici_User.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(134, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Salmon;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(246, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 21);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Müşteri Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(126, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // Kullanici_Sifre
            // 
            this.Kullanici_Sifre.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Kullanici_Sifre.Location = new System.Drawing.Point(223, 314);
            this.Kullanici_Sifre.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Sifre.Name = "Kullanici_Sifre";
            this.Kullanici_Sifre.Size = new System.Drawing.Size(187, 25);
            this.Kullanici_Sifre.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(126, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Şifre Tekrar:";
            // 
            // Sifre_Tekrar
            // 
            this.Sifre_Tekrar.BackColor = System.Drawing.Color.GhostWhite;
            this.Sifre_Tekrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sifre_Tekrar.Location = new System.Drawing.Point(223, 365);
            this.Sifre_Tekrar.Margin = new System.Windows.Forms.Padding(4);
            this.Sifre_Tekrar.Name = "Sifre_Tekrar";
            this.Sifre_Tekrar.Size = new System.Drawing.Size(187, 25);
            this.Sifre_Tekrar.TabIndex = 13;
            // 
            // MusteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(591, 491);
            this.Controls.Add(this.Sifre_Tekrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Kullanici_Sifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kullanici_User);
            this.Controls.Add(this.Kullanici_Maili);
            this.Controls.Add(this.Kullanici_Yasi);
            this.Controls.Add(this.Kullanici_Soyadi);
            this.Controls.Add(this.Kullanici_Adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaydet);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriEkleme";
            this.Text = "Müşteri Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Kullanici_Adi;
        private System.Windows.Forms.TextBox Kullanici_Soyadi;
        private System.Windows.Forms.TextBox Kullanici_Yasi;
        private System.Windows.Forms.TextBox Kullanici_Maili;
        private System.Windows.Forms.TextBox Kullanici_User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Kullanici_Sifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Sifre_Tekrar;
    }
}