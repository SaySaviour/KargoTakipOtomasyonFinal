using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class KargoDurumu
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlDataAdapter DataAdp;
        SqlCommand SqlKomut;
        SqlDataReader DtReader;
        DataTable tablo = new DataTable();
        DialogResult mesaj;
        bool durum;
        void kayitKontrol(string kargono,string kdurum)
        {
            SqlKomut = new SqlCommand("Select * from Kargo_Gonderi_Durum where GD_Kargo_No=@kargono and Gonderi_Durum=@durum", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@kargono", kargono);
            SqlKomut.Parameters.AddWithValue("@durum",kdurum );
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = true;
            else
                durum = false;
        }
        public void Listele(DataGridView Datagrid)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Kargo_Gonderi_Durum ", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void Kargo_Durum_Ekle(string kargono,string gonderidurum,DateTime tarih,string lokasyon)
        {
            mesaj = MessageBox.Show("Kargo Durumu Kaydedilsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(kargono,gonderidurum);
            if(durum==false)
            {
                SqlKomut = new SqlCommand("insert into Kargo_Gonderi_Durum (GD_Kargo_No,Gonderi_Durum,Islem_Tarihi,Lokasyon) values (@kargono,@gonderidurum,@tarih,@lokasyon)", B.baglanti());
                SqlKomut.Parameters.AddWithValue("@kargono", kargono);
                SqlKomut.Parameters.AddWithValue("@gonderidurum", gonderidurum);
                SqlKomut.Parameters.AddWithValue("@tarih", tarih);
                SqlKomut.Parameters.AddWithValue("@lokasyon", lokasyon);
                SqlKomut.ExecuteNonQuery();
                B.baglanti().Close();
                MessageBox.Show("Kargo Durumu Başarı ile Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           else
                MessageBox.Show("Bu Kargonun Durumu Zaten Kaydedilmiş Lütfen Farklı Durum Kaydedin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Kargo_Durum_Arama_Kargo_No(DataGridView Datagrid,string kargono )
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Kargo_Gonderi_Durum where GD_Kargo_No like '" + kargono + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
    }
}
