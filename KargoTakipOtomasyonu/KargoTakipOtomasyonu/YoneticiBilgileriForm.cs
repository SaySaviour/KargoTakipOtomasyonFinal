using System;
using System.Windows.Forms;
using KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri;

namespace KargoTakipOtomasyonu
{
    public partial class YoneticiBilgileriForm : Form
    {
        public YoneticiBilgileriForm()
        {
            InitializeComponent();
        }
        YoneticiBilgiler yntc = new YoneticiBilgiler();
        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void YoneticiBilgileriForm_Load(object sender, EventArgs e)
        {
            yntc.Yonetici_Listele(YoneticiListesiDataGridView);
        }

        private void AraYoneticiAdTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (AraYoneticiAdTxtBx.Text == "")
                yntc.Yonetici_Listele(YoneticiListesiDataGridView);
            else
                yntc.Yonetici_Arama_Ad(YoneticiListesiDataGridView, AraYoneticiAdTxtBx.Text);
        }

        private void AraYoneticiID_TextChanged(object sender, EventArgs e)
        {
            if (AraYoneticiID.Text == "")
                yntc.Yonetici_Listele(YoneticiListesiDataGridView);
            else
                yntc.Yonetici_Arama_ID(YoneticiListesiDataGridView,Convert.ToInt32(AraYoneticiID.Text));
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            if (Sil_Yonetici_ID_TxtBx.Text == "")
                errorProvider1.SetError(Sil_Yonetici_ID_TxtBx, "Boş Geçemezsiniz!!!");
            else
            {
                yntc.Yonetici_Sil(Sil_Yonetici_ID_TxtBx.Text);
                yntc.Yonetici_Listele(YoneticiListesiDataGridView);
            }
        }

        private void EG_Ekle_Btn_Click(object sender, EventArgs e)
        {
            if(EGYntc_ID_TxtBx.Text==""|| EG_Yntc_TC_TxtBx.Text=="" || EG_KAdi_TxtBx.Text==""|| EG_Sifre_TxtBx.Text==""|| EG_Ad_TxtBx.Text==""|| EG_Soyad_TxtBx.Text==""|| EG_Tel_TxtBx.Text==""|| EG_EMail_TxtBx.Text=="")
            {
                errorProvider1.SetError(EGYntc_ID_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Yntc_TC_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_KAdi_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Sifre_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Ad_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Soyad_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Tel_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_EMail_TxtBx, "Bu Alanlar Boş Geçilemez.");
            }
            else
            {
                yntc.Yonetici_Ekle(Convert.ToInt32(EGYntc_ID_TxtBx.Text),EG_Yntc_TC_TxtBx.Text, EG_KAdi_TxtBx.Text, EG_Sifre_TxtBx.Text, EG_Ad_TxtBx.Text, EG_Soyad_TxtBx.Text, EG_Tel_TxtBx.Text, EG_EMail_TxtBx.Text);
                yntc.Yonetici_Listele(YoneticiListesiDataGridView);
            }
        }

        private void EG_Guncelle_Btn_Click(object sender, EventArgs e)
        {
            if (EGYntc_ID_TxtBx.Text == "" || EG_Yntc_TC_TxtBx.Text == "" || EG_KAdi_TxtBx.Text == "" || EG_Sifre_TxtBx.Text == "" || EG_Ad_TxtBx.Text == "" || EG_Soyad_TxtBx.Text == "" || EG_Tel_TxtBx.Text == "" || EG_EMail_TxtBx.Text == "")
            {
                errorProvider1.SetError(EGYntc_ID_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Yntc_TC_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_KAdi_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Sifre_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Ad_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Soyad_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_Tel_TxtBx, "Bu Alanlar Boş Geçilemez.");
                errorProvider1.SetError(EG_EMail_TxtBx, "Bu Alanlar Boş Geçilemez.");
            }
            else
            {
                yntc.Yonetici_Guncelle(Convert.ToInt32(EGYntc_ID_TxtBx.Text),EG_Yntc_TC_TxtBx.Text, EG_KAdi_TxtBx.Text, EG_Sifre_TxtBx.Text, EG_Ad_TxtBx.Text, EG_Soyad_TxtBx.Text, EG_Tel_TxtBx.Text, EG_EMail_TxtBx.Text);
                yntc.Yonetici_Listele(YoneticiListesiDataGridView);
            }
        }

        private void EG_Yeni_Btn_Click(object sender, EventArgs e)
        {
            EGYntc_ID_TxtBx.Enabled = true;
            EGYntc_ID_TxtBx.Clear();
            EG_Yntc_TC_TxtBx.Clear();
            EG_KAdi_TxtBx.Clear();
            EG_Sifre_TxtBx.Clear();
            EG_Ad_TxtBx.Clear();
            EG_Soyad_TxtBx.Clear();
            EG_Tel_TxtBx.Clear();
            EG_EMail_TxtBx.Clear();
        }

        private void YoneticiListesiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EGYntc_ID_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[0].Value.ToString();
            EG_Yntc_TC_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[1].Value.ToString();
            EG_KAdi_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[2].Value.ToString();
            EG_Sifre_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[3].Value.ToString();
            EG_Ad_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[4].Value.ToString();
            EG_Soyad_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[5].Value.ToString();
            EG_Tel_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[6].Value.ToString();
            EG_EMail_TxtBx.Text = YoneticiListesiDataGridView.CurrentRow.Cells[7].Value.ToString();
        }

        private void AraYoneticiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Sil_Yonetici_ID_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EGYntc_ID_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EG_Yntc_TC_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EG_Tel_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
