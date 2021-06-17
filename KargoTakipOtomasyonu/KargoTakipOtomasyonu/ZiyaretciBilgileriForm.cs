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
    public partial class ZiyaretciBilgileriForm : Form
    {
        public ZiyaretciBilgileriForm()
        {
            InitializeComponent();
        }
        ZiyaretciBilgileri zyrtci = new ZiyaretciBilgileri();
        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ZiyaretciBilgileriForm_Load(object sender, EventArgs e)
        {
            zyrtci.Ziyaretci_Listele(zyrtcidatagrid);
        }

        private void ZS_Sil_Btn_Click(object sender, EventArgs e)
        {
            if (ZS_TC_TxtBx.Text == "")
                errorProvider1.SetError(ZS_TC_TxtBx, "Silmek İçin Tc Giriniz");
            else
            {
                zyrtci.Ziyaretci_Sil(ZS_TC_TxtBx.Text);
                zyrtci.Ziyaretci_Listele(zyrtcidatagrid);
            }
        }

        private void ZS_TC_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ZA_TC_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ZA_Ad_TxtBx_TextChanged(object sender, EventArgs e)
        {
            if (ZA_Ad_TxtBx.Text == "")
                zyrtci.Ziyaretci_Listele(zyrtcidatagrid);
            else
                zyrtci.Ziyaretci_Arama_Ad(zyrtcidatagrid, ZA_Ad_TxtBx.Text);
        }

        private void ZA_TC_TxtBx_TextChanged(object sender, EventArgs e)
        {
            if (ZA_TC_TxtBx.Text == "")
                zyrtci.Ziyaretci_Listele(zyrtcidatagrid);
            else
                zyrtci.Ziyaretci_Arama_TC(zyrtcidatagrid,ZA_TC_TxtBx.Text);
        }
    }
}
