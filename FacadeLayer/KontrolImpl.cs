using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
    public class KontrolImpl : IKontrol
    {
        public bool SifreKontrol(string sifre1, string sifre2)
        {
            if (sifre1 == sifre2)
            {
                return true;
            }
            return false;
        }

        public bool HastaKayitVarMi(string tc)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Hasta where Tc=@tc", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("tc", tc);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool TcSifreUyuyorMu(string tc, string sifre)
        {
            string sifree = "";
            SqlDataAdapter adapt = new SqlDataAdapter("select Sifre from Hasta where Tc=@tc", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("tc", tc);
            DataTable table = new DataTable();
            adapt.Fill(table);
            foreach (DataRow item in table.Rows)
            {
                sifree = item[0].ToString();
            }
            if (sifre == sifree)
            {
                return true;
            }
            return false;

        }

        public string SifremiUnuttum(string tc)
        {
            string sifree = "";
            SqlDataAdapter adapt = new SqlDataAdapter("select Sifre from Hasta where Tc=@tc", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("tc", tc);
            DataTable table = new DataTable();
            adapt.Fill(table);
            foreach (DataRow item in table.Rows)
            {
                sifree = item[0].ToString();
            }
            return sifree;
        }

        public bool AdminMi(string tc, string sifre)
        {
            if (tc.Equals("admin") && sifre.Equals("admin"))
            {
                return true;
            }
            return false;
        }


        public bool PersonelKayitVarMi(string tc)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Personel where Tc=@tc", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("tc", tc);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }


        public bool DoktorMu(string tc)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Personel where PersonelTipId=1 and Tc=@tc ", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("tc", tc);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }


        public bool TcSifreUyuyorMuDr(string tc, string sifre)
        {
            string sifree = "";
            SqlDataAdapter adapt = new SqlDataAdapter("select Sifre from Personel where Tc=@tc", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("tc", tc);
            DataTable table = new DataTable();
            adapt.Fill(table);
            foreach (DataRow item in table.Rows)
            {
                sifree = item[0].ToString();
            }
            if (sifre == sifree)
            {
                return true;
            }
            return false;
        }



        public bool RandevuVarMi(DateTime tarih, int saat_id)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Randevu where RandevuTarihi=@tarih and saat_id=@id", Erisim.Baglanti);
            adapt.SelectCommand.Parameters.AddWithValue("tarih", tarih);
            adapt.SelectCommand.Parameters.AddWithValue("id", saat_id);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Columns.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
