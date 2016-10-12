using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
  public  class Saatler
    {
      public static DataTable SaatGetir(DateTime tarih)
      {
          SqlDataAdapter adapt = new SqlDataAdapter("Select * From Saat ", Erisim.Baglanti);
          //SqlDataAdapter adapt = new SqlDataAdapter("Select s.id,s.Saatler From Saat s  join Randevu r on r.saat_id<>s.id where r.RandevuTarihi=@tarih", Erisim.Baglanti);
          //adapt.SelectCommand.Parameters.AddWithValue("tarih", tarih);
          DataTable table = new DataTable();
          adapt.Fill(table);
          return table;
      }
    }
}
