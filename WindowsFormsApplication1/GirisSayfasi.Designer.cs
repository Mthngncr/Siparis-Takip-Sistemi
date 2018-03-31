namespace WindowsFormsApplication1
{
    partial class GirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            this.Kullanici_Girisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Beni_Hatirla_Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Kullanici_Girisi
            // 
            this.Kullanici_Girisi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Kullanici_Girisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kullanici_Girisi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_Girisi.Location = new System.Drawing.Point(225, 324);
            this.Kullanici_Girisi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Girisi.Name = "Kullanici_Girisi";
            this.Kullanici_Girisi.Size = new System.Drawing.Size(167, 33);
            this.Kullanici_Girisi.TabIndex = 1;
            this.Kullanici_Girisi.Text = "Giriş";
            this.Kullanici_Girisi.UseVisualStyleBackColor = false;
            this.Kullanici_Girisi.Click += new System.EventHandler(this.giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // Kullanici_Adi
            // 
            this.Kullanici_Adi.BackColor = System.Drawing.Color.GhostWhite;
            this.Kullanici_Adi.Location = new System.Drawing.Point(234, 68);
            this.Kullanici_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanici_Adi.Name = "Kullanici_Adi";
            this.Kullanici_Adi.Size = new System.Drawing.Size(221, 25);
            this.Kullanici_Adi.TabIndex = 4;
            // 
            // Sifre
            // 
            this.Sifre.BackColor = System.Drawing.Color.GhostWhite;
            this.Sifre.Location = new System.Drawing.Point(234, 101);
            this.Sifre.Margin = new System.Windows.Forms.Padding(4);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(191, 25);
            this.Sifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(225, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "SİPARİŞ TAKİP SİSTEMİ";
            // 
            // Beni_Hatirla_Check
            // 
            this.Beni_Hatirla_Check.AutoSize = true;
            this.Beni_Hatirla_Check.BackColor = System.Drawing.Color.White;
            this.Beni_Hatirla_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Beni_Hatirla_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beni_Hatirla_Check.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Beni_Hatirla_Check.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Beni_Hatirla_Check.Location = new System.Drawing.Point(234, 133);
            this.Beni_Hatirla_Check.Name = "Beni_Hatirla_Check";
            this.Beni_Hatirla_Check.Size = new System.Drawing.Size(93, 21);
            this.Beni_Hatirla_Check.TabIndex = 7;
            this.Beni_Hatirla_Check.Text = "Beni Hatırla";
            this.Beni_Hatirla_Check.UseCompatibleTextRendering = true;
            this.Beni_Hatirla_Check.UseVisualStyleBackColor = false;
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(619, 483);
            this.Controls.Add(this.Beni_Hatirla_Check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.Kullanici_Adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kullanici_Girisi);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisSayfasi";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Kullanici_Girisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kullanici_Adi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Beni_Hatirla_Check;
    }
}