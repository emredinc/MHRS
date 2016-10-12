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
    public  class Randevular
    {
        public static DataTable RandevuSaat(DateTime tarih,int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Randevu where RandevuTarihi = @tarih and PersonelId = @id", Erisim.Baglanti);
            adapter.SelectCommand.Parameters.AddWithValue("tarih",tarih);
            adapter.SelectCommand.Parameters.AddWithValue("id", id);
            DataTable saatler = new DataTable();
            adapter.Fill(saatler);
            return saatler;
        }
        public static DataTable DoktorRandevuları(int id)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select r.Id,h.Ad,h.Soyad,r.RandevuTarihi,s.Saatler as RandevuSaati,re.teshis,i.Ad as ilac from Personel p join Randevu r on p.PersonelId=r.PersonelId join Hasta h on r.HastaId=h.HastaId join saat s on s.id=r.saat_id join Recete re on re.Randevu_id=r.Id join ReceteIlac ri on ri.receteId=re.ReceteId join Ilaclar i on i.IlacId=ri.IlacId where p.PersonelId=@id", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("id", id);
            DataTable table = new DataTable();
            adapt.Fill(table);
            return table;
 
        }
        public static bool RandevuAl(int hasta_id,int per_id,DateTime randevuTarih,int saat_id)
        {
            SqlCommand komut = new SqlCommand("sp_randevuAl", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
            komut.Parameters.AddWithValue("@hasta_id", hasta_id);
            komut.Parameters.AddWithValue("@personel_id", per_id);
            komut.Parameters.AddWithValue("@randevuTarih", randevuTarih);
            komut.Parameters.AddWithValue("@saat_id", saat_id);
            return Erisim.ExecuteNonQuery(komut);
        }

        
    }
}
