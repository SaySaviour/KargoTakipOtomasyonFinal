using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri;

namespace KargoTakipOtomasyonu
{
    public partial class KargoBilgileriForm : Form
    {
        public KargoBilgileriForm()
        {
            InitializeComponent();
        }
        KargoBilgileri kargo = new KargoBilgileri();
        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KargoBilgileriForm_Load(object sender, EventArgs e)
        {
            kargo.Kargo_Listele(KargoBilgileriDataGridView);
        }

        private void KargoyuSil_Btn_Click(object sender, EventArgs e)
        {
            if (Kargo_Numara_TxtBx.Text == "")
                errorProvider1.SetError(Kargo_Numara_TxtBx, "Silmek İstediğiniz Kargo Numarasını Girmelisiniz!!");
            else
            {
                kargo.Kargo_Sil(Kargo_Numara_TxtBx.Text);
                kargo.Kargo_Listele(KargoBilgileriDataGridView);
            }
        }

        private void TabloKargoSil_Btn_Click(object sender, EventArgs e)
        {
            kargo.Secilen_Kargo_Sil(KargoBilgileriDataGridView);
            kargo.Kargo_Listele(KargoBilgileriDataGridView);
        }

        private void AranacakBilgiTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (AranacakBilgiTxtBx.Text == "")
                kargo.Kargo_Listele(KargoBilgileriDataGridView);
            else
                kargo.Kargo_Arama_KargoNo(KargoBilgileriDataGridView, AranacakBilgiTxtBx.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                kargo.Kargo_Listele(KargoBilgileriDataGridView);
            else
                kargo.Kargo_Arama_GndrcAdSoyad(KargoBilgileriDataGridView, textBox1.Text);
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            if (KargoNumarasiTxTbx.Text == "" || GondericiAdTxtBx.Text == "" || Gonderici_Mask_TxtBx.Text == "" || Alici_AdTxtBx.Text == "" || Alici_TelMasked_TxtBx.Text == "" || Cikis_Sube_cmboBx.Text == "" || Varis_Subesi_CmboBx.Text == "" || OdemeTuruComboBx.Text == "" || KargoAdres_TxtBx.Text == "")
            {
                errorProvider1.SetError(KargoNumarasiTxTbx, "Boş Geçilemez");
                errorProvider1.SetError(GondericiAdTxtBx, "Boş Geçilemez");
                errorProvider1.SetError(Gonderici_Mask_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(Alici_AdTxtBx, "Boş Geçilemez");
                errorProvider1.SetError(Alici_TelMasked_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(Varis_Subesi_CmboBx, "Boş Geçilemez");
                errorProvider1.SetError(Cikis_Sube_cmboBx, "Boş Geçilemez");
                errorProvider1.SetError(OdemeTuruComboBx, "Boş Geçilemez");
                errorProvider1.SetError(KargoAdres_TxtBx, "Boş Geçilemez");
            }
            else
            {
                kargo.Kargo_Guncelle(KargoNumarasiTxTbx.Text, GondericiAdTxtBx.Text, Gonderici_Mask_TxtBx.Text, Alici_AdTxtBx.Text, Alici_TelMasked_TxtBx.Text, Cikis_Sube_cmboBx.Text, Varis_Subesi_CmboBx.Text, OdemeTuruComboBx.Text, CikisTarihiDTimePicker.Value, KargoCinsiCmboBx.Text,float.Parse(KargoKilo_Txtbox.Text), Convert.ToInt32(PaketSayisi_TxtBx.Text), KargoAdres_TxtBx.Text, float.Parse(KargoFiyat_TxtBx.Text));
                kargo.Kargo_Listele(KargoBilgileriDataGridView);
            }
        }

        private void KargoNumarasiTxTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void KargoKilo_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PaketSayisi_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void KargoBilgileriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KargoNumarasiTxTbx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[0].Value.ToString();
            GondericiAdTxtBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[1].Value.ToString();
            Gonderici_Mask_TxtBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[2].Value.ToString();
            Alici_AdTxtBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[3].Value.ToString();
            Alici_TelMasked_TxtBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[4].Value.ToString();
            Cikis_Sube_cmboBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[5].Value.ToString();
            Varis_Subesi_CmboBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[6].Value.ToString();
            OdemeTuruComboBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[7].Value.ToString();
            CikisTarihiDTimePicker.Value =DateTime.Parse(KargoBilgileriDataGridView.CurrentRow.Cells[8].Value.ToString());
            KargoCinsiCmboBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[9].Value.ToString();
            KargoKilo_Txtbox.Text = KargoBilgileriDataGridView.CurrentRow.Cells[10].Value.ToString();
            PaketSayisi_TxtBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[11].Value.ToString();
            KargoAdres_TxtBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[12].Value.ToString();
            KargoFiyat_TxtBx.Text = KargoBilgileriDataGridView.CurrentRow.Cells[13].Value.ToString();
        }

        private void Kargo_Numara_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AranacakBilgiTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
