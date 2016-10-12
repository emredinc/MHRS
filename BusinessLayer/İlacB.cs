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
  public  class İlacB
    {
      public DataTable IlacListe()
      {
          return İlac.IlacListele();
      }
      public bool IlacEkle(Ilaclar ilac)
      {
          return İlac.IlacEkle(ilac);
      }
      public bool IlacSil(Ilaclar ilac)
      {
          return İlac.IlacSil(ilac);
      }
    }
}
