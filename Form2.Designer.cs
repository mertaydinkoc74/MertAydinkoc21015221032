namespace WindowsFormsApp1
{
    partial class Form2
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
            this.oyuncuId = new System.Windows.Forms.Label();
            this.oyuncuName = new System.Windows.Forms.Label();
            this.oyuncuMoney = new System.Windows.Forms.Label();
            this.oyuncuIDbox = new System.Windows.Forms.TextBox();
            this.oyuncuNameBox = new System.Windows.Forms.TextBox();
            this.OyuncuMoneyBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oyuncuId
            // 
            this.oyuncuId.AutoSize = true;
            this.oyuncuId.Location = new System.Drawing.Point(38, 16);
            this.oyuncuId.Name = "oyuncuId";
            this.oyuncuId.Size = new System.Drawing.Size(53, 13);
            this.oyuncuId.TabIndex = 0;
            this.oyuncuId.Text = "OyuncuId";
            // 
            // oyuncuName
            // 
            this.oyuncuName.AutoSize = true;
            this.oyuncuName.Location = new System.Drawing.Point(24, 42);
            this.oyuncuName.Name = "oyuncuName";
            this.oyuncuName.Size = new System.Drawing.Size(65, 13);
            this.oyuncuName.TabIndex = 1;
            this.oyuncuName.Text = "Oyuncu İsmi";
            // 
            // oyuncuMoney
            // 
            this.oyuncuMoney.AutoSize = true;
            this.oyuncuMoney.Location = new System.Drawing.Point(13, 68);
            this.oyuncuMoney.Name = "oyuncuMoney";
            this.oyuncuMoney.Size = new System.Drawing.Size(76, 13);
            this.oyuncuMoney.TabIndex = 2;
            this.oyuncuMoney.Text = "Oyuncu Parası";
            // 
            // oyuncuIDbox
            // 
            this.oyuncuIDbox.AcceptsReturn = true;
            this.oyuncuIDbox.Location = new System.Drawing.Point(101, 13);
            this.oyuncuIDbox.Name = "oyuncuIDbox";
            this.oyuncuIDbox.Size = new System.Drawing.Size(221, 20);
            this.oyuncuIDbox.TabIndex = 3;
            // 
            // oyuncuNameBox
            // 
            this.oyuncuNameBox.Location = new System.Drawing.Point(101, 39);
            this.oyuncuNameBox.Name = "oyuncuNameBox";
            this.oyuncuNameBox.Size = new System.Drawing.Size(221, 20);
            this.oyuncuNameBox.TabIndex = 4;
            // 
            // OyuncuMoneyBox
            // 
            this.OyuncuMoneyBox.Location = new System.Drawing.Point(101, 65);
            this.OyuncuMoneyBox.Name = "OyuncuMoneyBox";
            this.OyuncuMoneyBox.Size = new System.Drawing.Size(221, 20);
            this.OyuncuMoneyBox.TabIndex = 5;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(247, 124);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 50);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "İptal";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(166, 124);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 50);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "Tamam";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(329, 186);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OyuncuMoneyBox);
            this.Controls.Add(this.oyuncuNameBox);
            this.Controls.Add(this.oyuncuIDbox);
            this.Controls.Add(this.oyuncuMoney);
            this.Controls.Add(this.oyuncuName);
            this.Controls.Add(this.oyuncuId);
            this.Name = "Form2";
            this.Text = "Oyuncu Ekle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oyuncuId;
        private System.Windows.Forms.Label oyuncuName;
        private System.Windows.Forms.Label oyuncuMoney;
        private System.Windows.Forms.TextBox oyuncuIDbox;
        private System.Windows.Forms.TextBox oyuncuNameBox;
        private System.Windows.Forms.TextBox OyuncuMoneyBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Ok;
    }
}