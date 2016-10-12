using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
   public interface IKontrol
    {
        bool SifreKontrol(string sifre1, string sifre2);
        bool HastaKayitVarMi(string tc);
        bool TcSifreUyuyorMu(string tc, string sifre);
        string SifremiUnuttum(string tc);
        bool AdminMi(string tc, string sifre);
        bool PersonelKayitVarMi(string tc);
        bool DoktorMu(string tc);
        bool TcSifreUyuyorMuDr(string tc, string sifre);
         bool RandevuVarMi(DateTime tarih, int saat_id);
    }
}
