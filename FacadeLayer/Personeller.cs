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
   public class Personeller
    {
       public static DataTable PersonelListe()
       {
           return Erisim.Listele("sp_PersonelListe");
       }
       public static DataTable PersonelAra(string kelime)
       {
           SqlDataAdapter adapt = new SqlDataAdapter("select Tc,p.Ad,Soyad,BolumAd,pt.Ad from Personel p join PersonelTip pt on p.PersonelTipId=pt.PersonelTipId join Bolum b on b.BolumId=p.BolumId where p.Ad like '%" + kelime + "%'", Erisim.Baglanti);
           DataTable table = new DataTable();
           adapt.Fill(table);
           return table;
       }
       public static bool PersonelSil(int id)
       {
           SqlCommand komut = new SqlCommand("sp_PersonelSil", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
           komut.Parameters.AddWithValue("@Id",id);
           return Erisim.ExecuteNonQuery(komut);
       }
       public static bool PersonelEkle(Personel entity)
       {
           SqlCommand komut = new SqlCommand("sp_PersonelEkle", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
           komut.Parameters.AddWithValue("@Tc", entity.TC);
           komut.Parameters.AddWithValue("@Ad", entity.Adi);
           komut.Parameters.AddWithValue("@Soyad", entity.Soyadi);
           komut.Parameters.AddWithValue("@personelTip",entity.personelTip_id);
           komut.Parameters.AddWithValue("@Bolum",entity.bolum_id);
           komut.Parameters.AddWithValue("@sifre",entity.Sifre);
           komut.Parameters.AddWithValue("@kayitliMi", entity.KayitliMi);
           return Erisim.ExecuteNonQuery(komut);
       }
       public static DataTable DoktorBilgileri(string tc)
       {
           SqlDataAdapter adapt = new SqlDataAdapter("select * from Personel where Tc=@tc", Erisim.Baglanti);
           adapt.SelectCommand.Parameters.AddWithValue("tc", tc);
           DataTable table = new DataTable();
           adapt.Fill(table);
           return table;

       }
       public static DataTable DoktorHasta(int id)
       {
           SqlDataAdapter adapt = new SqlDataAdapter("select r.Id,h.HastaId,h.Tc,h.Ad,h.Soyad,h.DogumTarihi,h.Cinsiyet from Personel p join randevu r on r.PersonelId=p.PersonelId join Hasta h on h.HastaId=r.HastaId where p.PersonelId=@id",Erisim.Baglanti);
           adapt.SelectCommand.Parameters.AddWithValue("id", id);
           DataTable table = new DataTable();
           adapt.Fill(table);
           return table;


       }
    }
}
