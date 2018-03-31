namespace WindowsFormsApplication1
{
    partial class SiparisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkrani));
            this.Admin_Giris = new System.Windows.Forms.Button();
            this.Musteri_Guncelleme = new System.Windows.Forms.Button();
            this.Siparisler_Listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Siparisler_Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Siparis_Ekle = new System.Windows.Forms.Button();
            this.Satin_Al = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Bakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Admin_Giris
            // 
            this.Admin_Giris.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Admin_Giris.Location = new System.Drawing.Point(360, 15);
            this.Admin_Giris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Admin_Giris.Name = "Admin_Giris";
            this.Admin_Giris.Size = new System.Drawing.Size(78, 28);
            this.Admin_Giris.TabIndex = 0;
            this.Admin_Giris.Text = "Admin";
            this.Admin_Giris.UseVisualStyleBackColor = false;
            this.Admin_Giris.Click += new System.EventHandler(this.Admin_Giris_Click);
            // 
            // Musteri_Guncelleme
            // 
            this.Musteri_Guncelleme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Musteri_Guncelleme.Location = new System.Drawing.Point(455, 15);
            this.Musteri_Guncelleme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Musteri_Guncelleme.Name = "Musteri_Guncelleme";
            this.Musteri_Guncelleme.Size = new System.Drawing.Size(108, 42);
            this.Musteri_Guncelleme.TabIndex = 1;
            this.Musteri_Guncelleme.Text = "Müşteri Güncelleme";
            this.Musteri_Guncelleme.UseVisualStyleBackColor = false;
            this.Musteri_Guncelleme.Click += new System.EventHandler(this.Musteri_Guncelleme_Click);
            // 
            // Siparisler_Listbox
            // 
            this.Siparisler_Listbox.BackColor = System.Drawing.Color.GhostWhite;
            this.Siparisler_Listbox.FormattingEnabled = true;
            this.Siparisler_Listbox.ItemHeight = 16;
            this.Siparisler_Listbox.Location = new System.Drawing.Point(424, 132);
            this.Siparisler_Listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Siparisler_Listbox.Name = "Siparisler_Listbox";
            this.Siparisler_Listbox.Size = new System.Drawing.Size(139, 180);
            this.Siparisler_Listbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(452, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sipariş Listesi";
            // 
            // Siparisler_Combo
            // 
            this.Siparisler_Combo.BackColor = System.Drawing.Color.GhostWhite;
            this.Siparisler_Combo.FormattingEnabled = true;
            this.Siparisler_Combo.Location = new System.Drawing.Point(126, 112);
            this.Siparisler_Combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Siparisler_Combo.Name = "Siparisler_Combo";
            this.Siparisler_Combo.Size = new System.Drawing.Size(131, 24);
            this.Siparisler_Combo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 9;
            // 
            // Siparis_Ekle
            // 
            this.Siparis_Ekle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Siparis_Ekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Siparis_Ekle.Location = new System.Drawing.Point(170, 380);
            this.Siparis_Ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Siparis_Ekle.Name = "Siparis_Ekle";
            this.Siparis_Ekle.Size = new System.Drawing.Size(87, 28);
            this.Siparis_Ekle.TabIndex = 10;
            this.Siparis_Ekle.Text = "Ekle";
            this.Siparis_Ekle.UseVisualStyleBackColor = false;
            this.Siparis_Ekle.Click += new System.EventHandler(this.Siparis_Ekle_Click);
            // 
            // Satin_Al
            // 
            this.Satin_Al.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Satin_Al.Location = new System.Drawing.Point(469, 380);
            this.Satin_Al.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Satin_Al.Name = "Satin_Al";
            this.Satin_Al.Size = new System.Drawing.Size(94, 25);
            this.Satin_Al.TabIndex = 11;
            this.Satin_Al.Text = "Satın Al";
            this.Satin_Al.UseVisualStyleBackColor = false;
            this.Satin_Al.Click += new System.EventHandler(this.Satin_Al_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bakiyeniz:";
            // 
            // Bakiye
            // 
            this.Bakiye.BackColor = System.Drawing.Color.GhostWhite;
            this.Bakiye.Location = new System.Drawing.Point(126, 41);
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.Size = new System.Drawing.Size(100, 22);
            this.Bakiye.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 15;
            // 
            // SiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Satin_Al);
            this.Controls.Add(this.Siparis_Ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Siparisler_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Siparisler_Listbox);
            this.Controls.Add(this.Musteri_Guncelleme);
            this.Controls.Add(this.Admin_Giris);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SiparisEkrani";
            this.Text = "SiparisEkrani";
            this.Load += new System.EventHandler(this.SiparisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin_Giris;
        private System.Windows.Forms.Button Musteri_Guncelleme;
        private System.Windows.Forms.ListBox Siparisler_Listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Siparisler_Combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Siparis_Ekle;
        private System.Windows.Forms.Button Satin_Al;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Bakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}