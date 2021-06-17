using System;
using System.Windows.Forms;
using KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri;
//burda eklemiş olduğum sınıfları çağırmak için kullandığım cümle
namespace KargoTakipOtomasyonu
{
    public partial class KullaniciGiris : Form
    {
        
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        //Kullanıcak olduğum sınıflardan nesneler ürettim.
        YoneticiBilgiler yntc = new YoneticiBilgiler();
        GirisYapanKullanicilar grs = new GirisYapanKullanicilar();
        PersonelBilgiler prsnl = new PersonelBilgiler();
        ZiyaretciBilgileri zyrtci = new ZiyaretciBilgileri();
        public string yetki;
        //Yönetici Giriş Buttonu
        private void YntcGirisBtn_Click(object sender, EventArgs e)
        {
            if (YntcKullanicitxtbox.Text == "" || YntcSifretxtbox.Text == "")
            {
                errorProvider1.SetError(YntcKullanicitxtbox, "Boş Geçilemez");
                errorProvider1.SetError(YntcSifretxtbox, "Boş Geçilemez");
            }
            else
            {
                
                yetki = "Yönetici";
                this.Hide();
                grs.Giris_Yapti(yetki, DateTime.Now);
                yntc.Yonetici_Giris(YntcKullanicitxtbox.Text, YntcSifretxtbox.Text);
            }
           
        }
        //Yönetici Şifre Unuttum Buttonu
        private void YntcSifreUntbtn_Click(object sender, EventArgs e)
        {
            SifreUnutForm frm = new SifreUnutForm();
            frm.ShowDialog();
        }
        //Personel Giriş Buttonu
        private void PrsonelGirisBtn_Click(object sender, EventArgs e)
        {
            if(PrsnlKAditxtbx.Text=="" || PrsnlSifretxtbx.Text=="" )
            {
                errorProvider1.SetError(PrsnlKAditxtbx, "Bu alan Boş Geçilemez");
                errorProvider1.SetError(PrsnlSifretxtbx, "Bu alan Boş Geçilemez");
            }
            else
            {
                yetki = "Personel";
                this.Hide();
                grs.Giris_Yapti(yetki, DateTime.Now);
                prsnl.Personel_Giris(PrsnlKAditxtbx.Text, PrsnlSifretxtbx.Text);
            }
            
        }
        //Personel Şifre Unuttum Buttonu
        private void PrsnlSifreUNUTbtn_Click(object sender, EventArgs e)
        {
            SifreUnutForm frm = new SifreUnutForm();
            frm.ShowDialog();
        }
        //Ziyaretçi Giriş Buttonu
        private void ZyrtcGirisbtn_Click(object sender, EventArgs e)
        {
            if (ZyrtcTCnotxtbx.Text == "" || ZyrtcAdtxtbx.Text == "" || ZyrtcSoyadtxtbx.Text=="")
            {
                errorProvider1.SetError(ZyrtcTCnotxtbx, "Boş Geçilemez");
                errorProvider1.SetError(ZyrtcAdtxtbx, "Boş Geçilemez");
                errorProvider1.SetError(ZyrtcSoyadtxtbx, "Boş Geçilemez");
            }
            else
            {
                yetki = "Ziyaretçi";
                this.Hide();
                grs.Giris_Yapti(yetki, DateTime.Now);
                zyrtci.Ziyaretci_Giris(ZyrtcTCnotxtbx.Text, ZyrtcAdtxtbx.Text, ZyrtcSoyadtxtbx.Text);
            }
            
        }
        //Uygulamadan Çıkış Buttonu
        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Sadece Sayı Girişi Kontrolü
        private void ZyrtcTCnotxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
