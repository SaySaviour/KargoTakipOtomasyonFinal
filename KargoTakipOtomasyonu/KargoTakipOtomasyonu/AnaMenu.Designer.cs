namespace KargoTakipOtomasyonu
{
    partial class AnaMenu
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
            this.PBilgiBtn = new System.Windows.Forms.Button();
            this.YBilgiBtn = new System.Windows.Forms.Button();
            this.ZBilgiBtn = new System.Windows.Forms.Button();
            this.TarihGostergeLabel = new System.Windows.Forms.Label();
            this.SaatGostergeLabel = new System.Windows.Forms.Label();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.SaatLabel = new System.Windows.Forms.Label();
            this.KargoBilgiBtn = new System.Windows.Forms.Button();
            this.KargoEkleBtn = new System.Windows.Forms.Button();
            this.KargoNerdeBtn = new System.Windows.Forms.Button();
            this.TeslmEdilmeyenKargoBtn = new System.Windows.Forms.Button();
            this.KullanicilarGroupbox = new System.Windows.Forms.GroupBox();
            this.KargoGroupBox = new System.Windows.Forms.GroupBox();
            this.KargomNerdeBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AyarlarToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OturumuKapatToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UygulamadanCikToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.KullanicilarToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UygulamayaGirisYapanKToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UygulamadanCikisYapanKToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HosgeldinizLabel = new System.Windows.Forms.Label();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.KullanicilarGroupbox.SuspendLayout();
            this.KargoGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBilgiBtn
            // 
            this.PBilgiBtn.Location = new System.Drawing.Point(18, 103);
            this.PBilgiBtn.Name = "PBilgiBtn";
            this.PBilgiBtn.Size = new System.Drawing.Size(145, 64);
            this.PBilgiBtn.TabIndex = 7;
            this.PBilgiBtn.Text = "PERSONEL BİLGİLERİ";
            this.PBilgiBtn.UseVisualStyleBackColor = true;
            this.PBilgiBtn.Click += new System.EventHandler(this.PBilgiBtn_Click);
            // 
            // YBilgiBtn
            // 
            this.YBilgiBtn.Location = new System.Drawing.Point(18, 33);
            this.YBilgiBtn.Name = "YBilgiBtn";
            this.YBilgiBtn.Size = new System.Drawing.Size(145, 64);
            this.YBilgiBtn.TabIndex = 6;
            this.YBilgiBtn.Text = "YÖNETİCİ BİLGİLERİ";
            this.YBilgiBtn.UseVisualStyleBackColor = true;
            this.YBilgiBtn.Click += new System.EventHandler(this.YBilgiBtn_Click);
            // 
            // ZBilgiBtn
            // 
            this.ZBilgiBtn.Location = new System.Drawing.Point(18, 173);
            this.ZBilgiBtn.Name = "ZBilgiBtn";
            this.ZBilgiBtn.Size = new System.Drawing.Size(145, 64);
            this.ZBilgiBtn.TabIndex = 8;
            this.ZBilgiBtn.Text = "ZİYARETÇİ BİLGİLERİ";
            this.ZBilgiBtn.UseVisualStyleBackColor = true;
            this.ZBilgiBtn.Click += new System.EventHandler(this.ZBilgiBtn_Click);
            // 
            // TarihGostergeLabel
            // 
            this.TarihGostergeLabel.AutoSize = true;
            this.TarihGostergeLabel.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihGostergeLabel.Location = new System.Drawing.Point(425, 31);
            this.TarihGostergeLabel.Name = "TarihGostergeLabel";
            this.TarihGostergeLabel.Size = new System.Drawing.Size(49, 15);
            this.TarihGostergeLabel.TabIndex = 3;
            this.TarihGostergeLabel.Text = "TARİH:";
            // 
            // SaatGostergeLabel
            // 
            this.SaatGostergeLabel.AutoSize = true;
            this.SaatGostergeLabel.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatGostergeLabel.Location = new System.Drawing.Point(430, 67);
            this.SaatGostergeLabel.Name = "SaatGostergeLabel";
            this.SaatGostergeLabel.Size = new System.Drawing.Size(42, 15);
            this.SaatGostergeLabel.TabIndex = 3;
            this.SaatGostergeLabel.Text = "SAAT:";
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihLabel.Location = new System.Drawing.Point(480, 31);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(42, 14);
            this.TarihLabel.TabIndex = 3;
            this.TarihLabel.Text = "TARİH";
            // 
            // SaatLabel
            // 
            this.SaatLabel.AutoSize = true;
            this.SaatLabel.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatLabel.Location = new System.Drawing.Point(487, 68);
            this.SaatLabel.Name = "SaatLabel";
            this.SaatLabel.Size = new System.Drawing.Size(35, 14);
            this.SaatLabel.TabIndex = 3;
            this.SaatLabel.Text = "SAAT";
            // 
            // KargoBilgiBtn
            // 
            this.KargoBilgiBtn.Location = new System.Drawing.Point(18, 29);
            this.KargoBilgiBtn.Name = "KargoBilgiBtn";
            this.KargoBilgiBtn.Size = new System.Drawing.Size(145, 64);
            this.KargoBilgiBtn.TabIndex = 1;
            this.KargoBilgiBtn.Text = "KARGO BİLGİLERİ";
            this.KargoBilgiBtn.UseVisualStyleBackColor = true;
            this.KargoBilgiBtn.Click += new System.EventHandler(this.KargoBilgiBtn_Click);
            // 
            // KargoEkleBtn
            // 
            this.KargoEkleBtn.Location = new System.Drawing.Point(180, 29);
            this.KargoEkleBtn.Name = "KargoEkleBtn";
            this.KargoEkleBtn.Size = new System.Drawing.Size(145, 64);
            this.KargoEkleBtn.TabIndex = 2;
            this.KargoEkleBtn.Text = "YENİ KARGO EKLE";
            this.KargoEkleBtn.UseVisualStyleBackColor = true;
            this.KargoEkleBtn.Click += new System.EventHandler(this.KargoEkleBtn_Click);
            // 
            // KargoNerdeBtn
            // 
            this.KargoNerdeBtn.Location = new System.Drawing.Point(18, 119);
            this.KargoNerdeBtn.Name = "KargoNerdeBtn";
            this.KargoNerdeBtn.Size = new System.Drawing.Size(145, 64);
            this.KargoNerdeBtn.TabIndex = 3;
            this.KargoNerdeBtn.Text = "KARGO DURUMU";
            this.KargoNerdeBtn.UseVisualStyleBackColor = true;
            this.KargoNerdeBtn.Click += new System.EventHandler(this.KargoNerdeBtn_Click);
            // 
            // TeslmEdilmeyenKargoBtn
            // 
            this.TeslmEdilmeyenKargoBtn.Location = new System.Drawing.Point(180, 119);
            this.TeslmEdilmeyenKargoBtn.Name = "TeslmEdilmeyenKargoBtn";
            this.TeslmEdilmeyenKargoBtn.Size = new System.Drawing.Size(145, 64);
            this.TeslmEdilmeyenKargoBtn.TabIndex = 4;
            this.TeslmEdilmeyenKargoBtn.Text = "TESLİM EDİLMEYEN KARGOLAR";
            this.TeslmEdilmeyenKargoBtn.UseVisualStyleBackColor = true;
            this.TeslmEdilmeyenKargoBtn.Click += new System.EventHandler(this.TeslmEdilmeyenKargoBtn_Click);
            // 
            // KullanicilarGroupbox
            // 
            this.KullanicilarGroupbox.Controls.Add(this.PBilgiBtn);
            this.KullanicilarGroupbox.Controls.Add(this.YBilgiBtn);
            this.KullanicilarGroupbox.Controls.Add(this.ZBilgiBtn);
            this.KullanicilarGroupbox.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanicilarGroupbox.Location = new System.Drawing.Point(377, 112);
            this.KullanicilarGroupbox.Name = "KullanicilarGroupbox";
            this.KullanicilarGroupbox.Size = new System.Drawing.Size(182, 264);
            this.KullanicilarGroupbox.TabIndex = 4;
            this.KullanicilarGroupbox.TabStop = false;
            this.KullanicilarGroupbox.Text = "KULLANICILAR";
            // 
            // KargoGroupBox
            // 
            this.KargoGroupBox.Controls.Add(this.KargomNerdeBtn);
            this.KargoGroupBox.Controls.Add(this.TeslmEdilmeyenKargoBtn);
            this.KargoGroupBox.Controls.Add(this.KargoBilgiBtn);
            this.KargoGroupBox.Controls.Add(this.KargoEkleBtn);
            this.KargoGroupBox.Controls.Add(this.KargoNerdeBtn);
            this.KargoGroupBox.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KargoGroupBox.Location = new System.Drawing.Point(12, 112);
            this.KargoGroupBox.Name = "KargoGroupBox";
            this.KargoGroupBox.Size = new System.Drawing.Size(339, 264);
            this.KargoGroupBox.TabIndex = 5;
            this.KargoGroupBox.TabStop = false;
            this.KargoGroupBox.Text = "KARGO";
            // 
            // KargomNerdeBtn
            // 
            this.KargomNerdeBtn.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KargomNerdeBtn.Location = new System.Drawing.Point(104, 189);
            this.KargomNerdeBtn.Name = "KargomNerdeBtn";
            this.KargomNerdeBtn.Size = new System.Drawing.Size(145, 64);
            this.KargomNerdeBtn.TabIndex = 5;
            this.KargomNerdeBtn.Text = "KARGOM NEREDE ?";
            this.KargomNerdeBtn.UseVisualStyleBackColor = true;
            this.KargomNerdeBtn.Click += new System.EventHandler(this.KargomNerdeBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyarlarToolStripMenu,
            this.KullanicilarToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AyarlarToolStripMenu
            // 
            this.AyarlarToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OturumuKapatToolStripMenu,
            this.UygulamadanCikToolStripMenu});
            this.AyarlarToolStripMenu.Name = "AyarlarToolStripMenu";
            this.AyarlarToolStripMenu.Size = new System.Drawing.Size(56, 20);
            this.AyarlarToolStripMenu.Text = "Ayarlar";
            // 
            // OturumuKapatToolStripMenu
            // 
            this.OturumuKapatToolStripMenu.Name = "OturumuKapatToolStripMenu";
            this.OturumuKapatToolStripMenu.Size = new System.Drawing.Size(168, 22);
            this.OturumuKapatToolStripMenu.Text = "Oturumu Kapat";
            this.OturumuKapatToolStripMenu.Click += new System.EventHandler(this.OturumuKapatToolStripMenu_Click);
            // 
            // UygulamadanCikToolStripMenu
            // 
            this.UygulamadanCikToolStripMenu.Name = "UygulamadanCikToolStripMenu";
            this.UygulamadanCikToolStripMenu.Size = new System.Drawing.Size(168, 22);
            this.UygulamadanCikToolStripMenu.Text = "Uygulamadan Çık";
            this.UygulamadanCikToolStripMenu.Click += new System.EventHandler(this.UygulamadanCikToolStripMenu_Click);
            // 
            // KullanicilarToolStripMenu
            // 
            this.KullanicilarToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UygulamayaGirisYapanKToolStripMenu,
            this.UygulamadanCikisYapanKToolStripMenu});
            this.KullanicilarToolStripMenu.Name = "KullanicilarToolStripMenu";
            this.KullanicilarToolStripMenu.Size = new System.Drawing.Size(77, 20);
            this.KullanicilarToolStripMenu.Text = "Kullanıcılar";
            // 
            // UygulamayaGirisYapanKToolStripMenu
            // 
            this.UygulamayaGirisYapanKToolStripMenu.Name = "UygulamayaGirisYapanKToolStripMenu";
            this.UygulamayaGirisYapanKToolStripMenu.Size = new System.Drawing.Size(272, 22);
            this.UygulamayaGirisYapanKToolStripMenu.Text = "Uygulamaya Giriş Yapan Kullanıcılar";
            this.UygulamayaGirisYapanKToolStripMenu.Click += new System.EventHandler(this.UygulamayaGirisYapanKToolStripMenu_Click);
            // 
            // UygulamadanCikisYapanKToolStripMenu
            // 
            this.UygulamadanCikisYapanKToolStripMenu.Name = "UygulamadanCikisYapanKToolStripMenu";
            this.UygulamadanCikisYapanKToolStripMenu.Size = new System.Drawing.Size(272, 22);
            this.UygulamadanCikisYapanKToolStripMenu.Text = "Uygulamadan Çıkış Yapan Kullanıcılar";
            this.UygulamadanCikisYapanKToolStripMenu.Click += new System.EventHandler(this.UygulamadanCikisYapanKToolStripMenu_Click);
            // 
            // HosgeldinizLabel
            // 
            this.HosgeldinizLabel.AutoSize = true;
            this.HosgeldinizLabel.BackColor = System.Drawing.Color.Black;
            this.HosgeldinizLabel.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HosgeldinizLabel.ForeColor = System.Drawing.Color.Yellow;
            this.HosgeldinizLabel.Location = new System.Drawing.Point(63, 58);
            this.HosgeldinizLabel.Name = "HosgeldinizLabel";
            this.HosgeldinizLabel.Size = new System.Drawing.Size(198, 39);
            this.HosgeldinizLabel.TabIndex = 7;
            this.HosgeldinizLabel.Text = "Hoşgeldiniz";
            // 
            // zaman
            // 
            this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(589, 388);
            this.ControlBox = false;
            this.Controls.Add(this.HosgeldinizLabel);
            this.Controls.Add(this.KargoGroupBox);
            this.Controls.Add(this.KullanicilarGroupbox);
            this.Controls.Add(this.SaatLabel);
            this.Controls.Add(this.SaatGostergeLabel);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.TarihGostergeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.KullanicilarGroupbox.ResumeLayout(false);
            this.KargoGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TarihGostergeLabel;
        private System.Windows.Forms.Label SaatGostergeLabel;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Label SaatLabel;
        private System.Windows.Forms.GroupBox KullanicilarGroupbox;
        private System.Windows.Forms.GroupBox KargoGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AyarlarToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OturumuKapatToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem UygulamadanCikToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem KullanicilarToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem UygulamayaGirisYapanKToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem UygulamadanCikisYapanKToolStripMenu;
        private System.Windows.Forms.Label HosgeldinizLabel;
        private System.Windows.Forms.Timer zaman;
        public System.Windows.Forms.Button PBilgiBtn;
        public System.Windows.Forms.Button YBilgiBtn;
        public System.Windows.Forms.Button ZBilgiBtn;
        public System.Windows.Forms.Button KargoBilgiBtn;
        public System.Windows.Forms.Button KargoEkleBtn;
        public System.Windows.Forms.Button KargoNerdeBtn;
        public System.Windows.Forms.Button TeslmEdilmeyenKargoBtn;
        public System.Windows.Forms.Button KargomNerdeBtn;
    }
}