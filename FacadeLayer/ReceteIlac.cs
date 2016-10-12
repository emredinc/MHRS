using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
    public class ReceteIlac
    {

        public static bool ReceteIlacEkle(int receteId,int ilacId)
        {
            SqlCommand komut = new SqlCommand("ReceteIlacEkle", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
            komut.Parameters.AddWithValue("@receteId", receteId);
            komut.Parameters.AddWithValue("@isdeled", true);
            komut.Parameters.AddWithValue("@ilacId", ilacId);
            return Erisim.ExecuteNonQuery(komut);
        }

    }
}
