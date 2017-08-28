namespace WindowsFormsApplication1
{
    partial class MusteriDetayi
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
            this.Musteri_Detay_Grid = new System.Windows.Forms.DataGridView();
            this.Goster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Musteri_Adi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Musteri_Detay_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Musteri_Detay_Grid
            // 
            this.Musteri_Detay_Grid.BackgroundColor = System.Drawing.Color.Linen;
            this.Musteri_Detay_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Musteri_Detay_Grid.Location = new System.Drawing.Point(26, 118);
            this.Musteri_Detay_Grid.Name = "Musteri_Detay_Grid";
            this.Musteri_Detay_Grid.Size = new System.Drawing.Size(718, 150);
            this.Musteri_Detay_Grid.TabIndex = 0;
            // 
            // Goster
            // 
            this.Goster.BackColor = System.Drawing.Color.Linen;
            this.Goster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Goster.Location = new System.Drawing.Point(197, 67);
            this.Goster.Name = "Goster";
            this.Goster.Size = new System.Drawing.Size(75, 23);
            this.Goster.TabIndex = 1;
            this.Goster.Text = "Göster";
            this.Goster.UseVisualStyleBackColor = false;
            this.Goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Adı:";
            // 
            // Musteri_Adi
            // 
            this.Musteri_Adi.BackColor = System.Drawing.Color.Linen;
            this.Musteri_Adi.Location = new System.Drawing.Point(147, 39);
            this.Musteri_Adi.Name = "Musteri_Adi";
            this.Musteri_Adi.Size = new System.Drawing.Size(125, 22);
            this.Musteri_Adi.TabIndex = 3;
            // 
            // MusteriDetayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(774, 309);
            this.Controls.Add(this.Musteri_Adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Goster);
            this.Controls.Add(this.Musteri_Detay_Grid);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MusteriDetayi";
            this.Text = "Müşteri Detayı";
            ((System.ComponentModel.ISupportInitialize)(this.Musteri_Detay_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Musteri_Detay_Grid;
        private System.Windows.Forms.Button Goster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Musteri_Adi;
    }
}