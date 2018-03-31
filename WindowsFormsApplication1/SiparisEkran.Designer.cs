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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Urun_ListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Urun_Combo = new System.Windows.Forms.ComboBox();
            this.uRUNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eFDemoDataSet = new WindowsFormsApplication1.EFDemoDataSet();
            this.uRUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.uRUNTableAdapter = new WindowsFormsApplication1.EFDemoDataSetTableAdapters.URUNTableAdapter();
            this.fKTable3Table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIPARISTableAdapter = new WindowsFormsApplication1.EFDemoDataSetTableAdapters.SIPARISTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.uRUNBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKTable3Table2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKTable3Table2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Musteri_Guncelleme = new System.Windows.Forms.Button();
            this.Toplam_Fiyat = new System.Windows.Forms.TextBox();
            this.Satin_Al = new System.Windows.Forms.Button();
            this.Sepete_Ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Bakiye = new System.Windows.Forms.TextBox();
            this.admin_girisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTable3Table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTable3Table2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTable3Table2BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Listesi";
            // 
            // Urun_ListBox
            // 
            this.Urun_ListBox.BackColor = System.Drawing.Color.SeaShell;
            this.Urun_ListBox.FormattingEnabled = true;
            this.Urun_ListBox.ItemHeight = 16;
            this.Urun_ListBox.Location = new System.Drawing.Point(301, 107);
            this.Urun_ListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Urun_ListBox.Name = "Urun_ListBox";
            this.Urun_ListBox.Size = new System.Drawing.Size(139, 116);
            this.Urun_ListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(330, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seçilen Ürünler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(173, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hoşgeldiniz!";
            // 
            // Urun_Combo
            // 
            this.Urun_Combo.BackColor = System.Drawing.Color.SeaShell;
            this.Urun_Combo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uRUNBindingSource1, "ID", true));
            this.Urun_Combo.DataSource = this.uRUNBindingSource1;
            this.Urun_Combo.DisplayMember = "URUNAD";
            this.Urun_Combo.FormattingEnabled = true;
            this.Urun_Combo.Location = new System.Drawing.Point(12, 107);
            this.Urun_Combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Urun_Combo.Name = "Urun_Combo";
            this.Urun_Combo.Size = new System.Drawing.Size(165, 24);
            this.Urun_Combo.TabIndex = 12;
            this.Urun_Combo.ValueMember = "ID";
            this.Urun_Combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uRUNBindingSource1
            // 
            this.uRUNBindingSource1.DataMember = "URUN";
            this.uRUNBindingSource1.DataSource = this.eFDemoDataSet;
            // 
            // eFDemoDataSet
            // 
            this.eFDemoDataSet.DataSetName = "EFDemoDataSet";
            this.eFDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUNBindingSource
            // 
            this.uRUNBindingSource.DataMember = "URUN";
            this.uRUNBindingSource.DataSource = this.eFDemoDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(234, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Toplam Fiyat:";
            // 
            // uRUNTableAdapter
            // 
            this.uRUNTableAdapter.ClearBeforeFill = true;
            // 
            // fKTable3Table2BindingSource
            // 
            this.fKTable3Table2BindingSource.DataMember = "FK_Table_3_Table_2";
            this.fKTable3Table2BindingSource.DataSource = this.uRUNBindingSource;
            // 
            // sIPARISTableAdapter
            // 
            this.sIPARISTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 15;
            // 
            // uRUNBindingSource2
            // 
            this.uRUNBindingSource2.DataMember = "URUN";
            this.uRUNBindingSource2.DataSource = this.eFDemoDataSet;
            // 
            // fKTable3Table2BindingSource1
            // 
            this.fKTable3Table2BindingSource1.DataMember = "FK_Table_3_Table_2";
            this.fKTable3Table2BindingSource1.DataSource = this.uRUNBindingSource;
            // 
            // fKTable3Table2BindingSource2
            // 
            this.fKTable3Table2BindingSource2.DataMember = "FK_Table_3_Table_2";
            this.fKTable3Table2BindingSource2.DataSource = this.uRUNBindingSource;
            // 
            // Musteri_Guncelleme
            // 
            this.Musteri_Guncelleme.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Musteri_Guncelleme.Location = new System.Drawing.Point(353, 2);
            this.Musteri_Guncelleme.Name = "Musteri_Guncelleme";
            this.Musteri_Guncelleme.Size = new System.Drawing.Size(99, 41);
            this.Musteri_Guncelleme.TabIndex = 16;
            this.Musteri_Guncelleme.Text = "Müşteri Güncelleme";
            this.Musteri_Guncelleme.UseVisualStyleBackColor = true;
            this.Musteri_Guncelleme.Click += new System.EventHandler(this.musteri_guncelle_Click);
            // 
            // Toplam_Fiyat
            // 
            this.Toplam_Fiyat.BackColor = System.Drawing.Color.Linen;
            this.Toplam_Fiyat.Location = new System.Drawing.Point(340, 230);
            this.Toplam_Fiyat.Name = "Toplam_Fiyat";
            this.Toplam_Fiyat.Size = new System.Drawing.Size(100, 22);
            this.Toplam_Fiyat.TabIndex = 17;
            // 
            // Satin_Al
            // 
            this.Satin_Al.Location = new System.Drawing.Point(377, 282);
            this.Satin_Al.Name = "Satin_Al";
            this.Satin_Al.Size = new System.Drawing.Size(75, 23);
            this.Satin_Al.TabIndex = 18;
            this.Satin_Al.Text = "Satın Al";
            this.Satin_Al.UseVisualStyleBackColor = true;
            this.Satin_Al.Click += new System.EventHandler(this.satin_al_Click);
            // 
            // Sepete_Ekle
            // 
            this.Sepete_Ekle.Location = new System.Drawing.Point(12, 271);
            this.Sepete_Ekle.Name = "Sepete_Ekle";
            this.Sepete_Ekle.Size = new System.Drawing.Size(82, 34);
            this.Sepete_Ekle.TabIndex = 19;
            this.Sepete_Ekle.Text = "Sepete Ekle";
            this.Sepete_Ekle.UseVisualStyleBackColor = true;
            this.Sepete_Ekle.Click += new System.EventHandler(this.sepete_ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bakiye:";
            // 
            // Bakiye
            // 
            this.Bakiye.Location = new System.Drawing.Point(56, 32);
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.ReadOnly = true;
            this.Bakiye.Size = new System.Drawing.Size(72, 22);
            this.Bakiye.TabIndex = 21;
            // 
            // admin_girisi
            // 
            this.admin_girisi.Location = new System.Drawing.Point(263, 2);
            this.admin_girisi.Name = "admin_girisi";
            this.admin_girisi.Size = new System.Drawing.Size(75, 23);
            this.admin_girisi.TabIndex = 22;
            this.admin_girisi.Text = "Admin";
            this.admin_girisi.UseVisualStyleBackColor = true;
            this.admin_girisi.Click += new System.EventHandler(this.admin_giris_Click);
            // 
            // SiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(464, 403);
            this.Controls.Add(this.admin_girisi);
            this.Controls.Add(this.Bakiye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sepete_Ekle);
            this.Controls.Add(this.Satin_Al);
            this.Controls.Add(this.Toplam_Fiyat);
            this.Controls.Add(this.Musteri_Guncelleme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Urun_Combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Urun_ListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SiparisEkrani";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.SiparisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTable3Table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTable3Table2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTable3Table2BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Urun_ListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Urun_Combo;
        private System.Windows.Forms.Label label4;
        private EFDemoDataSet eFDemoDataSet;
        private System.Windows.Forms.BindingSource uRUNBindingSource;
        private EFDemoDataSetTableAdapters.URUNTableAdapter uRUNTableAdapter;
        private System.Windows.Forms.BindingSource fKTable3Table2BindingSource;
        private EFDemoDataSetTableAdapters.SIPARISTableAdapter sIPARISTableAdapter;
        private System.Windows.Forms.BindingSource uRUNBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource uRUNBindingSource2;
        private System.Windows.Forms.BindingSource fKTable3Table2BindingSource1;
        private System.Windows.Forms.BindingSource fKTable3Table2BindingSource2;
        private System.Windows.Forms.Button Musteri_Guncelleme;
        private System.Windows.Forms.TextBox Toplam_Fiyat;
        private System.Windows.Forms.Button Satin_Al;
        private System.Windows.Forms.Button Sepete_Ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Bakiye;
        private System.Windows.Forms.Button admin_girisi;
    }
}