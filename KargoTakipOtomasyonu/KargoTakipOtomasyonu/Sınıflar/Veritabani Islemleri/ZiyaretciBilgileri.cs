using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class ZiyaretciBilgileri
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlDataAdapter DataAdp;
        SqlCommand SqlKomut;
        SqlDataReader DtReader;
        DataTable tablo = new DataTable();
        DialogResult mesaj;
        bool durum;
        void kayitKontrol(string Z_TC)
        {
            SqlKomut = new SqlCommand("Select * from Ziyaretci_Giris where Ziyaretci_TC=@Z_TC", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@Z_TC", Z_TC);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = true;
            else
                durum = false;
        }
        private void Ziyaretci_Ekle(string tc,string ad,string soyad)
        {
            kayitKontrol(tc);
            if (durum == false)
            {

                SqlKomut = new SqlCommand("insert into Ziyaretci_Giris (Ziyaretci_TC,Ziyaretci_Adi,Ziyaretci_Soyad) values (@Z_TC,@Z_Ad,@Z_Soyad)", B.baglanti());
                SqlKomut.Parameters.AddWithValue("@Z_TC", tc);
                SqlKomut.Parameters.AddWithValue("@Z_Ad", ad);
                SqlKomut.Parameters.AddWithValue("@Z_Soyad", soyad);
                SqlKomut.ExecuteNonQuery();
                B.baglanti().Close();
            }
        }
        public void Ziyaretci_Arama_Ad(DataGridView DataGrid,string ad)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Ziyaretci_Giris where Ziyaretci_Adi like '" + ad + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            DataGrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Ziyaretci_Arama_TC(DataGridView DataGrid, string tc)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Ziyaretci_Giris where Ziyaretci_TC like '" + tc + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            DataGrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Ziyaretci_Sil(string tc)
        {
            mesaj = MessageBox.Show("Bilgiler Silinsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(tc);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Delete from Ziyaretci_Giris where Ziyaretci_TC=@Z_TC", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@Z_TC", tc);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Ziyaretçi Bilgileri Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else
                    MessageBox.Show("Böyle Bir TC 'ye Ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Ziyaretci_Listele(DataGridView Datagrid)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Ziyaretci_Giris", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Ziyaretci_Giris(string tc,string ad,string soyad)
        {
            Ziyaretci_Ekle(tc,ad,soyad);
            MessageBox.Show("Giriş Başarılı Ana Menüye Yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            AnaMenu frm = new AnaMenu();
            frm.yetki = "Ziyaretçi";
            frm.KargoBilgiBtn.Enabled = false;
            frm.KargoEkleBtn.Enabled = false;
            frm.KargoNerdeBtn.Enabled = false;
            frm.TeslmEdilmeyenKargoBtn.Enabled = false;
            frm.PBilgiBtn.Enabled = false;
            frm.YBilgiBtn.Enabled = false;
            frm.ShowDialog();
        }
    }
}
