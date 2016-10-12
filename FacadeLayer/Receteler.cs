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
  public  class Receteler
    {
      public static bool ReceteYaz(Recete recete)
      {
          SqlCommand adapt = new SqlCommand("Insert into Recete values(@VerilisTarihi,@KayitliMi,@Randevu_id,@teshis,@hasta_id,@personel_id)", Erisim.Baglanti);
          adapt.Parameters.AddWithValue("VerilisTarihi", recete.VerilisTarih);
          adapt.Parameters.AddWithValue("KayitliMi", recete.Kayitli_Mi);
          adapt.Parameters.AddWithValue("Randevu_id", recete.Randevu_id);
          adapt.Parameters.AddWithValue("teshis", recete.Teshis);
          adapt.Parameters.AddWithValue("hasta_id", recete.HastaId);
          adapt.Parameters.AddWithValue("personel_id", recete.PersonelId);
         return Erisim.ExecuteNonQuery(adapt);
          
      }

      public static DataTable ReceteListele(int doktorId)
      {
          SqlDataAdapter adtr = new SqlDataAdapter("Select r.ReceteId,h.Ad,h.Soyad,h.Cinsiyet,r.VerilisTarihi,r.teshis From Recete  r Join Hasta h on h.HastaId=r.hasta_id Where  personel_id=@id", Erisim.Baglanti);
          adtr.SelectCommand.Parameters.AddWithValue("id", doktorId);
          DataTable dt = new DataTable();
          adtr.Fill(dt);
          return dt;
      }
    }
}
