namespace WindowsFormsApplication1
{
    partial class SiparisTakibi
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
            this.eFDemoDataSet = new WindowsFormsApplication1.EFDemoDataSet();
            this.sIPARISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIPARISTableAdapter = new WindowsFormsApplication1.EFDemoDataSetTableAdapters.SIPARISTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.Goster = new System.Windows.Forms.Button();
            this.Siparisler_Combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eFDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIPARISBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eFDemoDataSet
            // 
            this.eFDemoDataSet.DataSetName = "EFDemoDataSet";
            this.eFDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sIPARISBindingSource
            // 
            this.sIPARISBindingSource.DataMember = "SIPARIS";
            this.sIPARISBindingSource.DataSource = this.eFDemoDataSet;
            // 
            // sIPARISTableAdapter
            // 
            this.sIPARISTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Siparişler:";
            // 
            // Kullanici_Adi
            // 
            this.Kullanici_Adi.BackColor = System.Drawing.Color.Linen;
            this.Kullanici_Adi.Location = new System.Drawing.Point(125, 59);
            this.Kullanici_Adi.Name = "Kullanici_Adi";
            this.Kullanici_Adi.Size = new System.Drawing.Size(137, 22);
            this.Kullanici_Adi.TabIndex = 3;
            // 
            // Goster
            // 
            this.Goster.BackColor = System.Drawing.Color.Linen;
            this.Goster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Goster.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Goster.Location = new System.Drawing.Point(187, 87);
            this.Goster.Name = "Goster";
            this.Goster.Size = new System.Drawing.Size(75, 23);
            this.Goster.TabIndex = 6;
            this.Goster.Text = "Göster";
            this.Goster.UseVisualStyleBackColor = false;
            this.Goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // Siparisler_Combo
            // 
            this.Siparisler_Combo.BackColor = System.Drawing.Color.Linen;
            this.Siparisler_Combo.FormattingEnabled = true;
            this.Siparisler_Combo.Location = new System.Drawing.Point(125, 132);
            this.Siparisler_Combo.Name = "Siparisler_Combo";
            this.Siparisler_Combo.Size = new System.Drawing.Size(137, 24);
            this.Siparisler_Combo.TabIndex = 7;
            // 
            // SiparisTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(293, 282);
            this.Controls.Add(this.Siparisler_Combo);
            this.Controls.Add(this.Goster);
            this.Controls.Add(this.Kullanici_Adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SiparisTakibi";
            this.Text = "Sipariş Takibi";
            ((System.ComponentModel.ISupportInitialize)(this.eFDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIPARISBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EFDemoDataSet eFDemoDataSet;
        private System.Windows.Forms.BindingSource sIPARISBindingSource;
        private EFDemoDataSetTableAdapters.SIPARISTableAdapter sIPARISTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kullanici_Adi;
        private System.Windows.Forms.Button Goster;
        private System.Windows.Forms.ComboBox Siparisler_Combo;
    }
}