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
  public  class İlac
    {
      public static DataTable IlacListele()
      {
          return Erisim.Listele("sp_Ilaclar");
      }
      public static bool IlacEkle(Ilaclar ilac)
      {
          SqlCommand komut = new SqlCommand("sp_IlacEkle", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
          komut.Parameters.AddWithValue("@IlacAd", ilac.ilac_Ad);
          komut.Parameters.AddWithValue("@kayitliMi", 1);
          return Erisim.ExecuteNonQuery(komut);
      }
      public static bool IlacSil(Ilaclar ilac)
      {
          SqlCommand komut = new SqlCommand("sp_IlacSil", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
          komut.Parameters.AddWithValue("@id", ilac.ilac_id);         
          return Erisim.ExecuteNonQuery(komut);
      }
    }
}
