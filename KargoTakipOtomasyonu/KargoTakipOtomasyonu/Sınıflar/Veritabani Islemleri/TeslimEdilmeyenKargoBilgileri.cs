using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class TeslimEdilmeyenKargoBilgileri
    {
        SQLBaglanti B = new SQLBaglanti();
        SqlDataAdapter DataAdp;
        SqlCommand SqlKomut;
        SqlDataReader DtReader;
        DataTable tablo = new DataTable();
        DialogResult mesaj;
        bool durum;
        void kayitKontrol(string Kargo_No)
        {
            SqlKomut = new SqlCommand("Select * from Teslim_Edilmeyen_Kargo where TE_Kargo_No=@TE_Kargono", B.baglanti());
            SqlKomut.Parameters.AddWithValue("@TE_Kargono", Kargo_No);
            DtReader = SqlKomut.ExecuteReader();
            if (DtReader.Read())
                durum = true;
            else
                durum = false;
        }
        public void TE_Kargo_Listele(DataGridView Datagrid)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Teslim_Edilmeyen_Kargo", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void TE_Kargo_Ekle(string kargo_no, DateTime tarih, string TE_Nedeni, string aciklama)
        {
            mesaj = MessageBox.Show("Bilgiler Kayıdedilsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            kayitKontrol(kargo_no);
            if (mesaj == DialogResult.Yes)
            {
                if (durum == false)
                {

                    SqlKomut = new SqlCommand("insert into Teslim_Edilmeyen_Kargo (TE_Kargo_No,Tarih,Teslim_Edilmeme_Nedeni,Aciklama) values (@TE_Kargo_No,@Tarih,@TE_Neden,@Aciklama)", B.baglanti());
                    SqlKomut.Parameters.AddWithValue("@TE_Kargo_No", kargo_no);
                    SqlKomut.Parameters.AddWithValue("@Tarih", tarih);
                    SqlKomut.Parameters.AddWithValue("@TE_Neden", TE_Nedeni);
                    SqlKomut.Parameters.AddWithValue("@Aciklama", aciklama);
                    SqlKomut.ExecuteNonQuery();
                    B.baglanti().Close();
                    MessageBox.Show("Teslim Edilmeyen Kargo Bilgileri Başarı ile Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Bu Kargo Daha Önceden Kaydedilmiş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void TE_Kargo_Arama_KargoNo(DataGridView Datagrid, string Kargo_no)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Teslim_Edilmeyen_Kargo where TE_Kargo_No like '" + Kargo_no + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
        public void TE_Kargo_Arama_Tarih(DataGridView Datagrid, DateTime tarih)
        {
            tablo.Clear();
            DataAdp = new SqlDataAdapter("Select * from Teslim_Edilmeyen_Kargo where Tarih like '" + tarih + "%'", B.baglanti());
            DataAdp.Fill(tablo);
            Datagrid.DataSource = tablo;
            B.baglanti().Close();
        }
    }
}
