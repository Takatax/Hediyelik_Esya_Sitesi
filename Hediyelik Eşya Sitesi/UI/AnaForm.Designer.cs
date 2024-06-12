using System;

namespace Hediyelik_Eşya_Sitesi
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMüşteriler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnÜrünler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatışYap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnÖdemeYap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSatışDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSatışSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatışBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnÖdemeDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÖdemeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnÖdemeBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüşteriler,
            this.toolStripSeparator1,
            this.btnÜrünler,
            this.toolStripSeparator2,
            this.btnSatışYap,
            this.toolStripSeparator3,
            this.btnÖdemeYap,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 43);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMüşteriler
            // 
            this.btnMüşteriler.Image = ((System.Drawing.Image)(resources.GetObject("btnMüşteriler.Image")));
            this.btnMüşteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriler.Name = "btnMüşteriler";
            this.btnMüşteriler.Size = new System.Drawing.Size(133, 40);
            this.btnMüşteriler.Text = "MÜŞTERİLER";
            this.btnMüşteriler.Click += new System.EventHandler(this.btnMüşteriler_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnÜrünler
            // 
            this.btnÜrünler.Image = ((System.Drawing.Image)(resources.GetObject("btnÜrünler.Image")));
            this.btnÜrünler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünler.Name = "btnÜrünler";
            this.btnÜrünler.Size = new System.Drawing.Size(113, 40);
            this.btnÜrünler.Text = "ÜRÜNLER";
            this.btnÜrünler.Click += new System.EventHandler(this.btnÜrünler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışYap.Image")));
            this.btnSatışYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(115, 40);
            this.btnSatışYap.Text = "SATIŞ YAP";
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnÖdemeYap
            // 
            this.btnÖdemeYap.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeYap.Image")));
            this.btnÖdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeYap.Name = "btnÖdemeYap";
            this.btnÖdemeYap.Size = new System.Drawing.Size(129, 40);
            this.btnÖdemeYap.Text = "ÖDEME YAP";
            this.btnÖdemeYap.Click += new System.EventHandler(this.btnÖdemeYap_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 406);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SATIŞLAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 340);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSatışDüzenle,
            this.toolStripSeparator7,
            this.btnSatışSil,
            this.toolStripSeparator5,
            this.btnSatışBul,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(783, 31);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSatışDüzenle
            // 
            this.btnSatışDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışDüzenle.Image")));
            this.btnSatışDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışDüzenle.Name = "btnSatışDüzenle";
            this.btnSatışDüzenle.Size = new System.Drawing.Size(91, 28);
            this.btnSatışDüzenle.Text = "Düzenle";
            this.btnSatışDüzenle.Click += new System.EventHandler(this.btnSatışDüzenle_Click);
            // 
            // btnSatışSil
            // 
            this.btnSatışSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışSil.Image")));
            this.btnSatışSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışSil.Name = "btnSatışSil";
            this.btnSatışSil.Size = new System.Drawing.Size(53, 28);
            this.btnSatışSil.Text = "Sil";
            this.btnSatışSil.Click += new System.EventHandler(this.btnSatışSil_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSatışBul
            // 
            this.btnSatışBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSatışBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSatışBul.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışBul.Image")));
            this.btnSatışBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışBul.Name = "btnSatışBul";
            this.btnSatışBul.Size = new System.Drawing.Size(29, 28);
            this.btnSatışBul.Text = "Bul";
            this.btnSatışBul.Click += new System.EventHandler(this.btnSatışBul_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÖDEMELER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 34);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(783, 340);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÖdemeDüzenle,
            this.toolStripSeparator8,
            this.btnÖdemeSil,
            this.toolStripSeparator6,
            this.btnÖdemeBul,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(783, 31);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnÖdemeDüzenle
            // 
            this.btnÖdemeDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeDüzenle.Image")));
            this.btnÖdemeDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeDüzenle.Name = "btnÖdemeDüzenle";
            this.btnÖdemeDüzenle.Size = new System.Drawing.Size(91, 28);
            this.btnÖdemeDüzenle.Text = "Düzenle";
            this.btnÖdemeDüzenle.Click += new System.EventHandler(this.btnÖdemeDüzenle_Click);
            // 
            // btnÖdemeSil
            // 
            this.btnÖdemeSil.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeSil.Image")));
            this.btnÖdemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeSil.Name = "btnÖdemeSil";
            this.btnÖdemeSil.Size = new System.Drawing.Size(53, 28);
            this.btnÖdemeSil.Text = "Sil";
            this.btnÖdemeSil.Click += new System.EventHandler(this.btnÖdemeSil_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // btnÖdemeBul
            // 
            this.btnÖdemeBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnÖdemeBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnÖdemeBul.Image = ((System.Drawing.Image)(resources.GetObject("btnÖdemeBul.Image")));
            this.btnÖdemeBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeBul.Name = "btnÖdemeBul";
            this.btnÖdemeBul.Size = new System.Drawing.Size(29, 28);
            this.btnÖdemeBul.Text = "Bul";
            this.btnÖdemeBul.Click += new System.EventHandler(this.btnÖdemeBul_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel2.Text = "Ara:";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 471);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "AnaForm";
            this.Text = "Hediyelik Eşya Sitesi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriler;
        private System.Windows.Forms.ToolStripButton btnÜrünler;
        private System.Windows.Forms.ToolStripButton btnSatışYap;
        private System.Windows.Forms.ToolStripButton btnÖdemeYap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSatışDüzenle;
        private System.Windows.Forms.ToolStripButton btnSatışSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSatışBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnÖdemeDüzenle;
        private System.Windows.Forms.ToolStripButton btnÖdemeSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnÖdemeBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}

