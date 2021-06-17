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
    public partial class KargomNeredeForm : Form
    {
        public KargomNeredeForm()
        {
            InitializeComponent();
        }
        KargoDurumu drm = new KargoDurumu();
        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KNFAraBtn_Click(object sender, EventArgs e)
        {
            drm.Kargo_Durum_Arama_Kargo_No(KNFDataGridView, KNFKargoTNo_TxtBx.Text);
        }

        private void KNFKargoTNo_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
