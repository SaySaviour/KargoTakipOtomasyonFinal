using System.Data.SqlClient;

namespace KargoTakipOtomasyonu.Sınıflar.Veritabani_Islemleri
{
    class SQLBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Server=.; Initial Catalog=Kargo;Integrated Security=True");
            if (baglan.State == System.Data.ConnectionState.Closed)
                baglan.Open();
            return baglan;
        }
    }
}
