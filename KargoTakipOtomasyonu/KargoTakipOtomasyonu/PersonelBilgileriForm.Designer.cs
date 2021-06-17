namespace KargoTakipOtomasyonu
{
    partial class PersonelBilgileriForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PAS_Sil_Btn = new System.Windows.Forms.Button();
            this.PAS_ID_Sil_TxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PAS_Ad_TxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PAS_TC_TxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PAS_Prsnl_ID_TxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PEG_Guncelle_Btn = new System.Windows.Forms.Button();
            this.PEG_Ekle_Btn = new System.Windows.Forms.Button();
            this.PEG_YeniK_Btn = new System.Windows.Forms.Button();
            this.PEG_Gorev_TxtBx = new System.Windows.Forms.ComboBox();
            this.PEG_Adres_TxtBx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PEG_Tel_TxtBx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PEG_Soyad_TxtBx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PEG_Ad_TxtBx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PEG_Sifre_TxtBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PEG_KAdi_TxtBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PEG_TC_TxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PEG_ID_TxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Personel_Listele_DataGridView = new System.Windows.Forms.DataGridView();
            this.Kapat_Btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Personel_Listele_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(13, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Arama-Silme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PAS_Sil_Btn);
            this.groupBox2.Controls.Add(this.PAS_ID_Sil_TxtBx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sil";
            // 
            // PAS_Sil_Btn
            // 
            this.PAS_Sil_Btn.Location = new System.Drawing.Point(207, 127);
            this.PAS_Sil_Btn.Name = "PAS_Sil_Btn";
            this.PAS_Sil_Btn.Size = new System.Drawing.Size(83, 43);
            this.PAS_Sil_Btn.TabIndex = 4;
            this.PAS_Sil_Btn.Text = "Sil";
            this.PAS_Sil_Btn.UseVisualStyleBackColor = true;
            this.PAS_Sil_Btn.Click += new System.EventHandler(this.PAS_Sil_Btn_Click);
            // 
            // PAS_ID_Sil_TxtBx
            // 
            this.PAS_ID_Sil_TxtBx.Location = new System.Drawing.Point(167, 89);
            this.PAS_ID_Sil_TxtBx.MaxLength = 11;
            this.PAS_ID_Sil_TxtBx.Name = "PAS_ID_Sil_TxtBx";
            this.PAS_ID_Sil_TxtBx.Size = new System.Drawing.Size(157, 22);
            this.PAS_ID_Sil_TxtBx.TabIndex = 3;
            this.PAS_ID_Sil_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PAS_ID_Sil_TxtBx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel TC Kimlik Numarası Giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PAS_Ad_TxtBx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PAS_TC_TxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PAS_Prsnl_ID_TxtBx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 331);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // PAS_Ad_TxtBx
            // 
            this.PAS_Ad_TxtBx.Location = new System.Drawing.Point(147, 271);
            this.PAS_Ad_TxtBx.Name = "PAS_Ad_TxtBx";
            this.PAS_Ad_TxtBx.Size = new System.Drawing.Size(209, 22);
            this.PAS_Ad_TxtBx.TabIndex = 2;
            this.PAS_Ad_TxtBx.TextChanged += new System.EventHandler(this.PAS_Ad_TxtBx_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Personel Ad Giriniz";
            // 
            // PAS_TC_TxtBx
            // 
            this.PAS_TC_TxtBx.Location = new System.Drawing.Point(147, 169);
            this.PAS_TC_TxtBx.MaxLength = 11;
            this.PAS_TC_TxtBx.Name = "PAS_TC_TxtBx";
            this.PAS_TC_TxtBx.Size = new System.Drawing.Size(209, 22);
            this.PAS_TC_TxtBx.TabIndex = 1;
            this.PAS_TC_TxtBx.TextChanged += new System.EventHandler(this.PAS_TC_TxtBx_TextChanged);
            this.PAS_TC_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PAS_TC_TxtBx_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel TC Kimlik Numarası Giriniz";
            // 
            // PAS_Prsnl_ID_TxtBx
            // 
            this.PAS_Prsnl_ID_TxtBx.Location = new System.Drawing.Point(207, 83);
            this.PAS_Prsnl_ID_TxtBx.MaxLength = 10;
            this.PAS_Prsnl_ID_TxtBx.Name = "PAS_Prsnl_ID_TxtBx";
            this.PAS_Prsnl_ID_TxtBx.Size = new System.Drawing.Size(83, 22);
            this.PAS_Prsnl_ID_TxtBx.TabIndex = 0;
            this.PAS_Prsnl_ID_TxtBx.TextChanged += new System.EventHandler(this.PAS_Prsnl_ID_TxtBx_TextChanged);
            this.PAS_Prsnl_ID_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PAS_Prsnl_ID_TxtBx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID Giriniz";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PEG_Guncelle_Btn);
            this.tabPage2.Controls.Add(this.PEG_Ekle_Btn);
            this.tabPage2.Controls.Add(this.PEG_YeniK_Btn);
            this.tabPage2.Controls.Add(this.PEG_Gorev_TxtBx);
            this.tabPage2.Controls.Add(this.PEG_Adres_TxtBx);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.PEG_Tel_TxtBx);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.PEG_Soyad_TxtBx);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.PEG_Ad_TxtBx);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.PEG_Sifre_TxtBx);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.PEG_KAdi_TxtBx);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.PEG_TC_TxtBx);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.PEG_ID_TxtBx);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Ekle-Güncelle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PEG_Guncelle_Btn
            // 
            this.PEG_Guncelle_Btn.Location = new System.Drawing.Point(420, 306);
            this.PEG_Guncelle_Btn.Name = "PEG_Guncelle_Btn";
            this.PEG_Guncelle_Btn.Size = new System.Drawing.Size(84, 74);
            this.PEG_Guncelle_Btn.TabIndex = 12;
            this.PEG_Guncelle_Btn.Text = "Güncelle";
            this.PEG_Guncelle_Btn.UseVisualStyleBackColor = true;
            this.PEG_Guncelle_Btn.Click += new System.EventHandler(this.PEG_Guncelle_Btn_Click);
            // 
            // PEG_Ekle_Btn
            // 
            this.PEG_Ekle_Btn.Location = new System.Drawing.Point(420, 227);
            this.PEG_Ekle_Btn.Name = "PEG_Ekle_Btn";
            this.PEG_Ekle_Btn.Size = new System.Drawing.Size(84, 74);
            this.PEG_Ekle_Btn.TabIndex = 11;
            this.PEG_Ekle_Btn.Text = "Ekle";
            this.PEG_Ekle_Btn.UseVisualStyleBackColor = true;
            this.PEG_Ekle_Btn.Click += new System.EventHandler(this.PEG_Ekle_Btn_Click);
            // 
            // PEG_YeniK_Btn
            // 
            this.PEG_YeniK_Btn.Location = new System.Drawing.Point(420, 147);
            this.PEG_YeniK_Btn.Name = "PEG_YeniK_Btn";
            this.PEG_YeniK_Btn.Size = new System.Drawing.Size(84, 74);
            this.PEG_YeniK_Btn.TabIndex = 10;
            this.PEG_YeniK_Btn.Text = "Yeni Kayıt";
            this.PEG_YeniK_Btn.UseVisualStyleBackColor = true;
            this.PEG_YeniK_Btn.Click += new System.EventHandler(this.PEG_YeniK_Btn_Click);
            // 
            // PEG_Gorev_TxtBx
            // 
            this.PEG_Gorev_TxtBx.FormattingEnabled = true;
            this.PEG_Gorev_TxtBx.Items.AddRange(new object[] {
            "Dağıtım",
            "Taşıma",
            "Kargolama",
            "İnceleme"});
            this.PEG_Gorev_TxtBx.Location = new System.Drawing.Point(168, 314);
            this.PEG_Gorev_TxtBx.Name = "PEG_Gorev_TxtBx";
            this.PEG_Gorev_TxtBx.Size = new System.Drawing.Size(121, 22);
            this.PEG_Gorev_TxtBx.TabIndex = 7;
            // 
            // PEG_Adres_TxtBx
            // 
            this.PEG_Adres_TxtBx.Location = new System.Drawing.Point(168, 405);
            this.PEG_Adres_TxtBx.Multiline = true;
            this.PEG_Adres_TxtBx.Name = "PEG_Adres_TxtBx";
            this.PEG_Adres_TxtBx.Size = new System.Drawing.Size(227, 137);
            this.PEG_Adres_TxtBx.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(97, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "Adres";
            // 
            // PEG_Tel_TxtBx
            // 
            this.PEG_Tel_TxtBx.Location = new System.Drawing.Point(168, 358);
            this.PEG_Tel_TxtBx.MaxLength = 11;
            this.PEG_Tel_TxtBx.Name = "PEG_Tel_TxtBx";
            this.PEG_Tel_TxtBx.Size = new System.Drawing.Size(131, 22);
            this.PEG_Tel_TxtBx.TabIndex = 8;
            this.PEG_Tel_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PEG_Tel_TxtBx_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "Telefon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "Görev";
            // 
            // PEG_Soyad_TxtBx
            // 
            this.PEG_Soyad_TxtBx.Location = new System.Drawing.Point(168, 265);
            this.PEG_Soyad_TxtBx.Name = "PEG_Soyad_TxtBx";
            this.PEG_Soyad_TxtBx.Size = new System.Drawing.Size(131, 22);
            this.PEG_Soyad_TxtBx.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Soyad";
            // 
            // PEG_Ad_TxtBx
            // 
            this.PEG_Ad_TxtBx.Location = new System.Drawing.Point(168, 217);
            this.PEG_Ad_TxtBx.Name = "PEG_Ad_TxtBx";
            this.PEG_Ad_TxtBx.Size = new System.Drawing.Size(131, 22);
            this.PEG_Ad_TxtBx.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ad";
            // 
            // PEG_Sifre_TxtBx
            // 
            this.PEG_Sifre_TxtBx.Location = new System.Drawing.Point(168, 169);
            this.PEG_Sifre_TxtBx.MaxLength = 16;
            this.PEG_Sifre_TxtBx.Name = "PEG_Sifre_TxtBx";
            this.PEG_Sifre_TxtBx.Size = new System.Drawing.Size(131, 22);
            this.PEG_Sifre_TxtBx.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şifre";
            // 
            // PEG_KAdi_TxtBx
            // 
            this.PEG_KAdi_TxtBx.Location = new System.Drawing.Point(168, 119);
            this.PEG_KAdi_TxtBx.MaxLength = 20;
            this.PEG_KAdi_TxtBx.Name = "PEG_KAdi_TxtBx";
            this.PEG_KAdi_TxtBx.Size = new System.Drawing.Size(131, 22);
            this.PEG_KAdi_TxtBx.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kullanıcı Adı";
            // 
            // PEG_TC_TxtBx
            // 
            this.PEG_TC_TxtBx.Location = new System.Drawing.Point(168, 77);
            this.PEG_TC_TxtBx.MaxLength = 11;
            this.PEG_TC_TxtBx.Name = "PEG_TC_TxtBx";
            this.PEG_TC_TxtBx.Size = new System.Drawing.Size(131, 22);
            this.PEG_TC_TxtBx.TabIndex = 2;
            this.PEG_TC_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PEG_TC_TxtBx_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "TC Kimlik Numarası";
            // 
            // PEG_ID_TxtBx
            // 
            this.PEG_ID_TxtBx.Enabled = false;
            this.PEG_ID_TxtBx.Location = new System.Drawing.Point(168, 32);
            this.PEG_ID_TxtBx.MaxLength = 10;
            this.PEG_ID_TxtBx.Name = "PEG_ID_TxtBx";
            this.PEG_ID_TxtBx.Size = new System.Drawing.Size(131, 22);
            this.PEG_ID_TxtBx.TabIndex = 1;
            this.PEG_ID_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PEG_ID_TxtBx_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Personel ID";
            // 
            // Personel_Listele_DataGridView
            // 
            this.Personel_Listele_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Personel_Listele_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Personel_Listele_DataGridView.Location = new System.Drawing.Point(583, 91);
            this.Personel_Listele_DataGridView.Name = "Personel_Listele_DataGridView";
            this.Personel_Listele_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Personel_Listele_DataGridView.Size = new System.Drawing.Size(637, 549);
            this.Personel_Listele_DataGridView.TabIndex = 1;
            this.Personel_Listele_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Personel_Listele_DataGridView_CellContentClick);
            // 
            // Kapat_Btn
            // 
            this.Kapat_Btn.Location = new System.Drawing.Point(1168, 12);
            this.Kapat_Btn.Name = "Kapat_Btn";
            this.Kapat_Btn.Size = new System.Drawing.Size(52, 23);
            this.Kapat_Btn.TabIndex = 13;
            this.Kapat_Btn.Text = "Kapat";
            this.Kapat_Btn.UseVisualStyleBackColor = true;
            this.Kapat_Btn.Click += new System.EventHandler(this.Kapat_Btn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(1018, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "PERSONEL LİSTESİ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PersonelBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1232, 656);
            this.ControlBox = false;
            this.Controls.Add(this.Kapat_Btn);
            this.Controls.Add(this.Personel_Listele_DataGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label15);
            this.Name = "PersonelBilgileriForm";
            this.Load += new System.EventHandler(this.PersonelBilgileriForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Personel_Listele_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PAS_Sil_Btn;
        private System.Windows.Forms.TextBox PAS_ID_Sil_TxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PAS_Ad_TxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PAS_TC_TxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PAS_Prsnl_ID_TxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Personel_Listele_DataGridView;
        private System.Windows.Forms.Button PEG_Guncelle_Btn;
        private System.Windows.Forms.Button PEG_Ekle_Btn;
        private System.Windows.Forms.Button PEG_YeniK_Btn;
        private System.Windows.Forms.ComboBox PEG_Gorev_TxtBx;
        private System.Windows.Forms.TextBox PEG_Adres_TxtBx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PEG_Tel_TxtBx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PEG_Soyad_TxtBx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PEG_Ad_TxtBx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PEG_Sifre_TxtBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PEG_KAdi_TxtBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PEG_TC_TxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PEG_ID_TxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Kapat_Btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}