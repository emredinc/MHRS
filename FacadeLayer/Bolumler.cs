using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
    public class Bolumler
    {
        public static DataTable BolumListe()
        {
            return Erisim.Listele("sp_BolumListe");
        }
        public static bool BolumEkle(Bolum entity)
        {
            SqlCommand komut = new SqlCommand("sp_BolumEkle", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
            komut.Parameters.AddWithValue("@Ad", entity.BolumAd);
            return Erisim.ExecuteNonQuery(komut);
        }
        public static bool BolumSil(int id)
        {
            SqlCommand komut = new SqlCommand("sp_BolumSil", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
            komut.Parameters.AddWithValue("@id",id);
            return Erisim.ExecuteNonQuery(komut);
        }
        public static DataTable BolumAra(string kelime)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Bolum where BolumAd like '%"+kelime+"%'", Erisim.Baglanti);
            DataTable table = new DataTable();
            adapt.Fill(table);
            return table;
        }   
        public static DataTable DoktorBolum(int id)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select p.PersonelId,(p.Ad+' '+p.Soyad) DoktorAdSoyad from Bolum b join Personel p on b.BolumId = p.BolumId where p.PersonelTipId=1 and b.BolumId = @id", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("id", id);
            DataTable doktorlar = new DataTable();
            adapt.Fill(doktorlar);
            return doktorlar;
        }
    }
}
