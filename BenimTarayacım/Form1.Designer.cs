namespace BenimTarayacım
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
            this.panelAdres = new System.Windows.Forms.Panel();
            this.panelıcerik = new System.Windows.Forms.Panel();
            this.panelgecmış = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btngit = new System.Windows.Forms.Button();
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnileri = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btngecmiş = new System.Windows.Forms.Button();
            this.panelAdres.SuspendLayout();
            this.panelıcerik.SuspendLayout();
            this.panelgecmış.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdres
            // 
            this.panelAdres.Controls.Add(this.btngecmiş);
            this.panelAdres.Controls.Add(this.btnyenile);
            this.panelAdres.Controls.Add(this.btnileri);
            this.panelAdres.Controls.Add(this.btngeri);
            this.panelAdres.Controls.Add(this.btnanasayfa);
            this.panelAdres.Controls.Add(this.btngit);
            this.panelAdres.Controls.Add(this.txtAdres);
            this.panelAdres.Controls.Add(this.label1);
            this.panelAdres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdres.Location = new System.Drawing.Point(0, 0);
            this.panelAdres.Name = "panelAdres";
            this.panelAdres.Size = new System.Drawing.Size(800, 46);
            this.panelAdres.TabIndex = 0;
            // 
            // panelıcerik
            // 
            this.panelıcerik.Controls.Add(this.webBrowser1);
            this.panelıcerik.Controls.Add(this.panelgecmış);
            this.panelıcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelıcerik.Location = new System.Drawing.Point(0, 46);
            this.panelıcerik.Name = "panelıcerik";
            this.panelıcerik.Size = new System.Drawing.Size(800, 404);
            this.panelıcerik.TabIndex = 1;
            // 
            // panelgecmış
            // 
            this.panelgecmış.Controls.Add(this.listBox1);
            this.panelgecmış.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelgecmış.Location = new System.Drawing.Point(665, 0);
            this.panelgecmış.Name = "panelgecmış";
            this.panelgecmış.Size = new System.Drawing.Size(135, 404);
            this.panelgecmış.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(54, 13);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(339, 20);
            this.txtAdres.TabIndex = 1;
            // 
            // btngit
            // 
            this.btngit.Location = new System.Drawing.Point(399, 13);
            this.btngit.Name = "btngit";
            this.btngit.Size = new System.Drawing.Size(52, 23);
            this.btngit.TabIndex = 2;
            this.btngit.Text = "GİT";
            this.btngit.UseVisualStyleBackColor = true;
            this.btngit.Click += new System.EventHandler(this.btngit_Click);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Location = new System.Drawing.Point(457, 13);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnanasayfa.TabIndex = 3;
            this.btnanasayfa.Text = "ANA SAYFA";
            this.btnanasayfa.UseVisualStyleBackColor = true;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(538, 13);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(49, 23);
            this.btngeri.TabIndex = 4;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnileri
            // 
            this.btnileri.Location = new System.Drawing.Point(593, 13);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(52, 23);
            this.btnileri.TabIndex = 5;
            this.btnileri.Text = "İLERİ";
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.Location = new System.Drawing.Point(651, 13);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(57, 23);
            this.btnyenile.TabIndex = 6;
            this.btnyenile.Text = "YENİLE";
            this.btnyenile.UseVisualStyleBackColor = true;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(665, 404);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 404);
            this.listBox1.TabIndex = 0;
            // 
            // btngecmiş
            // 
            this.btngecmiş.Location = new System.Drawing.Point(714, 13);
            this.btngecmiş.Name = "btngecmiş";
            this.btngecmiş.Size = new System.Drawing.Size(74, 23);
            this.btngecmiş.TabIndex = 7;
            this.btngecmiş.Text = "GEÇMİŞ";
            this.btngecmiş.UseVisualStyleBackColor = true;
            this.btngecmiş.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelıcerik);
            this.Controls.Add(this.panelAdres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelAdres.ResumeLayout(false);
            this.panelAdres.PerformLayout();
            this.panelıcerik.ResumeLayout(false);
            this.panelgecmış.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdres;
        private System.Windows.Forms.Panel panelıcerik;
        private System.Windows.Forms.Panel panelgecmış;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnanasayfa;
        private System.Windows.Forms.Button btngit;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btngecmiş;
    }
}

