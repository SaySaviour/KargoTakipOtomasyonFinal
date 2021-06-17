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
    public partial class KargoDurumForm : Form
    {
        public KargoDurumForm()
        {
            InitializeComponent();
        }
        KargoDurumu durum = new KargoDurumu();
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DurumKaydetBtn_Click(object sender, EventArgs e)
        {
            if (KargoNumarasiEk_TxtBx.Text == "" || GonderiDurumCmboBx.Text == "" || LokasyonTxtBx.Text == "")
            {
                errorProvider1.SetError(KargoNumarasiEk_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(GonderiDurumCmboBx, "Boş Geçilemez");
                errorProvider1.SetError(LokasyonTxtBx, "Boş Geçilemez");
            }
            else
            {
                durum.Kargo_Durum_Ekle(KargoNumarasiEk_TxtBx.Text, GonderiDurumCmboBx.Text, IslemZamanDateTimePicker.Value, LokasyonTxtBx.Text);
                durum.Listele(KargoDurumDataGridView);
            }
        }

        private void KargoDurumForm_Load(object sender, EventArgs e)
        {
            durum.Listele(KargoDurumDataGridView);
        }

        private void Kargo_Numarasi_TxtBx_TextChanged(object sender, EventArgs e)
        {
            if (Kargo_Numarasi_TxtBx.Text == "")
                durum.Listele(KargoDurumDataGridView);
            else
                durum.Kargo_Durum_Arama_Kargo_No(KargoDurumDataGridView, Kargo_Numarasi_TxtBx.Text);
        }

        private void KargoNumarasiEk_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Kargo_Numarasi_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
