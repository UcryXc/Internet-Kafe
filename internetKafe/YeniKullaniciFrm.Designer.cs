namespace internetKafe
{
    partial class YeniKullaniciFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKullaniciFrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciTxtBox = new System.Windows.Forms.TextBox();
            this.sifreTxtBox = new System.Windows.Forms.TextBox();
            this.verileriGosterBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(228, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1032, 241);
            this.dataGridView1.TabIndex = 3;
            // 
            // kullaniciTxtBox
            // 
            this.kullaniciTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTxtBox.Location = new System.Drawing.Point(401, 111);
            this.kullaniciTxtBox.Name = "kullaniciTxtBox";
            this.kullaniciTxtBox.Size = new System.Drawing.Size(155, 29);
            this.kullaniciTxtBox.TabIndex = 4;
            // 
            // sifreTxtBox
            // 
            this.sifreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxtBox.Location = new System.Drawing.Point(401, 187);
            this.sifreTxtBox.Name = "sifreTxtBox";
            this.sifreTxtBox.Size = new System.Drawing.Size(155, 29);
            this.sifreTxtBox.TabIndex = 5;
            // 
            // verileriGosterBtn
            // 
            this.verileriGosterBtn.BackColor = System.Drawing.Color.Transparent;
            this.verileriGosterBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.verileriGosterBtn.FlatAppearance.BorderSize = 2;
            this.verileriGosterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verileriGosterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verileriGosterBtn.Location = new System.Drawing.Point(12, 293);
            this.verileriGosterBtn.Name = "verileriGosterBtn";
            this.verileriGosterBtn.Size = new System.Drawing.Size(148, 45);
            this.verileriGosterBtn.TabIndex = 6;
            this.verileriGosterBtn.Text = "Verileri Göster";
            this.verileriGosterBtn.UseVisualStyleBackColor = false;
            this.verileriGosterBtn.Click += new System.EventHandler(this.verileriGosterBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.Transparent;
            this.kaydetBtn.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.kaydetBtn.FlatAppearance.BorderSize = 2;
            this.kaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetBtn.Location = new System.Drawing.Point(175, 293);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(148, 45);
            this.kaydetBtn.TabIndex = 7;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Transparent;
            this.silBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.silBtn.FlatAppearance.BorderSize = 2;
            this.silBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Location = new System.Drawing.Point(329, 293);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(148, 45);
            this.silBtn.TabIndex = 8;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // YeniKullaniciFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 597);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.verileriGosterBtn);
            this.Controls.Add(this.sifreTxtBox);
            this.Controls.Add(this.kullaniciTxtBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YeniKullaniciFrm";
            this.Text = "YeniKullaniciFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kullaniciTxtBox;
        private System.Windows.Forms.TextBox sifreTxtBox;
        private System.Windows.Forms.Button verileriGosterBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button silBtn;
    }
}