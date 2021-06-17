using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    
    class PersonelBilgiler
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlDataAdapter DataAdp;
        SqlCommand SqlKomut;
        SqlDataReader DtReader;
        DataTable tablo=new DataTable();
        DialogResult mesaj;
        bool durum;
         void kayitKontrol(string P_TC)
        {
            SqlKomut = new SqlCommand("Select * from Personel_Giris where P_TC=@P_TC", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@P_TC", P_TC);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = true;
            else
                durum = false;
        }
        public void PersonelEkle(string P_TC,string P_KAdi,string P_Sifre,string P_Ad,string P_Soyad,string P_Gorev,string P_Tel,string P_Adres)
        {
            mesaj = MessageBox.Show("Bilgiler Kayıdedilsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(P_TC);
            if(mesaj==DialogResult.Yes)
            {
                if (durum == false)
                {

                    SqlKomut = new SqlCommand("insert into Personel_Giris (P_TC,P_Kullanici_Adi,P_Sifre,P_Ad,P_Soyad,P_Gorev,P_Telefon,P_Adres) values (@TC,@Kullanici_Adi,@Sifre,@Ad,@Soyad,@Gorev,@Tel,@Adres)", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@TC", P_TC);
                    SqlKomut.Parameters.AddWithValue("@Kullanici_Adi", P_KAdi);
                    SqlKomut.Parameters.AddWithValue("@Sifre", P_Sifre);
                    SqlKomut.Parameters.AddWithValue("@Ad", P_Ad);
                    SqlKomut.Parameters.AddWithValue("@Soyad", P_Soyad);
                    SqlKomut.Parameters.AddWithValue("@Gorev", P_Gorev);
                    SqlKomut.Parameters.AddWithValue("@Tel", P_Tel);
                    SqlKomut.Parameters.AddWithValue("@Adres", P_Adres);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Personel Bilgileri Başarı ile Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Bu Personel Daha Önce Kayıt Edilmiş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public void Personel_Listele(DataGridView Datagrid)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Personel_Giris",B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Personel_Guncelle(int P_ID,string P_TC, string P_KAdi, string P_Sifre, string P_Ad, string P_Soyad, string P_Gorev, string P_Tel, string P_Adres)
        {
            mesaj = MessageBox.Show("Bilgiler Güncellensin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(P_TC);
            if(mesaj==DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Update Personel_Giris set P_TC=@TC,P_Kullanici_Adi=@Kullanici_Adi,P_Sifre=@Sifre,P_Ad=@Ad,P_Soyad=@Soyad,P_Gorev=@Gorev,P_Telefon=@Tel,P_Adres=@Adres where Personel_ID=@P_ID", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@P_ID", P_ID);
                    SqlKomut.Parameters.AddWithValue("@TC", P_TC);
                    SqlKomut.Parameters.AddWithValue("@Kullanici_Adi", P_KAdi);
                    SqlKomut.Parameters.AddWithValue("@Sifre", P_Sifre);
                    SqlKomut.Parameters.AddWithValue("@Ad", P_Ad);
                    SqlKomut.Parameters.AddWithValue("@Soyad", P_Soyad);
                    SqlKomut.Parameters.AddWithValue("@Gorev", P_Gorev);
                    SqlKomut.Parameters.AddWithValue("@Tel", P_Tel);
                    SqlKomut.Parameters.AddWithValue("@Adres", P_Adres);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Personel Bilgileri Başarı ile Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Böyle Bir TC 'ye Ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Personel_Sil(string P_TC)
        {
            mesaj = MessageBox.Show("Bilgiler Silinsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(P_TC);
            if(mesaj==DialogResult.Yes)
            {
                if (durum == true)
                {
                    SqlKomut = new SqlCommand("Delete from Personel_Giris where P_TC=@P_TC", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@P_TC", P_TC);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Personel Bilgileri Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Böyle Bir TC 'ye Ait Kayıt Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Personel_Arama_ID(DataGridView Datagrid,int Personel_ID)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Personel_Giris where Personel_ID like '"+Personel_ID+"%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Personel_Arama_TC(DataGridView Datagrid, string P_TC)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Personel_Giris where P_Ad like '" + P_TC + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Personel_Arama_Ad(DataGridView Datagrid, string P_Ad)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Personel_Giris where P_Ad like '" + P_Ad + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Personel_Giris(string P_KullaniciAdi,string P_Sifre)
        {
            SqlKomut= new SqlCommand("Select * from Personel_Giris where P_Kullanici_Adi=@P_Kullanici_Adi and P_Sifre=@Sifre", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@P_Kullanici_Adi", P_KullaniciAdi);
            SqlKomut.Parameters.AddWithValue("@Sifre", P_Sifre);
            DtReader = SqlKomut.ExecuteReader();
            if(DtReader.Read()==true)
            {
                MessageBox.Show("Giriş Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AnaMenu frm = new AnaMenu();
                frm.yetki = "Personel";
                frm.PBilgiBtn.Enabled = false;
                frm.YBilgiBtn.Enabled = false;
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
