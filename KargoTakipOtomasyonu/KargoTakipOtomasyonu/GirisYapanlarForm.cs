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
    public partial class GirisYapanlarForm : Form
    {
        public GirisYapanlarForm()
        {
            InitializeComponent();
        }
        GirisYapanKullanicilar girisyapan = new GirisYapanKullanicilar();
        private void GY_Gorev_CmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            girisyapan.Arama_Yetki(GirisYapanlarDataGridView,GY_Gorev_CmbBx.Text);
        }

        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GirisYapanlarForm_Load(object sender, EventArgs e)
        {
            girisyapan.Giris_Yapanlari_Listele(GirisYapanlarDataGridView);
        }

        private void TarihDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            girisyapan.Arama_Tarih(GirisYapanlarDataGridView, TarihDateTimePicker.Value);
        }
    }
}
