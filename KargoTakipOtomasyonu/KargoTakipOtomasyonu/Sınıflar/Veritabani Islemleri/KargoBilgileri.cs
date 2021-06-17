using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class KargoBilgileri
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlDataAdapter DataAdp;
        SqlCommand SqlKomut;
        SqlDataReader DtReader;
        DataTable tablo = new DataTable();
        DialogResult mesaj;
        bool durum;
        void Kargo_KayitKontrol(string kargono)
        {
            SqlKomut = new SqlCommand("Select * from Kargo_Bilgileri where Kargo_No=@kargono", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@kargono", kargono);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = true;
            else
                durum = false;
        }
        public void Kargo_Listele(DataGridView Datagrid)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Kargo_Bilgileri", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Kargo_Ekle(string Kargono, string GondericiAdSoyad, string GondericiTel, string AliciAdSoyad, string AliciTel, string Cikis_Sube,
                                string Varis_Sube, string Odm_Tur, DateTime cikis_tarih, string kargocins, float desi, int paketsayi, string kargoadres, float fiyat)
        {
            mesaj = MessageBox.Show("Yeni Kargo Kaydedilsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Kargo_KayitKontrol(Kargono);
            if (mesaj == DialogResult.Yes)
            {
                if (durum ==false)
                {

                    SqlKomut = new SqlCommand("insert into Kargo_Bilgileri (Kargo_No,Gonderici_Ad_Soyad,Gonderici_Telefon,Alici_Ad_Soyad,Alici_Telefon,Cikis_Subesi,Varis_Subesi,Odeme_Turu,Cikis_Tarihi,Kargo_Cinsi,Kargo_Kg_Desi,Paket_Sayisi,Kargo_Adres,Kargo_Fiyat)" +
                        "values (@kargono,@g_adsoyad,@g_tel,@a_adsoyad,@a_tel,@cikissube,@varissube,@odmturu,@tarih,@cins,@desi,@paketsayi,@adres,@fiyat)", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@kargono", Kargono);
                    SqlKomut.Parameters.AddWithValue("@g_adsoyad", GondericiAdSoyad);
                    SqlKomut.Parameters.AddWithValue("@g_tel", GondericiTel);
                    SqlKomut.Parameters.AddWithValue("@a_adsoyad", AliciAdSoyad);
                    SqlKomut.Parameters.AddWithValue("@a_tel", AliciTel);
                    SqlKomut.Parameters.AddWithValue("@cikissube", Cikis_Sube);
                    SqlKomut.Parameters.AddWithValue("@varissube", Varis_Sube);
                    SqlKomut.Parameters.AddWithValue("@odmturu", Odm_Tur);
                    SqlKomut.Parameters.AddWithValue("@tarih", cikis_tarih);
                    SqlKomut.Parameters.AddWithValue("@cins", kargocins);
                    SqlKomut.Parameters.AddWithValue("@desi", desi);
                    SqlKomut.Parameters.AddWithValue("@paketsayi", paketsayi);
                    SqlKomut.Parameters.AddWithValue("@adres", kargoadres);
                    SqlKomut.Parameters.AddWithValue("@fiyat", fiyat);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Kargo Bilgileri Başarı ile Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Bu Kargo Daha Önce Kayıt Edilmiş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Kargo_Guncelle(string Kargono, string GondericiAdSoyad, string GondericiTel, string AliciAdSoyad, string AliciTel, string Cikis_Sube,
                                string Varis_Sube, string Odm_Tur, DateTime cikis_tarih, string kargocins, float desi, int paketsayi, string kargoadres, float fiyat)
        {
            mesaj = MessageBox.Show("Kargo Bilgileri Güncellensin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Kargo_KayitKontrol(Kargono);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == true)
                {

                    SqlKomut = new SqlCommand("Update Kargo_Bilgileri set Gonderici_Ad_Soyad=@g_adsoyad,Gonderici_Telefon=@g_tel,Alici_Ad_Soyad=@a_adsoyad,Alici_Telefon=@a_tel,Cikis_Subesi=@cikissube,Varis_Subesi=@varissube,Odeme_Turu=@odmturu," +
                        "Cikis_Tarihi=@tarih,Kargo_Cinsi=@cins,Kargo_Kg_Desi=@desi,Paket_Sayisi=@paketsayi,Kargo_Adres=@adres,Kargo_Fiyat=@fiyat where Kargo_No=@kargono", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@kargono", Kargono);
                    SqlKomut.Parameters.AddWithValue("@g_adsoyad", GondericiAdSoyad);
                    SqlKomut.Parameters.AddWithValue("@g_tel", GondericiTel);
                    SqlKomut.Parameters.AddWithValue("@a_adsoyad", AliciAdSoyad);
                    SqlKomut.Parameters.AddWithValue("@a_tel", AliciTel);
                    SqlKomut.Parameters.AddWithValue("@cikissube", Cikis_Sube);
                    SqlKomut.Parameters.AddWithValue("@varissube", Varis_Sube);
                    SqlKomut.Parameters.AddWithValue("@odmturu", Odm_Tur);
                    SqlKomut.Parameters.AddWithValue("@tarih", cikis_tarih);
                    SqlKomut.Parameters.AddWithValue("@cins", kargocins);
                    SqlKomut.Parameters.AddWithValue("@desi", desi);
                    SqlKomut.Parameters.AddWithValue("@paketsayi", paketsayi);
                    SqlKomut.Parameters.AddWithValue("@adres", kargoadres);
                    SqlKomut.Parameters.AddWithValue("@fiyat", fiyat);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Kargo Bilgileri Başarı ile Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Kargo Numarasına Ait Kayıt Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Kargo_Sil(string kargono)
        {
            mesaj = MessageBox.Show("Kargo Bilgileri Silinsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Kargo_KayitKontrol(kargono);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Delete from Kargo_Bilgileri where Kargo_No=@kargono", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@kargono", kargono);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Kargo Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Bu Numaraya Ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Secilen_Kargo_Sil(DataGridView DataGrid)
        {
            foreach (DataGridViewRow draw in DataGrid.SelectedRows)
            {
                string kargono =draw.Cells[0].Value.ToString();
                Kargo_Sil(kargono);
            }
        }
        public void Kargo_Arama_KargoNo(DataGridView Datagrid, string kargono)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Kargo_Bilgileri where Kargo_No like '" + kargono + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Kargo_Arama_GndrcAdSoyad(DataGridView Datagrid, string G_Adsoyad)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Kargo_Bilgileri where Gonderici_Ad_Soyad like '" + G_Adsoyad + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Kargo_Fiyat_Hesapla(float kg_desi,int paketsayi,string kargocins,TextBox fiyat_Txtbx)
        {
            double fiyat;
            if (kargocins== "Dosya/Evrak(0-500gr)")
            {
                fiyat =  7 * paketsayi;
            }
            else
            {
                fiyat = (kg_desi * 9) * paketsayi;
            }
            fiyat_Txtbx.Text = fiyat.ToString();
        }
    }
}
