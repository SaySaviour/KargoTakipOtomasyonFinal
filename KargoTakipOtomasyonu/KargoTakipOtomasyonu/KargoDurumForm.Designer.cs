namespace KargoTakipOtomasyonu
{
    partial class KargoDurumForm
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
            this.KargoDurumDataGridView = new System.Windows.Forms.DataGridView();
            this.Kargo_Numarasi_TxtBx = new System.Windows.Forms.TextBox();
            this.KargoDurumAramaGroupBox = new System.Windows.Forms.GroupBox();
            this.KargoNumarasiGir_Label = new System.Windows.Forms.Label();
            this.KargoDurumEklemeGroupBox = new System.Windows.Forms.GroupBox();
            this.DurumKaydetBtn = new System.Windows.Forms.Button();
            this.IslemZamanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GonderiDurumCmboBx = new System.Windows.Forms.ComboBox();
            this.LokasyonLabel = new System.Windows.Forms.Label();
            this.IslemZamanLabel = new System.Windows.Forms.Label();
            this.GonderiDurumLabel = new System.Windows.Forms.Label();
            this.KargoEkNumarasi_Label = new System.Windows.Forms.Label();
            this.LokasyonTxtBx = new System.Windows.Forms.TextBox();
            this.KargoNumarasiEk_TxtBx = new System.Windows.Forms.TextBox();
            this.KapatBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KargoDurumDataGridView)).BeginInit();
            this.KargoDurumAramaGroupBox.SuspendLayout();
            this.KargoDurumEklemeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // KargoDurumDataGridView
            // 
            this.KargoDurumDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KargoDurumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KargoDurumDataGridView.Location = new System.Drawing.Point(12, 50);
            this.KargoDurumDataGridView.Name = "KargoDurumDataGridView";
            this.KargoDurumDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KargoDurumDataGridView.Size = new System.Drawing.Size(517, 479);
            this.KargoDurumDataGridView.TabIndex = 0;
            // 
            // Kargo_Numarasi_TxtBx
            // 
            this.Kargo_Numarasi_TxtBx.Location = new System.Drawing.Point(195, 58);
            this.Kargo_Numarasi_TxtBx.MaxLength = 19;
            this.Kargo_Numarasi_TxtBx.Name = "Kargo_Numarasi_TxtBx";
            this.Kargo_Numarasi_TxtBx.Size = new System.Drawing.Size(193, 20);
            this.Kargo_Numarasi_TxtBx.TabIndex = 1;
            this.Kargo_Numarasi_TxtBx.TextChanged += new System.EventHandler(this.Kargo_Numarasi_TxtBx_TextChanged);
            this.Kargo_Numarasi_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kargo_Numarasi_TxtBx_KeyPress);
            // 
            // KargoDurumAramaGroupBox
            // 
            this.KargoDurumAramaGroupBox.Controls.Add(this.KargoNumarasiGir_Label);
            this.KargoDurumAramaGroupBox.Controls.Add(this.Kargo_Numarasi_TxtBx);
            this.KargoDurumAramaGroupBox.Location = new System.Drawing.Point(554, 50);
            this.KargoDurumAramaGroupBox.Name = "KargoDurumAramaGroupBox";
            this.KargoDurumAramaGroupBox.Size = new System.Drawing.Size(417, 131);
            this.KargoDurumAramaGroupBox.TabIndex = 2;
            this.KargoDurumAramaGroupBox.TabStop = false;
            this.KargoDurumAramaGroupBox.Text = "Kargo Durum Sorgulama";
            // 
            // KargoNumarasiGir_Label
            // 
            this.KargoNumarasiGir_Label.AutoSize = true;
            this.KargoNumarasiGir_Label.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KargoNumarasiGir_Label.Location = new System.Drawing.Point(26, 60);
            this.KargoNumarasiGir_Label.Name = "KargoNumarasiGir_Label";
            this.KargoNumarasiGir_Label.Size = new System.Drawing.Size(154, 15);
            this.KargoNumarasiGir_Label.TabIndex = 2;
            this.KargoNumarasiGir_Label.Text = "Kargo Numarası Giriniz";
            // 
            // KargoDurumEklemeGroupBox
            // 
            this.KargoDurumEklemeGroupBox.Controls.Add(this.DurumKaydetBtn);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.IslemZamanDateTimePicker);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.GonderiDurumCmboBx);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.LokasyonLabel);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.IslemZamanLabel);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.GonderiDurumLabel);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.KargoEkNumarasi_Label);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.LokasyonTxtBx);
            this.KargoDurumEklemeGroupBox.Controls.Add(this.KargoNumarasiEk_TxtBx);
            this.KargoDurumEklemeGroupBox.Location = new System.Drawing.Point(554, 188);
            this.KargoDurumEklemeGroupBox.Name = "KargoDurumEklemeGroupBox";
            this.KargoDurumEklemeGroupBox.Size = new System.Drawing.Size(417, 341);
            this.KargoDurumEklemeGroupBox.TabIndex = 3;
            this.KargoDurumEklemeGroupBox.TabStop = false;
            this.KargoDurumEklemeGroupBox.Text = "Kargo Durum Ekle";
            // 
            // DurumKaydetBtn
            // 
            this.DurumKaydetBtn.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumKaydetBtn.Location = new System.Drawing.Point(156, 242);
            this.DurumKaydetBtn.Name = "DurumKaydetBtn";
            this.DurumKaydetBtn.Size = new System.Drawing.Size(141, 57);
            this.DurumKaydetBtn.TabIndex = 4;
            this.DurumKaydetBtn.Text = "Kargo Durumu Kaydet";
            this.DurumKaydetBtn.UseVisualStyleBackColor = true;
            this.DurumKaydetBtn.Click += new System.EventHandler(this.DurumKaydetBtn_Click);
            // 
            // IslemZamanDateTimePicker
            // 
            this.IslemZamanDateTimePicker.Location = new System.Drawing.Point(156, 146);
            this.IslemZamanDateTimePicker.Name = "IslemZamanDateTimePicker";
            this.IslemZamanDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.IslemZamanDateTimePicker.TabIndex = 2;
            // 
            // GonderiDurumCmboBx
            // 
            this.GonderiDurumCmboBx.FormattingEnabled = true;
            this.GonderiDurumCmboBx.Items.AddRange(new object[] {
            "Yola Çıktı",
            "Varış Merkezinde",
            "Çıkış Merkezinde",
            "Transfer",
            "Dağıtımda",
            "Teslim Edildi"});
            this.GonderiDurumCmboBx.Location = new System.Drawing.Point(156, 86);
            this.GonderiDurumCmboBx.Name = "GonderiDurumCmboBx";
            this.GonderiDurumCmboBx.Size = new System.Drawing.Size(141, 21);
            this.GonderiDurumCmboBx.TabIndex = 1;
            // 
            // LokasyonLabel
            // 
            this.LokasyonLabel.AutoSize = true;
            this.LokasyonLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LokasyonLabel.Location = new System.Drawing.Point(69, 202);
            this.LokasyonLabel.Name = "LokasyonLabel";
            this.LokasyonLabel.Size = new System.Drawing.Size(67, 15);
            this.LokasyonLabel.TabIndex = 1;
            this.LokasyonLabel.Text = "Lokasyon";
            // 
            // IslemZamanLabel
            // 
            this.IslemZamanLabel.AutoSize = true;
            this.IslemZamanLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IslemZamanLabel.Location = new System.Drawing.Point(56, 151);
            this.IslemZamanLabel.Name = "IslemZamanLabel";
            this.IslemZamanLabel.Size = new System.Drawing.Size(90, 15);
            this.IslemZamanLabel.TabIndex = 1;
            this.IslemZamanLabel.Text = "İşlem Zamanı";
            // 
            // GonderiDurumLabel
            // 
            this.GonderiDurumLabel.AutoSize = true;
            this.GonderiDurumLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GonderiDurumLabel.Location = new System.Drawing.Point(37, 88);
            this.GonderiDurumLabel.Name = "GonderiDurumLabel";
            this.GonderiDurumLabel.Size = new System.Drawing.Size(113, 15);
            this.GonderiDurumLabel.TabIndex = 1;
            this.GonderiDurumLabel.Text = "Gönderi Durumu";
            // 
            // KargoEkNumarasi_Label
            // 
            this.KargoEkNumarasi_Label.AutoSize = true;
            this.KargoEkNumarasi_Label.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KargoEkNumarasi_Label.Location = new System.Drawing.Point(40, 40);
            this.KargoEkNumarasi_Label.Name = "KargoEkNumarasi_Label";
            this.KargoEkNumarasi_Label.Size = new System.Drawing.Size(108, 15);
            this.KargoEkNumarasi_Label.TabIndex = 1;
            this.KargoEkNumarasi_Label.Text = "Kargo Numarası";
            // 
            // LokasyonTxtBx
            // 
            this.LokasyonTxtBx.Location = new System.Drawing.Point(156, 200);
            this.LokasyonTxtBx.Name = "LokasyonTxtBx";
            this.LokasyonTxtBx.Size = new System.Drawing.Size(141, 20);
            this.LokasyonTxtBx.TabIndex = 3;
            // 
            // KargoNumarasiEk_TxtBx
            // 
            this.KargoNumarasiEk_TxtBx.Location = new System.Drawing.Point(156, 38);
            this.KargoNumarasiEk_TxtBx.MaxLength = 19;
            this.KargoNumarasiEk_TxtBx.Name = "KargoNumarasiEk_TxtBx";
            this.KargoNumarasiEk_TxtBx.Size = new System.Drawing.Size(141, 20);
            this.KargoNumarasiEk_TxtBx.TabIndex = 0;
            this.KargoNumarasiEk_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KargoNumarasiEk_TxtBx_KeyPress);
            // 
            // KapatBtn
            // 
            this.KapatBtn.Location = new System.Drawing.Point(924, 12);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(47, 31);
            this.KapatBtn.TabIndex = 5;
            this.KapatBtn.Text = "Kapat";
            this.KapatBtn.UseVisualStyleBackColor = true;
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kargo Durum Listesi";
            // 
            // KargoDurumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(983, 540);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KapatBtn);
            this.Controls.Add(this.KargoDurumEklemeGroupBox);
            this.Controls.Add(this.KargoDurumAramaGroupBox);
            this.Controls.Add(this.KargoDurumDataGridView);
            this.Name = "KargoDurumForm";
            this.Load += new System.EventHandler(this.KargoDurumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KargoDurumDataGridView)).EndInit();
            this.KargoDurumAramaGroupBox.ResumeLayout(false);
            this.KargoDurumAramaGroupBox.PerformLayout();
            this.KargoDurumEklemeGroupBox.ResumeLayout(false);
            this.KargoDurumEklemeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView KargoDurumDataGridView;
        private System.Windows.Forms.TextBox Kargo_Numarasi_TxtBx;
        private System.Windows.Forms.GroupBox KargoDurumAramaGroupBox;
        private System.Windows.Forms.Label KargoNumarasiGir_Label;
        private System.Windows.Forms.GroupBox KargoDurumEklemeGroupBox;
        private System.Windows.Forms.Button DurumKaydetBtn;
        private System.Windows.Forms.DateTimePicker IslemZamanDateTimePicker;
        private System.Windows.Forms.ComboBox GonderiDurumCmboBx;
        private System.Windows.Forms.Label LokasyonLabel;
        private System.Windows.Forms.Label IslemZamanLabel;
        private System.Windows.Forms.Label GonderiDurumLabel;
        private System.Windows.Forms.Label KargoEkNumarasi_Label;
        private System.Windows.Forms.TextBox LokasyonTxtBx;
        private System.Windows.Forms.TextBox KargoNumarasiEk_TxtBx;
        private System.Windows.Forms.Button KapatBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}