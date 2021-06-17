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
    public partial class KargoEkleForm : Form
    {
        public KargoEkleForm()
        {
            InitializeComponent();
        }
        KargoBilgileri kargobilgi = new KargoBilgileri();
        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            if (KargoEkNumarasiTxTbx.Text == "" ||EkGondericiAdTxtBx.Text == "" || EkGonderici_Mask_TxtBx.Text == "" || EkAlici_AdTxtBx.Text=="" || EkAlici_TelMasked_TxtBx.Text==""|| EkCikis_Sube_cmboBx.Text==""|| EkVaris_Subesi_CmboBx.Text==""|| EkOdemeTuruComboBx.Text==""|| EkKargoAdres_TxtBx.Text=="")
            {
                errorProvider1.SetError(KargoEkNumarasiTxTbx, "Boş Geçilemez");
                errorProvider1.SetError(EkGondericiAdTxtBx, "Boş Geçilemez");
                errorProvider1.SetError(EkGonderici_Mask_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(EkAlici_AdTxtBx, "Boş Geçilemez");
                errorProvider1.SetError(EkAlici_TelMasked_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(EkVaris_Subesi_CmboBx, "Boş Geçilemez");
                errorProvider1.SetError(EkCikis_Sube_cmboBx, "Boş Geçilemez");
                errorProvider1.SetError(EkOdemeTuruComboBx, "Boş Geçilemez");
                errorProvider1.SetError(EkKargoAdres_TxtBx, "Boş Geçilemez");
            }
            else
                kargobilgi.Kargo_Ekle(KargoEkNumarasiTxTbx.Text, EkGondericiAdTxtBx.Text, EkGonderici_Mask_TxtBx.Text, EkAlici_AdTxtBx.Text, EkAlici_TelMasked_TxtBx.Text, EkCikis_Sube_cmboBx.Text, EkVaris_Subesi_CmboBx.Text, EkOdemeTuruComboBx.Text, EkCikisTarihiDTimePicker.Value, EkKargoCinsiCmboBx.Text,float.Parse(EkKargoKilo_Txtbox.Text),Convert.ToInt32( EkPaketSayisi_TxtBx.Text), EkKargoAdres_TxtBx.Text,float.Parse(EkKargoFiyat_TxtBx.Text));
        }

        private void FiyatHesaplaBtn_Click(object sender, EventArgs e)
        {
            if (EkKargoKilo_Txtbox.Text==""|| EkPaketSayisi_TxtBx.Text==""|| EkKargoCinsiCmboBx.Text=="")
            {
                errorProvider1.SetError(EkKargoKilo_Txtbox, "Boş Geçilemez");
                errorProvider1.SetError(EkPaketSayisi_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(EkKargoCinsiCmboBx, "Boş Geçilemez");
            }
            else
                kargobilgi.Kargo_Fiyat_Hesapla(float.Parse(EkKargoKilo_Txtbox.Text),Convert.ToInt32(EkPaketSayisi_TxtBx.Text), EkKargoCinsiCmboBx.Text, EkKargoFiyat_TxtBx);
        }

        private void KargoEkNumarasiTxTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EkKargoKilo_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EkPaketSayisi_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void YeniKayitBtn_Click(object sender, EventArgs e)
        {
            KargoEkNumarasiTxTbx.Clear();
            EkGondericiAdTxtBx.Clear();
            EkGonderici_Mask_TxtBx.Clear();
            EkAlici_AdTxtBx.Clear();
            EkAlici_TelMasked_TxtBx.Clear();
            EkKargoAdres_TxtBx.Clear();
            EkKargoKilo_Txtbox.Clear();
            EkPaketSayisi_TxtBx.Clear();
            EkKargoFiyat_TxtBx.Clear();
        }
    }
}
