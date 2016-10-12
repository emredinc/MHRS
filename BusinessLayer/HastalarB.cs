using EntityLayer;
using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public  class HastalarB
    {
    
      public void HastaEkle(Hasta hasta)
      {
          Hastalar.HastaKayit(hasta);
      }
      public void HastaSil(Hasta hasta)
      {
          Hastalar.HastaSil(hasta);
      }
      public void HastaGuncelle(Hasta hasta)
      {
          Hastalar.HastaGuncelle(hasta);
      }
      public DataTable HastaBilgileri(string tc)
      {
        return  Hastalar.HastaBilgileri(tc);
      }
      public DataTable HastaRandevuListele(int id)
      {
          return Hastalar.HastaRandevuListele(id);
      }
     
    }
}
