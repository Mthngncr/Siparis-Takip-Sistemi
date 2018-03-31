namespace WindowsFormsApplication1
{
    partial class UrunDetayi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunDetayi));
            this.Urun_Detayi_Grid = new System.Windows.Forms.DataGridView();
            this.Goster = new System.Windows.Forms.Button();
            this.Urun_Adi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Urun_Detayi_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Urun_Detayi_Grid
            // 
            this.Urun_Detayi_Grid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.Urun_Detayi_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Urun_Detayi_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Urun_Detayi_Grid.Location = new System.Drawing.Point(79, 269);
            this.Urun_Detayi_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Urun_Detayi_Grid.Name = "Urun_Detayi_Grid";
            this.Urun_Detayi_Grid.Size = new System.Drawing.Size(458, 132);
            this.Urun_Detayi_Grid.TabIndex = 0;
            // 
            // Goster
            // 
            this.Goster.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Goster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Goster.Location = new System.Drawing.Point(425, 108);
            this.Goster.Margin = new System.Windows.Forms.Padding(4);
            this.Goster.Name = "Goster";
            this.Goster.Size = new System.Drawing.Size(112, 32);
            this.Goster.TabIndex = 1;
            this.Goster.Text = "Göster";
            this.Goster.UseVisualStyleBackColor = false;
            this.Goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // Urun_Adi
            // 
            this.Urun_Adi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Urun_Adi.Location = new System.Drawing.Point(79, 108);
            this.Urun_Adi.Margin = new System.Windows.Forms.Padding(4);
            this.Urun_Adi.Name = "Urun_Adi";
            this.Urun_Adi.Size = new System.Drawing.Size(278, 25);
            this.Urun_Adi.TabIndex = 2;
            this.Urun_Adi.Text = "Ürün Adı Giriniz...";
            // 
            // UrunDetayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 485);
            this.Controls.Add(this.Urun_Adi);
            this.Controls.Add(this.Goster);
            this.Controls.Add(this.Urun_Detayi_Grid);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunDetayi";
            this.Text = "Ürün Detayı";
            ((System.ComponentModel.ISupportInitialize)(this.Urun_Detayi_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Urun_Detayi_Grid;
        private System.Windows.Forms.Button Goster;
        private System.Windows.Forms.TextBox Urun_Adi;
    }
}