namespace KargoTakipOtomasyonu
{
    partial class CikisYapanlarForm
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
            this.CikisYapanlar_DataGridView = new System.Windows.Forms.DataGridView();
            this.Kapat_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CY_Gorev_TxtBx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CikisYapanlar_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CikisYapanlar_DataGridView
            // 
            this.CikisYapanlar_DataGridView.AllowUserToAddRows = false;
            this.CikisYapanlar_DataGridView.AllowUserToOrderColumns = true;
            this.CikisYapanlar_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CikisYapanlar_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CikisYapanlar_DataGridView.Location = new System.Drawing.Point(13, 50);
            this.CikisYapanlar_DataGridView.Name = "CikisYapanlar_DataGridView";
            this.CikisYapanlar_DataGridView.ReadOnly = true;
            this.CikisYapanlar_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CikisYapanlar_DataGridView.Size = new System.Drawing.Size(377, 195);
            this.CikisYapanlar_DataGridView.TabIndex = 0;
            // 
            // Kapat_Btn
            // 
            this.Kapat_Btn.Location = new System.Drawing.Point(631, 12);
            this.Kapat_Btn.Name = "Kapat_Btn";
            this.Kapat_Btn.Size = new System.Drawing.Size(57, 23);
            this.Kapat_Btn.TabIndex = 3;
            this.Kapat_Btn.Text = "Kapat";
            this.Kapat_Btn.UseVisualStyleBackColor = true;
            this.Kapat_Btn.Click += new System.EventHandler(this.Kapat_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TarihDateTimePicker);
            this.groupBox1.Controls.Add(this.CY_Gorev_TxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(397, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // TarihDateTimePicker
            // 
            this.TarihDateTimePicker.Location = new System.Drawing.Point(52, 143);
            this.TarihDateTimePicker.Name = "TarihDateTimePicker";
            this.TarihDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.TarihDateTimePicker.TabIndex = 2;
            this.TarihDateTimePicker.ValueChanged += new System.EventHandler(this.TarihDateTimePicker_ValueChanged);
            // 
            // CY_Gorev_TxtBx
            // 
            this.CY_Gorev_TxtBx.FormattingEnabled = true;
            this.CY_Gorev_TxtBx.Items.AddRange(new object[] {
            "Yönetici",
            "Personel",
            "Ziyaretçi"});
            this.CY_Gorev_TxtBx.Location = new System.Drawing.Point(83, 67);
            this.CY_Gorev_TxtBx.Name = "CY_Gorev_TxtBx";
            this.CY_Gorev_TxtBx.Size = new System.Drawing.Size(121, 22);
            this.CY_Gorev_TxtBx.TabIndex = 1;
            this.CY_Gorev_TxtBx.SelectedIndexChanged += new System.EventHandler(this.CY_Gorev_TxtBx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yetki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çıkış Yapan Kullanıcıların Listesi";
            // 
            // CikisYapanlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(700, 255);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kapat_Btn);
            this.Controls.Add(this.CikisYapanlar_DataGridView);
            this.Name = "CikisYapanlarForm";
            this.Load += new System.EventHandler(this.CikisYapanlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CikisYapanlar_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CikisYapanlar_DataGridView;
        private System.Windows.Forms.Button Kapat_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CY_Gorev_TxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TarihDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}