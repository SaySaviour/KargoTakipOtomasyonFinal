using System;
using System.Windows.Forms;
using KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri;

namespace KargoTakipOtomasyonu
{
    public partial class SifreUnutForm : Form
    {
        public SifreUnutForm()
        {
            InitializeComponent();
        }
        SifreUnut sfrunut = new SifreUnut();
        private void rastgelesayiuret()
        {
            Random rnd = new Random();
            double sayi =rnd.Next(10000,99999999);
            GvnlkKodLabel.Text = sayi.ToString();
        }
        private void SifreUnutForm_Load(object sender, EventArgs e)
        {
            rastgelesayiuret();
        }

        private void SifreDegis_Btn_Click(object sender, EventArgs e)
        {
            if(K_AdiTxtBx.Text==""|| Sifre_TxtBx.Text=="" || SifreTek_TxtBx.Text==""|| GvnlKod_TxtBx.Text=="")
            {
                errorProvider1.SetError(K_AdiTxtBx, "Boş Geçilemez !");
                errorProvider1.SetError(Sifre_TxtBx, "Boş Geçilemez !");
                errorProvider1.SetError(SifreTek_TxtBx, "Boş Geçilemez !");
                errorProvider1.SetError(GvnlKod_TxtBx, "Boş Geçilemez !");
            }
            else
            {
                if (yntcRadioBtn.Checked == true)
                {
                    if (GvnlKod_TxtBx.Text == GvnlkKodLabel.Text)
                    {
                        sfrunut.Yonetici_KullaniciAdi_Sifre_Degistir(K_AdiTxtBx.Text, Sifre_TxtBx.Text);
                    }
                    else
                        MessageBox.Show("Güvenik Kodunu Doğru Giriniz !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (prsnlRadioBtn.Checked == true)
                {
                    if (GvnlKod_TxtBx.Text == GvnlkKodLabel.Text)
                        sfrunut.Personel_KullaniciAdi_Sifre_Degistir(K_AdiTxtBx.Text, Sifre_TxtBx.Text);
                    else
                    {
                        MessageBox.Show("Güvenik Kodunu Doğru Giriniz !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rastgelesayiuret();
                    }
                }
                else
                    MessageBox.Show("Lütfen Değiştirmek İstediğiniz Kullanıcıyı İşaretleyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GvnlKod_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
