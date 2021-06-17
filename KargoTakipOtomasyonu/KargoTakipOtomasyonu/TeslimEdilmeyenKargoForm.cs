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
    public partial class TeslimEdilmeyenKargoForm : Form
    {
        public TeslimEdilmeyenKargoForm()
        {
            InitializeComponent();
        }
        TeslimEdilmeyenKargoBilgileri tslmedlmynkargo = new TeslimEdilmeyenKargoBilgileri();
        private void TeslimEdilmeyenKargoForm_Load(object sender, EventArgs e)
        {
            tslmedlmynkargo.TE_Kargo_Listele(dataGridView1);
        }

        private void TEEkleBtn_Click(object sender, EventArgs e)
        {
            tslmedlmynkargo.TE_Kargo_Ekle(TEKargoNo_TxtBx.Text, TEtarih_DateTimePicker.Value,TEAciklamaTxtBx.Text, TENedeniTxtBx.Text);
            tslmedlmynkargo.TE_Kargo_Listele(dataGridView1);
        }

        private void KargoNumarasiAramaTxtBx_TextChanged(object sender, EventArgs e)
        {
            if(KargoNumarasiAramaTxtBx.Text=="")
            {
                tslmedlmynkargo.TE_Kargo_Listele(dataGridView1);
            }
            else
                tslmedlmynkargo.TE_Kargo_Arama_KargoNo(dataGridView1,KargoNumarasiAramaTxtBx.Text);

        }

        private void KargoTarhiAramaDateTimeP_ValueChanged(object sender, EventArgs e)
        {
            tslmedlmynkargo.TE_Kargo_Arama_Tarih(dataGridView1, KargoTarhiAramaDateTimeP.Value);
        }

        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KargoNumarasiAramaTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TEKargoNo_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
