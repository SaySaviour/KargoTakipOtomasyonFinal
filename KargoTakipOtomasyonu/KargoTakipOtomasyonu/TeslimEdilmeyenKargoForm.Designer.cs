namespace KargoTakipOtomasyonu
{
    partial class TeslimEdilmeyenKargoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeslimEdilmynGroupBx = new System.Windows.Forms.GroupBox();
            this.TEEkleBtn = new System.Windows.Forms.Button();
            this.TEtarih_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.TEAciklamaLabel = new System.Windows.Forms.Label();
            this.TENedeniLabel = new System.Windows.Forms.Label();
            this.KargoNumarasiLabel = new System.Windows.Forms.Label();
            this.TEAciklamaTxtBx = new System.Windows.Forms.TextBox();
            this.TENedeniTxtBx = new System.Windows.Forms.TextBox();
            this.TEKargoNo_TxtBx = new System.Windows.Forms.TextBox();
            this.AramaGroupBx = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KargoTarhiAramaDateTimeP = new System.Windows.Forms.DateTimePicker();
            this.KargoNumarasiAramaTxtBx = new System.Windows.Forms.TextBox();
            this.Kapat_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TeslimEdilmynGroupBx.SuspendLayout();
            this.AramaGroupBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(465, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeslimEdilmynGroupBx
            // 
            this.TeslimEdilmynGroupBx.Controls.Add(this.TEEkleBtn);
            this.TeslimEdilmynGroupBx.Controls.Add(this.TEtarih_DateTimePicker);
            this.TeslimEdilmynGroupBx.Controls.Add(this.TarihLabel);
            this.TeslimEdilmynGroupBx.Controls.Add(this.TEAciklamaLabel);
            this.TeslimEdilmynGroupBx.Controls.Add(this.TENedeniLabel);
            this.TeslimEdilmynGroupBx.Controls.Add(this.KargoNumarasiLabel);
            this.TeslimEdilmynGroupBx.Controls.Add(this.TEAciklamaTxtBx);
            this.TeslimEdilmynGroupBx.Controls.Add(this.TENedeniTxtBx);
            this.TeslimEdilmynGroupBx.Controls.Add(this.TEKargoNo_TxtBx);
            this.TeslimEdilmynGroupBx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeslimEdilmynGroupBx.Location = new System.Drawing.Point(13, 280);
            this.TeslimEdilmynGroupBx.Name = "TeslimEdilmynGroupBx";
            this.TeslimEdilmynGroupBx.Size = new System.Drawing.Size(836, 225);
            this.TeslimEdilmynGroupBx.TabIndex = 1;
            this.TeslimEdilmynGroupBx.TabStop = false;
            this.TeslimEdilmynGroupBx.Text = "Teslim Edilmeyen Kargo Ekle";
            // 
            // TEEkleBtn
            // 
            this.TEEkleBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEEkleBtn.Location = new System.Drawing.Point(93, 167);
            this.TEEkleBtn.Name = "TEEkleBtn";
            this.TEEkleBtn.Size = new System.Drawing.Size(206, 52);
            this.TEEkleBtn.TabIndex = 4;
            this.TEEkleBtn.Text = "Ekle";
            this.TEEkleBtn.UseVisualStyleBackColor = true;
            this.TEEkleBtn.Click += new System.EventHandler(this.TEEkleBtn_Click);
            // 
            // TEtarih_DateTimePicker
            // 
            this.TEtarih_DateTimePicker.Location = new System.Drawing.Point(93, 99);
            this.TEtarih_DateTimePicker.Name = "TEtarih_DateTimePicker";
            this.TEtarih_DateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.TEtarih_DateTimePicker.TabIndex = 1;
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Location = new System.Drawing.Point(36, 105);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(42, 15);
            this.TarihLabel.TabIndex = 1;
            this.TarihLabel.Text = "Tarih";
            // 
            // TEAciklamaLabel
            // 
            this.TEAciklamaLabel.AutoSize = true;
            this.TEAciklamaLabel.Location = new System.Drawing.Point(406, 22);
            this.TEAciklamaLabel.Name = "TEAciklamaLabel";
            this.TEAciklamaLabel.Size = new System.Drawing.Size(63, 15);
            this.TEAciklamaLabel.TabIndex = 1;
            this.TEAciklamaLabel.Text = "Açıklama";
            // 
            // TENedeniLabel
            // 
            this.TENedeniLabel.AutoSize = true;
            this.TENedeniLabel.Location = new System.Drawing.Point(308, 105);
            this.TENedeniLabel.Name = "TENedeniLabel";
            this.TENedeniLabel.Size = new System.Drawing.Size(161, 15);
            this.TENedeniLabel.TabIndex = 1;
            this.TENedeniLabel.Text = "Teslim Edilmeme Nedeni";
            // 
            // KargoNumarasiLabel
            // 
            this.KargoNumarasiLabel.AutoSize = true;
            this.KargoNumarasiLabel.Location = new System.Drawing.Point(36, 54);
            this.KargoNumarasiLabel.Name = "KargoNumarasiLabel";
            this.KargoNumarasiLabel.Size = new System.Drawing.Size(105, 15);
            this.KargoNumarasiLabel.TabIndex = 1;
            this.KargoNumarasiLabel.Text = "Kargo Numarası";
            // 
            // TEAciklamaTxtBx
            // 
            this.TEAciklamaTxtBx.Location = new System.Drawing.Point(475, 22);
            this.TEAciklamaTxtBx.Multiline = true;
            this.TEAciklamaTxtBx.Name = "TEAciklamaTxtBx";
            this.TEAciklamaTxtBx.Size = new System.Drawing.Size(262, 64);
            this.TEAciklamaTxtBx.TabIndex = 2;
            // 
            // TENedeniTxtBx
            // 
            this.TENedeniTxtBx.Location = new System.Drawing.Point(475, 105);
            this.TENedeniTxtBx.Multiline = true;
            this.TENedeniTxtBx.Name = "TENedeniTxtBx";
            this.TENedeniTxtBx.Size = new System.Drawing.Size(262, 64);
            this.TENedeniTxtBx.TabIndex = 3;
            // 
            // TEKargoNo_TxtBx
            // 
            this.TEKargoNo_TxtBx.Location = new System.Drawing.Point(147, 51);
            this.TEKargoNo_TxtBx.MaxLength = 19;
            this.TEKargoNo_TxtBx.Name = "TEKargoNo_TxtBx";
            this.TEKargoNo_TxtBx.Size = new System.Drawing.Size(146, 23);
            this.TEKargoNo_TxtBx.TabIndex = 0;
            this.TEKargoNo_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TEKargoNo_TxtBx_KeyPress);
            // 
            // AramaGroupBx
            // 
            this.AramaGroupBx.Controls.Add(this.label3);
            this.AramaGroupBx.Controls.Add(this.label2);
            this.AramaGroupBx.Controls.Add(this.KargoTarhiAramaDateTimeP);
            this.AramaGroupBx.Controls.Add(this.KargoNumarasiAramaTxtBx);
            this.AramaGroupBx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AramaGroupBx.Location = new System.Drawing.Point(489, 46);
            this.AramaGroupBx.Name = "AramaGroupBx";
            this.AramaGroupBx.Size = new System.Drawing.Size(360, 210);
            this.AramaGroupBx.TabIndex = 4;
            this.AramaGroupBx.TabStop = false;
            this.AramaGroupBx.Text = "Arama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kargo Tarihine Göre Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kargo Numarası İle Arama";
            // 
            // KargoTarhiAramaDateTimeP
            // 
            this.KargoTarhiAramaDateTimeP.Location = new System.Drawing.Point(78, 163);
            this.KargoTarhiAramaDateTimeP.Name = "KargoTarhiAramaDateTimeP";
            this.KargoTarhiAramaDateTimeP.Size = new System.Drawing.Size(200, 23);
            this.KargoTarhiAramaDateTimeP.TabIndex = 1;
            this.KargoTarhiAramaDateTimeP.ValueChanged += new System.EventHandler(this.KargoTarhiAramaDateTimeP_ValueChanged);
            // 
            // KargoNumarasiAramaTxtBx
            // 
            this.KargoNumarasiAramaTxtBx.Location = new System.Drawing.Point(78, 70);
            this.KargoNumarasiAramaTxtBx.MaxLength = 19;
            this.KargoNumarasiAramaTxtBx.Name = "KargoNumarasiAramaTxtBx";
            this.KargoNumarasiAramaTxtBx.Size = new System.Drawing.Size(200, 23);
            this.KargoNumarasiAramaTxtBx.TabIndex = 0;
            this.KargoNumarasiAramaTxtBx.TextChanged += new System.EventHandler(this.KargoNumarasiAramaTxtBx_TextChanged);
            this.KargoNumarasiAramaTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KargoNumarasiAramaTxtBx_KeyPress);
            // 
            // Kapat_Btn
            // 
            this.Kapat_Btn.Location = new System.Drawing.Point(803, 17);
            this.Kapat_Btn.Name = "Kapat_Btn";
            this.Kapat_Btn.Size = new System.Drawing.Size(46, 23);
            this.Kapat_Btn.TabIndex = 3;
            this.Kapat_Btn.Text = "Kapat";
            this.Kapat_Btn.UseVisualStyleBackColor = true;
            this.Kapat_Btn.Click += new System.EventHandler(this.Kapat_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kargo Durum Listesi";
            // 
            // TeslimEdilmeyenKargoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(861, 517);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AramaGroupBx);
            this.Controls.Add(this.Kapat_Btn);
            this.Controls.Add(this.TeslimEdilmynGroupBx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeslimEdilmeyenKargoForm";
            this.Load += new System.EventHandler(this.TeslimEdilmeyenKargoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TeslimEdilmynGroupBx.ResumeLayout(false);
            this.TeslimEdilmynGroupBx.PerformLayout();
            this.AramaGroupBx.ResumeLayout(false);
            this.AramaGroupBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox TeslimEdilmynGroupBx;
        private System.Windows.Forms.Button TEEkleBtn;
        private System.Windows.Forms.DateTimePicker TEtarih_DateTimePicker;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Label TEAciklamaLabel;
        private System.Windows.Forms.Label TENedeniLabel;
        private System.Windows.Forms.Label KargoNumarasiLabel;
        private System.Windows.Forms.TextBox TEAciklamaTxtBx;
        private System.Windows.Forms.TextBox TENedeniTxtBx;
        private System.Windows.Forms.TextBox TEKargoNo_TxtBx;
        private System.Windows.Forms.GroupBox AramaGroupBx;
        private System.Windows.Forms.TextBox KargoNumarasiAramaTxtBx;
        private System.Windows.Forms.Button Kapat_Btn;
        private System.Windows.Forms.DateTimePicker KargoTarhiAramaDateTimeP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}