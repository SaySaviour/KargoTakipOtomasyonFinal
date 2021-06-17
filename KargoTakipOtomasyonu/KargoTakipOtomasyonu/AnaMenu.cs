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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        KullaniciGiris kullanici_giris = new KullaniciGiris();
        CikisYapanKullanicilar cikisyapan = new CikisYapanKullanicilar();
        public string yetki;
        private void zaman_Tick(object sender, EventArgs e)
        {
            TarihLabel.Text = DateTime.Now.ToShortDateString();
            SaatLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            zaman.Start();
        }

        private void KargoBilgiBtn_Click(object sender, EventArgs e)
        {
            KargoBilgileriForm frm = new KargoBilgileriForm();
            frm.ShowDialog();
        }

        private void KargoEkleBtn_Click(object sender, EventArgs e)
        {
            KargoEkleForm frm = new KargoEkleForm();
            frm.ShowDialog();
        }

        private void KargoNerdeBtn_Click(object sender, EventArgs e)
        {
            KargoDurumForm frm = new KargoDurumForm();
            frm.ShowDialog();
        }

        private void TeslmEdilmeyenKargoBtn_Click(object sender, EventArgs e)
        {
            TeslimEdilmeyenKargoForm frm = new TeslimEdilmeyenKargoForm();
            frm.ShowDialog();
        }

        private void KargomNerdeBtn_Click(object sender, EventArgs e)
        {
            KargomNeredeForm frm = new KargomNeredeForm();
            frm.ShowDialog();
        }

        private void YBilgiBtn_Click(object sender, EventArgs e)
        {
            YoneticiBilgileriForm frm = new YoneticiBilgileriForm();
            frm.ShowDialog();
        }

        private void PBilgiBtn_Click(object sender, EventArgs e)
        {
            PersonelBilgileriForm frm = new PersonelBilgileriForm();
            frm.ShowDialog();
        }

        private void ZBilgiBtn_Click(object sender, EventArgs e)
        {
            ZiyaretciBilgileriForm frm = new ZiyaretciBilgileriForm();
            frm.ShowDialog();
        }

        private void UygulamayaGirisYapanKToolStripMenu_Click(object sender, EventArgs e)
        {
            GirisYapanlarForm frm = new GirisYapanlarForm();
            frm.ShowDialog();
        }

        private void UygulamadanCikisYapanKToolStripMenu_Click(object sender, EventArgs e)
        {
            CikisYapanlarForm frm = new CikisYapanlarForm();
            frm.ShowDialog();
        }

        private void UygulamadanCikToolStripMenu_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = new DialogResult();
            mesaj = MessageBox.Show("Uygulama Kapatılsın mı ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                cikisyapan.Cikis_Yapti(yetki, DateTime.Now);
                if (KargoNerdeBtn.Enabled == false)
                    KargoNerdeBtn.Enabled = true;
                if (PBilgiBtn.Enabled == false)
                    PBilgiBtn.Enabled = true;
                if (YBilgiBtn.Enabled == false)
                    YBilgiBtn.Enabled = true;
                if (KargoBilgiBtn.Enabled == false)
                    KargoBilgiBtn.Enabled = true;
                if (TeslmEdilmeyenKargoBtn.Enabled == false)
                    TeslmEdilmeyenKargoBtn.Enabled = true;
                if (KargoEkleBtn.Enabled == false)
                    KargoEkleBtn.Enabled = true;
                Application.Exit();
            }
                
        }

        private void OturumuKapatToolStripMenu_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = new DialogResult();
            mesaj = MessageBox.Show("Oturum Kapatılsın mı ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mesaj==DialogResult.Yes)
            {
                cikisyapan.Cikis_Yapti(yetki, DateTime.Now);
                KullaniciGiris frm = new KullaniciGiris();
                this.Hide();
                if (KargoNerdeBtn.Enabled == false)
                    KargoNerdeBtn.Enabled = true;
                if (PBilgiBtn.Enabled == false)
                    PBilgiBtn.Enabled = true;
                if (YBilgiBtn.Enabled == false)
                    YBilgiBtn.Enabled = true;
                if (KargoBilgiBtn.Enabled == false)
                    KargoBilgiBtn.Enabled = true;
                if (TeslmEdilmeyenKargoBtn.Enabled == false)
                    TeslmEdilmeyenKargoBtn.Enabled = true;
                if (KargoEkleBtn.Enabled == false)
                    KargoEkleBtn.Enabled = true;
                frm.ShowDialog();
            }
        }
    }
}
