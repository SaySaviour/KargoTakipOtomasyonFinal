namespace KargoTakipOtomasyonu
{
    partial class GirisYapanlarForm
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
            this.GirisYapanlarDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GY_Gorev_CmbBx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kapat_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GirisYapanlarDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GirisYapanlarDataGridView
            // 
            this.GirisYapanlarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GirisYapanlarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GirisYapanlarDataGridView.Location = new System.Drawing.Point(12, 57);
            this.GirisYapanlarDataGridView.Name = "GirisYapanlarDataGridView";
            this.GirisYapanlarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GirisYapanlarDataGridView.Size = new System.Drawing.Size(386, 177);
            this.GirisYapanlarDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TarihDateTimePicker);
            this.groupBox1.Controls.Add(this.GY_Gorev_CmbBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(404, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // TarihDateTimePicker
            // 
            this.TarihDateTimePicker.Location = new System.Drawing.Point(49, 135);
            this.TarihDateTimePicker.Name = "TarihDateTimePicker";
            this.TarihDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.TarihDateTimePicker.TabIndex = 2;
            this.TarihDateTimePicker.ValueChanged += new System.EventHandler(this.TarihDateTimePicker_ValueChanged);
            // 
            // GY_Gorev_CmbBx
            // 
            this.GY_Gorev_CmbBx.FormattingEnabled = true;
            this.GY_Gorev_CmbBx.Items.AddRange(new object[] {
            "Yönetici",
            "Personel",
            "Ziyaretçi"});
            this.GY_Gorev_CmbBx.Location = new System.Drawing.Point(81, 57);
            this.GY_Gorev_CmbBx.Name = "GY_Gorev_CmbBx";
            this.GY_Gorev_CmbBx.Size = new System.Drawing.Size(121, 22);
            this.GY_Gorev_CmbBx.TabIndex = 1;
            this.GY_Gorev_CmbBx.SelectedIndexChanged += new System.EventHandler(this.GY_Gorev_CmbBx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yetki";
            // 
            // Kapat_Btn
            // 
            this.Kapat_Btn.Location = new System.Drawing.Point(643, 12);
            this.Kapat_Btn.Name = "Kapat_Btn";
            this.Kapat_Btn.Size = new System.Drawing.Size(46, 23);
            this.Kapat_Btn.TabIndex = 3;
            this.Kapat_Btn.Text = "Kapat";
            this.Kapat_Btn.UseVisualStyleBackColor = true;
            this.Kapat_Btn.Click += new System.EventHandler(this.Kapat_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giriş Yapan Kullanıcıların Listesi";
            // 
            // GirisYapanlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(701, 242);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kapat_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GirisYapanlarDataGridView);
            this.Name = "GirisYapanlarForm";
            this.Load += new System.EventHandler(this.GirisYapanlarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GirisYapanlarDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GirisYapanlarDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Kapat_Btn;
        private System.Windows.Forms.ComboBox GY_Gorev_CmbBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TarihDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}