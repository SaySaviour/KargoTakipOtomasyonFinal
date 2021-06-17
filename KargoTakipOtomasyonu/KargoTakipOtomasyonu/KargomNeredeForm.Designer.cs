namespace KargoTakipOtomasyonu
{
    partial class KargomNeredeForm
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
            this.KNFDataGridView = new System.Windows.Forms.DataGridView();
            this.KNFAramaGroupBox = new System.Windows.Forms.GroupBox();
            this.KNFAraBtn = new System.Windows.Forms.Button();
            this.KNFKargoTNo_TxtBx = new System.Windows.Forms.TextBox();
            this.KNFKargoTNo_Label = new System.Windows.Forms.Label();
            this.Kapat_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KNFDataGridView)).BeginInit();
            this.KNFAramaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // KNFDataGridView
            // 
            this.KNFDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KNFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KNFDataGridView.Location = new System.Drawing.Point(12, 59);
            this.KNFDataGridView.Name = "KNFDataGridView";
            this.KNFDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KNFDataGridView.Size = new System.Drawing.Size(433, 379);
            this.KNFDataGridView.TabIndex = 0;
            // 
            // KNFAramaGroupBox
            // 
            this.KNFAramaGroupBox.Controls.Add(this.KNFAraBtn);
            this.KNFAramaGroupBox.Controls.Add(this.KNFKargoTNo_TxtBx);
            this.KNFAramaGroupBox.Controls.Add(this.KNFKargoTNo_Label);
            this.KNFAramaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KNFAramaGroupBox.Location = new System.Drawing.Point(451, 54);
            this.KNFAramaGroupBox.Name = "KNFAramaGroupBox";
            this.KNFAramaGroupBox.Size = new System.Drawing.Size(337, 384);
            this.KNFAramaGroupBox.TabIndex = 1;
            this.KNFAramaGroupBox.TabStop = false;
            this.KNFAramaGroupBox.Text = "Arama";
            // 
            // KNFAraBtn
            // 
            this.KNFAraBtn.Location = new System.Drawing.Point(112, 193);
            this.KNFAraBtn.Name = "KNFAraBtn";
            this.KNFAraBtn.Size = new System.Drawing.Size(110, 43);
            this.KNFAraBtn.TabIndex = 2;
            this.KNFAraBtn.Text = "Ara";
            this.KNFAraBtn.UseVisualStyleBackColor = true;
            this.KNFAraBtn.Click += new System.EventHandler(this.KNFAraBtn_Click);
            // 
            // KNFKargoTNo_TxtBx
            // 
            this.KNFKargoTNo_TxtBx.Location = new System.Drawing.Point(69, 146);
            this.KNFKargoTNo_TxtBx.MaxLength = 19;
            this.KNFKargoTNo_TxtBx.Name = "KNFKargoTNo_TxtBx";
            this.KNFKargoTNo_TxtBx.Size = new System.Drawing.Size(199, 22);
            this.KNFKargoTNo_TxtBx.TabIndex = 1;
            this.KNFKargoTNo_TxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KNFKargoTNo_TxtBx_KeyPress);
            // 
            // KNFKargoTNo_Label
            // 
            this.KNFKargoTNo_Label.AutoSize = true;
            this.KNFKargoTNo_Label.Location = new System.Drawing.Point(66, 105);
            this.KNFKargoTNo_Label.Name = "KNFKargoTNo_Label";
            this.KNFKargoTNo_Label.Size = new System.Drawing.Size(222, 16);
            this.KNFKargoTNo_Label.TabIndex = 0;
            this.KNFKargoTNo_Label.Text = "Kargo Takip Numarasını Giriniz";
            // 
            // Kapat_Btn
            // 
            this.Kapat_Btn.Location = new System.Drawing.Point(743, 12);
            this.Kapat_Btn.Name = "Kapat_Btn";
            this.Kapat_Btn.Size = new System.Drawing.Size(45, 26);
            this.Kapat_Btn.TabIndex = 3;
            this.Kapat_Btn.Text = "Kapat";
            this.Kapat_Btn.UseVisualStyleBackColor = true;
            this.Kapat_Btn.Click += new System.EventHandler(this.Kapat_Btn_Click);
            // 
            // KargomNeredeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Kapat_Btn);
            this.Controls.Add(this.KNFAramaGroupBox);
            this.Controls.Add(this.KNFDataGridView);
            this.Name = "KargomNeredeForm";
            ((System.ComponentModel.ISupportInitialize)(this.KNFDataGridView)).EndInit();
            this.KNFAramaGroupBox.ResumeLayout(false);
            this.KNFAramaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KNFDataGridView;
        private System.Windows.Forms.GroupBox KNFAramaGroupBox;
        private System.Windows.Forms.Button KNFAraBtn;
        private System.Windows.Forms.TextBox KNFKargoTNo_TxtBx;
        private System.Windows.Forms.Label KNFKargoTNo_Label;
        private System.Windows.Forms.Button Kapat_Btn;
    }
}