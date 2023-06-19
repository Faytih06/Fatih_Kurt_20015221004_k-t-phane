namespace Fatih_Kurt_20015221004_kütüphane
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnÜyeEkle = new System.Windows.Forms.ToolStripButton();
            this.btnÜyeDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÜyeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnÜyeAra = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnKitapEkle = new System.Windows.Forms.ToolStripButton();
            this.btnKitapDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnKitapSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btnKitapAra = new System.Windows.Forms.ToolStripButton();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.toolStrip2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(759, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "KİTAPLAR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ÜYELER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(753, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÜyeEkle,
            this.btnÜyeDüzenle,
            this.btnÜyeSil,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.btnÜyeAra});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(753, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnÜyeEkle
            // 
            this.btnÜyeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnÜyeEkle.Image")));
            this.btnÜyeEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜyeEkle.Name = "btnÜyeEkle";
            this.btnÜyeEkle.Size = new System.Drawing.Size(60, 28);
            this.btnÜyeEkle.Text = "EKLE";
            this.btnÜyeEkle.Click += new System.EventHandler(this.btnÜyeEkle_Click);
            // 
            // btnÜyeDüzenle
            // 
            this.btnÜyeDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnÜyeDüzenle.Image")));
            this.btnÜyeDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜyeDüzenle.Name = "btnÜyeDüzenle";
            this.btnÜyeDüzenle.Size = new System.Drawing.Size(77, 28);
            this.btnÜyeDüzenle.Text = "Düzenle";
            this.btnÜyeDüzenle.Click += new System.EventHandler(this.btnÜyeDüzenle_Click);
            // 
            // btnÜyeSil
            // 
            this.btnÜyeSil.Image = ((System.Drawing.Image)(resources.GetObject("btnÜyeSil.Image")));
            this.btnÜyeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜyeSil.Name = "btnÜyeSil";
            this.btnÜyeSil.Size = new System.Drawing.Size(47, 28);
            this.btnÜyeSil.Text = "Sil";
            this.btnÜyeSil.Click += new System.EventHandler(this.btnÜyeSil_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 28);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 23);
            // 
            // btnÜyeAra
            // 
            this.btnÜyeAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnÜyeAra.Image = ((System.Drawing.Image)(resources.GetObject("btnÜyeAra.Image")));
            this.btnÜyeAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜyeAra.Name = "btnÜyeAra";
            this.btnÜyeAra.Size = new System.Drawing.Size(28, 28);
            this.btnÜyeAra.Text = "toolStripButton1";
            this.btnÜyeAra.Click += new System.EventHandler(this.btnÜyeAra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(753, 380);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 34);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(753, 402);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKitapEkle,
            this.btnKitapDüzenle,
            this.btnKitapSil,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.btnKitapAra});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(753, 31);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapEkle.Image")));
            this.btnKitapEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(60, 28);
            this.btnKitapEkle.Text = "EKLE";
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitapDüzenle
            // 
            this.btnKitapDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapDüzenle.Image")));
            this.btnKitapDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitapDüzenle.Name = "btnKitapDüzenle";
            this.btnKitapDüzenle.Size = new System.Drawing.Size(77, 28);
            this.btnKitapDüzenle.Text = "Düzenle";
            this.btnKitapDüzenle.Click += new System.EventHandler(this.btnKitapDüzenle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapSil.Image")));
            this.btnKitapSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(47, 28);
            this.btnKitapSil.Text = "Sil";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(28, 28);
            this.toolStripLabel2.Text = "Ara:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 23);
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKitapAra.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapAra.Image")));
            this.btnKitapAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(28, 28);
            this.btnKitapAra.Text = "toolStripButton1";
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 443);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(767, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 465);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "MİLLİ KÜTÜHANE";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnKitapEkle;
        private System.Windows.Forms.ToolStripButton btnKitapDüzenle;
        private System.Windows.Forms.ToolStripButton btnKitapSil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton btnKitapAra;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnÜyeEkle;
        private System.Windows.Forms.ToolStripButton btnÜyeDüzenle;
        private System.Windows.Forms.ToolStripButton btnÜyeSil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btnÜyeAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip2;
    }
}

