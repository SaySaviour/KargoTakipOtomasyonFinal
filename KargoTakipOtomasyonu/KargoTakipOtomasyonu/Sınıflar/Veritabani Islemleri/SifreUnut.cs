using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class SifreUnut
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlCommand SqlKomut;
        SqlDataReader DtReader;
        DataTable tablo = new DataTable();
        DialogResult mesaj;
        bool durum;
        void P_Kontrol(string k_Adi)
        {
            SqlKomut = new SqlCommand("Select * from Persone_Giris where P_Kullanici_Adi=@P_KAd", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@P_KAd",k_Adi);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = false;
            else
                durum = true;
        }
        void Y_Kontrol(string k_Adi)
        {
            SqlKomut = new SqlCommand("Select * from Yonetici_Giris where Y_Kullanici_Adi=@Y_KAd", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@Y_KAd", k_Adi);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = true;
            else
                durum = false;
        }
        public void Yonetici_KullaniciAdi_Sifre_Degistir( string K_Adi, string Sifre)
        {
            mesaj = MessageBox.Show("Kullanıcı Adı - Şifre Güncellensin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Y_Kontrol(K_Adi);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Update Yonetici_Giris set Y_Kullanici_Adi=@Kullanici_Adi,Y_Sifre=@Sifre where Y_Kullanici_Adi=@Y_KAd", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@Kullanici_Adi", K_Adi);
                    SqlKomut.Parameters.AddWithValue("@Sifre", Sifre);
                    SqlKomut.Parameters.AddWithValue("@Y_KAd", K_Adi);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Kullanıcı Adı ve Şifre Başarı ile Değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Böyle Bir Kullanıcı Adına ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Personel_KullaniciAdi_Sifre_Degistir(string K_Adi, string Sifre)
        {
            mesaj = MessageBox.Show("Kullanıcı Adı - Şifre Güncellensin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Y_Kontrol(K_Adi);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Update Personel_Giris set P_Kullanici_Adi=@Kullanici_Adi,P_Sifre=@Sifre where P_Kullanici_Adi=@P_KAd", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@Kullanici_Adi", K_Adi);
                    SqlKomut.Parameters.AddWithValue("@Sifre", Sifre);
                    SqlKomut.Parameters.AddWithValue("@P_KAd", K_Adi);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Kullanıcı Adı ve Şifre Başarı ile Değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Böyle Bir Kullanıcı Adına ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
