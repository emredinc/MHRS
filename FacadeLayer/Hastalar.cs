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
  public  class Hastalar
    {
        public static DataTable HastaListe()
        {
            return Erisim.Listele("sp_HastaListe");
        }
        public static bool HastaKayit(Hasta entity)
        {
            SqlCommand komut = new SqlCommand("sp_HastaKayit", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
            komut.Parameters.AddWithValue("@Tc", entity.TC);
            komut.Parameters.AddWithValue("@Ad", entity.Adi);
            komut.Parameters.AddWithValue("@Soyad", entity.Soyadi);
            komut.Parameters.AddWithValue("@DogumTarihi", entity.DogumTarihi);
            komut.Parameters.AddWithValue("@Cinsiyet", entity.Cinsiyet);
            komut.Parameters.AddWithValue("@Sifre", entity.Sifre);
            komut.Parameters.AddWithValue("@GirisTarihi", entity.KayitTarihi);
            komut.Parameters.AddWithValue("@kayitliMi", entity.KayitliMi);
            return Erisim.ExecuteNonQuery(komut);
        }
        public static bool HastaSil(Hasta entity)
        {
            SqlCommand komut = new SqlCommand("sp_HastaSil", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
            komut.Parameters.AddWithValue("@id", entity.Hasta_id);
            return Erisim.ExecuteNonQuery(komut);
        }
        public static DataTable HastaBilgileri(string tc)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Hasta where Tc=@tc", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("Tc", tc);
            DataTable table = new DataTable();
            adapt.Fill(table);
            return table;
        }
        public static bool HastaGuncelle(Hasta entity)
        {
            SqlCommand komut = new SqlCommand("sp_HastaGuncelle", Erisim.Baglanti) { CommandType = CommandType.StoredProcedure };
            komut.Parameters.AddWithValue("@id", entity.Hasta_id);
            komut.Parameters.AddWithValue("@Ad", entity.Adi);
            komut.Parameters.AddWithValue("@Soyad", entity.Soyadi);
            komut.Parameters.AddWithValue("@cinsiyet", entity.Cinsiyet);
            komut.Parameters.AddWithValue("@Sifre", entity.Sifre);
            return Erisim.ExecuteNonQuery(komut);
        }
        public static DataTable HastaRandevuListele(int id)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select b.BolumAd,p.Ad as doktorAd,r.RandevuTarihi from Hasta h join Randevu r on h.HastaId=r.HastaId join personel p on r.PersonelId=p.PersonelId join Bolum b on p.BolumId=b.BolumId where h.HastaId=@id and r.RandevuTarihi<@tarih", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("id", id);
            adapt.SelectCommand.Parameters.AddWithValue("tarih",DateTime.Now );
            DataTable table = new DataTable();
            adapt.Fill(table);
            return table;
 


        }
    }
}
