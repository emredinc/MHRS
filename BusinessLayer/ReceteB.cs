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
   public class ReceteB
    {
       public static DataTable ReceteListele(int doktorId)
       {
           return Receteler.ReceteListele(doktorId);
       }
       public static bool ReceteYaz(Recete recete)
       {
           return Receteler.ReceteYaz(recete);
       }
    }
}
