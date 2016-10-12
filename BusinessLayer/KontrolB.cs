using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class KontrolB:IKontrol
    {
       KontrolImpl kontrol = new KontrolImpl();
        public bool SifreKontrol(string sifre1, string sifre2)
        {
           return kontrol.SifreKontrol(sifre1, sifre2);
        }

        public bool HastaKayitVarMi(string tc)
        {
            return kontrol.HastaKayitVarMi(tc);
        }

        public bool TcSifreUyuyorMu(string tc, string sifre)
        {
            return kontrol.TcSifreUyuyorMu(tc, sifre);
        }

        public string SifremiUnuttum(string tc)
        {
            return kontrol.SifremiUnuttum(tc);
        }

        public System.Data.DataTable PerTipDoldur()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable BolumDoldur()
        {
            throw new NotImplementedException();
        }
       public bool AdminMi(string tc,string sifre)
        {
           return kontrol.AdminMi(tc, sifre);
        }

       public bool PersonelKayitVarMi(string tc)
       {
           return kontrol.PersonelKayitVarMi(tc);
       }
       public bool DoktorMu(string tc)
       {
         return  kontrol.DoktorMu(tc);
       }

       public bool TcSifreUyuyorMuDr(string tc, string sifre)
       {
          return kontrol.TcSifreUyuyorMuDr(tc, sifre);
       }
       public bool RandevuVarMi(DateTime tarih, int saat_id)
       {
           return kontrol.RandevuVarMi(tarih, saat_id);
       }
    }
}
