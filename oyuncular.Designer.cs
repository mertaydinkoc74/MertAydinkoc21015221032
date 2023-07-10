namespace WindowsFormsApp1
{
    partial class oyuncular
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "asfasfasf",
            "asfasfasf",
            "asfasfasf"}, -1);
            this.oyuncuEkle = new System.Windows.Forms.Button();
            this.oyunculiste = new System.Windows.Forms.ListView();
            this.oyuncuId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oyuncuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oyuncuMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oyuncuUpdate = new System.Windows.Forms.Button();
            this.oyuncuDelete = new System.Windows.Forms.Button();
            this.oyuncuBul = new System.Windows.Forms.Button();
            this.oyuncuAll = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oyuncuEkle
            // 
            this.oyuncuEkle.Location = new System.Drawing.Point(107, 12);
            this.oyuncuEkle.Name = "oyuncuEkle";
            this.oyuncuEkle.Size = new System.Drawing.Size(89, 71);
            this.oyuncuEkle.TabIndex = 0;
            this.oyuncuEkle.Text = "Oyuncu Ekle";
            this.oyuncuEkle.UseVisualStyleBackColor = true;
            this.oyuncuEkle.Click += new System.EventHandler(this.oyuncuEkle_Click);
            // 
            // oyunculiste
            // 
            this.oyunculiste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oyunculiste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oyuncuId,
            this.oyuncuName,
            this.oyuncuMoney});
            this.oyunculiste.FullRowSelect = true;
            this.oyunculiste.HideSelection = false;
            this.oyunculiste.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.oyunculiste.Location = new System.Drawing.Point(13, 91);
            this.oyunculiste.MultiSelect = false;
            this.oyunculiste.Name = "oyunculiste";
            this.oyunculiste.Scrollable = false;
            this.oyunculiste.Size = new System.Drawing.Size(775, 347);
            this.oyunculiste.TabIndex = 1;
            this.oyunculiste.UseCompatibleStateImageBehavior = false;
            this.oyunculiste.View = System.Windows.Forms.View.Details;
            // 
            // oyuncuId
            // 
            this.oyuncuId.Text = "oyuncuID";
            this.oyuncuId.Width = 246;
            // 
            // oyuncuName
            // 
            this.oyuncuName.Text = "Oyuncu İsmi";
            this.oyuncuName.Width = 260;
            // 
            // oyuncuMoney
            // 
            this.oyuncuMoney.Text = "Oyuncu Parası";
            this.oyuncuMoney.Width = 799;
            // 
            // oyuncuUpdate
            // 
            this.oyuncuUpdate.Location = new System.Drawing.Point(202, 12);
            this.oyuncuUpdate.Name = "oyuncuUpdate";
            this.oyuncuUpdate.Size = new System.Drawing.Size(97, 71);
            this.oyuncuUpdate.TabIndex = 2;
            this.oyuncuUpdate.Text = "Oyuncu Güncelle";
            this.oyuncuUpdate.UseVisualStyleBackColor = true;
            this.oyuncuUpdate.Click += new System.EventHandler(this.oyuncuUpdate_Click);
            // 
            // oyuncuDelete
            // 
            this.oyuncuDelete.Location = new System.Drawing.Point(305, 12);
            this.oyuncuDelete.Name = "oyuncuDelete";
            this.oyuncuDelete.Size = new System.Drawing.Size(89, 71);
            this.oyuncuDelete.TabIndex = 3;
            this.oyuncuDelete.Text = "Oyuncu Sil";
            this.oyuncuDelete.UseVisualStyleBackColor = true;
            this.oyuncuDelete.Click += new System.EventHandler(this.oyuncuDelete_Click);
            // 
            // oyuncuBul
            // 
            this.oyuncuBul.Location = new System.Drawing.Point(400, 12);
            this.oyuncuBul.Name = "oyuncuBul";
            this.oyuncuBul.Size = new System.Drawing.Size(89, 71);
            this.oyuncuBul.TabIndex = 4;
            this.oyuncuBul.Text = "Oyuncu Bul";
            this.oyuncuBul.UseVisualStyleBackColor = true;
            this.oyuncuBul.Click += new System.EventHandler(this.oyuncuBul_Click);
            // 
            // oyuncuAll
            // 
            this.oyuncuAll.Location = new System.Drawing.Point(12, 12);
            this.oyuncuAll.Name = "oyuncuAll";
            this.oyuncuAll.Size = new System.Drawing.Size(89, 71);
            this.oyuncuAll.TabIndex = 5;
            this.oyuncuAll.Text = "Oyuncular";
            this.oyuncuAll.UseVisualStyleBackColor = true;
            this.oyuncuAll.Click += new System.EventHandler(this.oyuncuAll_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(699, 12);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 71);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "İptal";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(604, 14);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(89, 71);
            this.Save.TabIndex = 7;
            this.Save.Text = "Kaydet";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // oyuncular
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.oyuncuAll);
            this.Controls.Add(this.oyuncuBul);
            this.Controls.Add(this.oyuncuDelete);
            this.Controls.Add(this.oyuncuUpdate);
            this.Controls.Add(this.oyunculiste);
            this.Controls.Add(this.oyuncuEkle);
            this.Name = "oyuncular";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.oyuncular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oyuncuEkle;
        private System.Windows.Forms.ListView oyunculiste;
        private System.Windows.Forms.ColumnHeader oyuncuId;
        private System.Windows.Forms.ColumnHeader oyuncuName;
        private System.Windows.Forms.ColumnHeader oyuncuMoney;
        private System.Windows.Forms.Button oyuncuUpdate;
        private System.Windows.Forms.Button oyuncuDelete;
        private System.Windows.Forms.Button oyuncuBul;
        private System.Windows.Forms.Button oyuncuAll;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}