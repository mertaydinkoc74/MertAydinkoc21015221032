namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.oyuncularBak = new System.Windows.Forms.Button();
            this.Urunler = new System.Windows.Forms.Button();
            this.Economy = new System.Windows.Forms.Button();
            this.Satislar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // oyuncularBak
            // 
            this.oyuncularBak.Location = new System.Drawing.Point(6, 6);
            this.oyuncularBak.Name = "oyuncularBak";
            this.oyuncularBak.Size = new System.Drawing.Size(111, 91);
            this.oyuncularBak.TabIndex = 0;
            this.oyuncularBak.Text = "Oyuncular";
            this.oyuncularBak.UseVisualStyleBackColor = true;
            this.oyuncularBak.Click += new System.EventHandler(this.oyuncularBak_Click);
            // 
            // Urunler
            // 
            this.Urunler.Location = new System.Drawing.Point(130, 6);
            this.Urunler.Name = "Urunler";
            this.Urunler.Size = new System.Drawing.Size(111, 91);
            this.Urunler.TabIndex = 1;
            this.Urunler.Text = "Ürünler";
            this.Urunler.UseVisualStyleBackColor = true;
            this.Urunler.Click += new System.EventHandler(this.Urunler_Click);
            // 
            // Economy
            // 
            this.Economy.Location = new System.Drawing.Point(130, 112);
            this.Economy.Name = "Economy";
            this.Economy.Size = new System.Drawing.Size(111, 91);
            this.Economy.TabIndex = 2;
            this.Economy.Text = "Ekonomi İşlemleri";
            this.Economy.UseVisualStyleBackColor = true;
            this.Economy.Click += new System.EventHandler(this.Economy_Click);
            // 
            // Satislar
            // 
            this.Satislar.Location = new System.Drawing.Point(6, 112);
            this.Satislar.Name = "Satislar";
            this.Satislar.Size = new System.Drawing.Size(111, 91);
            this.Satislar.TabIndex = 3;
            this.Satislar.Text = "Satışlar";
            this.Satislar.UseVisualStyleBackColor = true;
            this.Satislar.Click += new System.EventHandler(this.Satislar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 209);
            this.Controls.Add(this.Satislar);
            this.Controls.Add(this.Economy);
            this.Controls.Add(this.Urunler);
            this.Controls.Add(this.oyuncularBak);
            this.MaximumSize = new System.Drawing.Size(263, 248);
            this.MinimumSize = new System.Drawing.Size(263, 248);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Kontrol Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button oyuncularBak;
        private System.Windows.Forms.Button Urunler;
        private System.Windows.Forms.Button Economy;
        private System.Windows.Forms.Button Satislar;
    }
}

