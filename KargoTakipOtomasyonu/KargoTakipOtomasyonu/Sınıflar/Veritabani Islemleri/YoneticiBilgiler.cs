using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class YoneticiBilgiler
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlDataAdapter DataAdp;
        SqlCommand SqlKomut;
        SqlDataReader DtReader;
        DataTable tablo = new DataTable();
        bool durum;
        DialogResult mesaj;
        void kayitKontrol(string Y_TC)
        {
            SqlKomut = new SqlCommand("Select * from Yonetici_Giris where Y_TCNO=@Y_TC", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@Y_TC", Y_TC);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = true;
            else
                durum = false;
        }
        public void Yonetici_Listele(DataGridView Datagrid)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Yonetici_Giris", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Yonetici_Ekle(int Y_ID,string Y_TC, string Y_KAdi, string Y_Sifre, string Y_Ad, string Y_Soyad, string Y_Tel, string Y_Email)
        {
            mesaj = MessageBox.Show("Yöneticinin Bilgileri Kayıdedilsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(Y_TC);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == false)
                {

                    SqlKomut = new SqlCommand("insert into Yonetici_Giris (Yonetici_ID,Y_TCNO,Y_Kullanici_Adi,Y_Sifre,Y_Ad,Y_Soyad,Y_Telefon,Y_Email) values (@Y_ID,@TC,@Kullanici_Adi,@Sifre,@Ad,@Soyad,@Tel,@Email)", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@Y_ID", Y_ID);
                    SqlKomut.Parameters.AddWithValue("@TC", Y_TC);
                    SqlKomut.Parameters.AddWithValue("@Kullanici_Adi", Y_KAdi);
                    SqlKomut.Parameters.AddWithValue("@Sifre", Y_Sifre);
                    SqlKomut.Parameters.AddWithValue("@Ad", Y_Ad);
                    SqlKomut.Parameters.AddWithValue("@Soyad", Y_Soyad);
                    SqlKomut.Parameters.AddWithValue("@Tel", Y_Tel);
                    SqlKomut.Parameters.AddWithValue("@Email", Y_Email);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Yönetici Bilgileri Başarı ile Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Eklemek İstediğiniz Yönetici Kayıtlı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Yonetici_Guncelle(int Y_ID, string Y_TC, string Y_KAdi, string Y_Sifre, string Y_Ad, string Y_Soyad, string Y_Tel, string Y_Email)
        {
            mesaj = MessageBox.Show("Bilgiler Güncellensin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(Y_TC);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Update Yonetici_Giris set Y_TCNO=@TC,Y_Kullanici_Adi=@Kullanici_Adi,Y_Sifre=@Sifre,Y_Ad=@Ad,Y_Soyad=@Soyad,Y_Telefon=@Tel,Y_Email=@Email where Yonetici_ID=@Y_ID", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@Y_ID", Y_ID);
                    SqlKomut.Parameters.AddWithValue("@TC", Y_TC);
                    SqlKomut.Parameters.AddWithValue("@Kullanici_Adi", Y_KAdi);
                    SqlKomut.Parameters.AddWithValue("@Sifre", Y_Sifre);
                    SqlKomut.Parameters.AddWithValue("@Ad", Y_Ad);
                    SqlKomut.Parameters.AddWithValue("@Soyad", Y_Soyad);
                    SqlKomut.Parameters.AddWithValue("@Tel", Y_Tel);
                    SqlKomut.Parameters.AddWithValue("@Email", Y_Email);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Yönetici Bilgileri Başarı ile Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Böyle Bir TC 'ye Ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Yonetici_Arama_Ad(DataGridView Datagrid,string Y_Ad)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Yonetici_Giris where Y_Ad like '" + Y_Ad + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Yonetici_Arama_ID(DataGridView Datagrid, int Yonetici_ID)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Yonetici_Giris where Yonetici_ID like '" + Yonetici_ID + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Yonetici_Sil(string Y_TC)
        {
            mesaj = MessageBox.Show("Bilgiler Silinsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(Y_TC);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Delete from Yonetici_Giris where Y_TCNO=@Y_TC", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@Y_TC", Y_TC);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Yönetici Bilgileri Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Böyle Bir TC 'ye Ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Yonetici_Giris(string Y_KullaniciAdi, string Y_Sifre)
        {
            SqlKomut = new SqlCommand("Select * from Yonetici_Giris where Y_Kullanici_Adi=@Y_Kullanici_Adi and Y_Sifre=@Sifre", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@Y_Kullanici_Adi", Y_KullaniciAdi);
            SqlKomut.Parameters.AddWithValue("@Sifre", Y_Sifre);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read() == true)
            {
                MessageBox.Show("Giriş Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AnaMenu frm = new AnaMenu();
                frm.yetki = "Yönetici";
                frm.ShowDialog();
                
            }
            else
            {
                KullaniciGiris girisfrm = new KullaniciGiris();
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                girisfrm.ShowDialog();
            }
        }
    }
}
