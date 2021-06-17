namespace KargoTakipOtomasyonu
{
    partial class ZiyaretciBilgileriForm
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
            this.zyrtcidatagrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ZA_TC_TxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZA_Ad_TxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kapat_Btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ZS_Sil_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ZS_TC_TxtBx = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zyrtcidatagrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // zyrtcidatagrid
            // 
            this.zyrtcidatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zyrtcidatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zyrtcidatagrid.Location = new System.Drawing.Point(12, 65);
            this.zyrtcidatagrid.Name = "zyrtcidatagrid";
            this.zyrtcidatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zyrtcidatagrid.Size = new System.Drawing.Size(359, 353);
            this.zyrtcidatagrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ZA_TC_TxtBx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ZA_Ad_TxtBx);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(387, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ziyaretçi Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ziyaretçi TC Kimlik Numarası Giriniz";
            // 
            // ZA_TC_TxtBx
            // 
            this.ZA_TC_TxtBx.Location = new System.Drawing.Point(72, 144);
            this.ZA_TC_TxtBx.MaxLength = 11;
            this.ZA_TC_TxtBx.Name = "ZA_TC_TxtBx";
            this.ZA_TC_TxtBx.Size = new System.Drawing.Size(139, 22);
            this.ZA_TC_TxtBx.TabIndex = 2;
            this.ZA_TC_TxtBx.TextChanged += new System.EventHandler(this.ZA_TC_TxtBx_TextChanged);
            this.ZA_TC_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZA_TC_TxtBx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ziyaretçi Adı Giriniz";
            // 
            // ZA_Ad_TxtBx
            // 
            this.ZA_Ad_TxtBx.Location = new System.Drawing.Point(72, 62);
            this.ZA_Ad_TxtBx.Name = "ZA_Ad_TxtBx";
            this.ZA_Ad_TxtBx.Size = new System.Drawing.Size(139, 22);
            this.ZA_Ad_TxtBx.TabIndex = 1;
            this.ZA_Ad_TxtBx.TextChanged += new System.EventHandler(this.ZA_Ad_TxtBx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ziyaretçi Listesi";
            // 
            // Kapat_Btn
            // 
            this.Kapat_Btn.Location = new System.Drawing.Point(628, 12);
            this.Kapat_Btn.Name = "Kapat_Btn";
            this.Kapat_Btn.Size = new System.Drawing.Size(45, 23);
            this.Kapat_Btn.TabIndex = 3;
            this.Kapat_Btn.Text = "Kapat";
            this.Kapat_Btn.UseVisualStyleBackColor = true;
            this.Kapat_Btn.Click += new System.EventHandler(this.Kapat_Btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ZS_Sil_Btn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ZS_TC_TxtBx);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(387, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ziyaretçi Sil";
            // 
            // ZS_Sil_Btn
            // 
            this.ZS_Sil_Btn.Location = new System.Drawing.Point(98, 88);
            this.ZS_Sil_Btn.Name = "ZS_Sil_Btn";
            this.ZS_Sil_Btn.Size = new System.Drawing.Size(78, 22);
            this.ZS_Sil_Btn.TabIndex = 1;
            this.ZS_Sil_Btn.Text = "Sil";
            this.ZS_Sil_Btn.UseVisualStyleBackColor = true;
            this.ZS_Sil_Btn.Click += new System.EventHandler(this.ZS_Sil_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ziyaretçi TC Kimlik Numarası Giriniz";
            // 
            // ZS_TC_TxtBx
            // 
            this.ZS_TC_TxtBx.Location = new System.Drawing.Point(72, 54);
            this.ZS_TC_TxtBx.MaxLength = 11;
            this.ZS_TC_TxtBx.Name = "ZS_TC_TxtBx";
            this.ZS_TC_TxtBx.Size = new System.Drawing.Size(139, 22);
            this.ZS_TC_TxtBx.TabIndex = 0;
            this.ZS_TC_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZS_TC_TxtBx_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ZiyaretciBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(686, 430);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Kapat_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zyrtcidatagrid);
            this.Controls.Add(this.label3);
            this.Name = "ZiyaretciBilgileriForm";
            this.Load += new System.EventHandler(this.ZiyaretciBilgileriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zyrtcidatagrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView zyrtcidatagrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ZA_TC_TxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZA_Ad_TxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Kapat_Btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ZS_Sil_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ZS_TC_TxtBx;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}