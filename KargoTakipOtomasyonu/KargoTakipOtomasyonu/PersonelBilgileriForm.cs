using System;
using System.Windows.Forms;
using KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri;

namespace KargoTakipOtomasyonu
{
    public partial class PersonelBilgileriForm : Form
    {
        public PersonelBilgileriForm()
        {
            InitializeComponent();
        }
        PersonelBilgiler personel = new PersonelBilgiler();
        private void Kapat_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PersonelBilgileriForm_Load(object sender, EventArgs e)
        {
            personel.Personel_Listele(Personel_Listele_DataGridView);
        }

        private void PEG_Ekle_Btn_Click(object sender, EventArgs e)
        {
            if (PEG_ID_TxtBx.Text == "" || PEG_TC_TxtBx.Text == "" || PEG_KAdi_TxtBx.Text==""|| PEG_Sifre_TxtBx.Text==""|| PEG_Ad_TxtBx.Text==""|| PEG_Soyad_TxtBx.Text==""||PEG_Gorev_TxtBx.Text==""||PEG_Tel_TxtBx.Text==""|| PEG_Adres_TxtBx.Text=="")
            {
                errorProvider1.SetError(PEG_ID_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_TC_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_KAdi_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Sifre_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Ad_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Soyad_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Gorev_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Tel_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Adres_TxtBx, "Boş Geçilemez");
            }
            else
            {
                personel.PersonelEkle(PEG_TC_TxtBx.Text,PEG_KAdi_TxtBx.Text,PEG_Sifre_TxtBx.Text,PEG_Ad_TxtBx.Text,PEG_Soyad_TxtBx.Text,PEG_Gorev_TxtBx.Text,PEG_Tel_TxtBx.Text,PEG_Adres_TxtBx.Text);
                personel.Personel_Listele(Personel_Listele_DataGridView);
            }
        }

        private void PEG_Guncelle_Btn_Click(object sender, EventArgs e)
        {
            PEG_ID_TxtBx.Enabled = true;
            if (PEG_ID_TxtBx.Text == "" || PEG_TC_TxtBx.Text == "" || PEG_KAdi_TxtBx.Text == "" || PEG_Sifre_TxtBx.Text == "" || PEG_Ad_TxtBx.Text == "" || PEG_Soyad_TxtBx.Text == "" || PEG_Gorev_TxtBx.Text == "" || PEG_Tel_TxtBx.Text == "" || PEG_Adres_TxtBx.Text == "")
            {
                errorProvider1.SetError(PEG_ID_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_TC_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_KAdi_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Sifre_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Ad_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Soyad_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Gorev_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Tel_TxtBx, "Boş Geçilemez");
                errorProvider1.SetError(PEG_Adres_TxtBx, "Boş Geçilemez");
            }
            else
            {
                personel.Personel_Guncelle(Convert.ToInt32(PEG_ID_TxtBx.Text),PEG_TC_TxtBx.Text, PEG_KAdi_TxtBx.Text, PEG_Sifre_TxtBx.Text, PEG_Ad_TxtBx.Text, PEG_Soyad_TxtBx.Text, PEG_Gorev_TxtBx.Text, PEG_Tel_TxtBx.Text, PEG_Adres_TxtBx.Text);
                personel.Personel_Listele(Personel_Listele_DataGridView);
            }
        }

        private void PEG_YeniK_Btn_Click(object sender, EventArgs e)
        {
            PEG_ID_TxtBx.Enabled = false;
            PEG_ID_TxtBx.Clear();
            PEG_TC_TxtBx.Clear();
            PEG_KAdi_TxtBx.Clear();
            PEG_Sifre_TxtBx.Clear();
            PEG_Ad_TxtBx.Clear();
            PEG_Soyad_TxtBx.Clear();
            PEG_Tel_TxtBx.Clear();
            PEG_Adres_TxtBx.Clear();
        }

        private void PAS_Prsnl_ID_TxtBx_TextChanged(object sender, EventArgs e)
        {
            if (PAS_Prsnl_ID_TxtBx.Text == "")
                personel.Personel_Listele(Personel_Listele_DataGridView);
            else
                personel.Personel_Arama_ID(Personel_Listele_DataGridView, Convert.ToInt32(PAS_Prsnl_ID_TxtBx.Text));
        }

        private void PAS_TC_TxtBx_TextChanged(object sender, EventArgs e)
        {
            if (PAS_TC_TxtBx.Text == "")
                personel.Personel_Listele(Personel_Listele_DataGridView);
            else
                personel.Personel_Arama_TC(Personel_Listele_DataGridView,PAS_TC_TxtBx.Text);
        }

        private void PAS_Ad_TxtBx_TextChanged(object sender, EventArgs e)
        {
            if (PAS_Ad_TxtBx.Text == "")
                personel.Personel_Listele(Personel_Listele_DataGridView);
            else
                personel.Personel_Arama_Ad(Personel_Listele_DataGridView, PAS_Ad_TxtBx.Text);
        }

        private void PAS_Sil_Btn_Click(object sender, EventArgs e)
        {
            if (PAS_ID_Sil_TxtBx.Text == "")
                errorProvider1.SetError(PAS_ID_Sil_TxtBx, "Boş Geçemezsiniz!!!!");
            else
            {
                personel.Personel_Sil(PAS_ID_Sil_TxtBx.Text);
                personel.Personel_Listele(Personel_Listele_DataGridView);
            }
                
        }

        private void Personel_Listele_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PEG_ID_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[0].Value.ToString();
            PEG_TC_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[1].Value.ToString();
            PEG_KAdi_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[2].Value.ToString();
            PEG_Sifre_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[3].Value.ToString();
            PEG_Ad_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[4].Value.ToString();
            PEG_Soyad_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[5].Value.ToString();
            PEG_Gorev_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[6].Value.ToString();
            PEG_Tel_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[7].Value.ToString();
            PEG_Adres_TxtBx.Text = Personel_Listele_DataGridView.CurrentRow.Cells[8].Value.ToString();
        }

        private void PAS_Prsnl_ID_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PAS_TC_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PAS_ID_Sil_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PEG_TC_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PEG_ID_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PEG_Tel_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
 }

