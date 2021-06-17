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
    public partial class CikisYapanlarForm : Form
    {
        public CikisYapanlarForm()
        {
            InitializeComponent();
        }
        CikisYapanKullanicilar cikisyapan = new CikisYapanKullanicilar();
        private void CY_Gorev_TxtBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cikisyapan.Arama_Yetki(CikisYapanlar_DataGridView, CY_Gorev_TxtBx.Text);
        }

        private void TarihDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            cikisyapan.Arama_Tarih(CikisYapanlar_DataGridView, TarihDateTimePicker.Value);
        }

        private void CikisYapanlarForm_Load(object sender, EventArgs e)
        {
            cikisyapan.Cikis_Yapanlari_Listele(CikisYapanlar_DataGridView);
        }

        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
