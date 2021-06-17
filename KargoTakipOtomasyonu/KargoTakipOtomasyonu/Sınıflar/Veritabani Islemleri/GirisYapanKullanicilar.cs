using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class GirisYapanKullanicilar
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlDataAdapter DataAdp;
        SqlCommand SqlKomut;
        DataTable tablo = new DataTable();
        public void Giris_Yapti(string yetki, DateTime giriszaman)
        {
            SqlKomut = new SqlCommand("insert into Giris_Yapan_Kullanicilar (Yetki,Giris_Zamani) values (@yetki,@zaman)", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@yetki", yetki);
            SqlKomut.Parameters.AddWithValue("@zaman", giriszaman);
            SqlKomut.ExecuteNonQuery();
            B.baglanti().Close();
        }
        public void Giris_Yapanlari_Listele(DataGridView Datagrid)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Giris_Yapan_Kullanicilar", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Arama_Yetki(DataGridView Datagrid,string yetki)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Giris_Yapan_Kullanicilar where Yetki like '" + yetki + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Arama_Tarih(DataGridView Datagrid, DateTime tarih)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Giris_Yapan_Kullanicilar where Giris_Zamani like '" +tarih+ "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
    }
}
