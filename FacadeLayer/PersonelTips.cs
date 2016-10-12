using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
  public  class PersonelTips
    {
      public static DataTable PersonelTipGetir()
      {
        return  Erisim.Listele("sp_PersonelTip");
      }
    }
}
