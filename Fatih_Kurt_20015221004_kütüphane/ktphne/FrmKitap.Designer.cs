namespace Fatih_Kurt_20015221004_kütüphane.ktphne
{
    partial class FrmKitap
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
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapYayın = new System.Windows.Forms.TextBox();
            this.cbKitapDil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKitapTür = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmSayfa = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(390, 346);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 8;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(309, 346);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 7;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kitap Dili";
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(255, 119);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(249, 20);
            this.txtKitapYazar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yazar";
            // 
            // txtKitapAD
            // 
            this.txtKitapAD.Location = new System.Drawing.Point(255, 71);
            this.txtKitapAD.Name = "txtKitapAD";
            this.txtKitapAD.Size = new System.Drawing.Size(249, 20);
            this.txtKitapAD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(255, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(249, 20);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yayın Evi";
            // 
            // txtKitapYayın
            // 
            this.txtKitapYayın.Location = new System.Drawing.Point(255, 164);
            this.txtKitapYayın.Name = "txtKitapYayın";
            this.txtKitapYayın.Size = new System.Drawing.Size(249, 20);
            this.txtKitapYayın.TabIndex = 3;
            // 
            // cbKitapDil
            // 
            this.cbKitapDil.FormattingEnabled = true;
            this.cbKitapDil.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce",
            "Fransızca ",
            "Arapça",
            "Almanca",
            "İtalyanca",
            "Rusça"});
            this.cbKitapDil.Location = new System.Drawing.Point(255, 213);
            this.cbKitapDil.Name = "cbKitapDil";
            this.cbKitapDil.Size = new System.Drawing.Size(249, 21);
            this.cbKitapDil.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kitap Türü";
            // 
            // cbKitapTür
            // 
            this.cbKitapTür.FormattingEnabled = true;
            this.cbKitapTür.Items.AddRange(new object[] {
            "Dünya Klasikleri",
            "Aşk",
            "Psikoloji",
            "Din",
            "Tarih",
            "Kişisel Gelişim",
            "Siyaset-Politika",
            "Korku-Gerilim",
            "Çocuk",
            "Macera-Aksiyon",
            "Şiir",
            "Polisiye",
            "Felsefe-Düşünce",
            "Edebiyat",
            "Bilim-Kurgu",
            "Sosyoloji",
            "Biyografi",
            "Araştırma-İnceleme",
            "Deneme-İnceleme",
            "Manga",
            "Sağlık-Tıp",
            "Masal",
            "Bilim-Teknoloji-Mühendislik",
            "Çizgi-Roman",
            "Mitolojiler",
            "Gezi"});
            this.cbKitapTür.Location = new System.Drawing.Point(255, 258);
            this.cbKitapTür.Name = "cbKitapTür";
            this.cbKitapTür.Size = new System.Drawing.Size(249, 21);
            this.cbKitapTür.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sayfa Sayısı";
            // 
            // nmSayfa
            // 
            this.nmSayfa.Location = new System.Drawing.Point(255, 302);
            this.nmSayfa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmSayfa.Name = "nmSayfa";
            this.nmSayfa.Size = new System.Drawing.Size(249, 20);
            this.nmSayfa.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmKitap
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(524, 396);
            this.Controls.Add(this.nmSayfa);
            this.Controls.Add(this.cbKitapTür);
            this.Controls.Add(this.cbKitapDil);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKitapYayın);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmKitap";
            this.Load += new System.EventHandler(this.FrmKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapYayın;
        private System.Windows.Forms.ComboBox cbKitapDil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKitapTür;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmSayfa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}