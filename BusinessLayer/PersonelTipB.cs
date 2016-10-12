using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public  class PersonelTipB
    {
      public DataTable PersonelTipGetir()
      {
         return PersonelTips.PersonelTipGetir();
      }
    }
}
