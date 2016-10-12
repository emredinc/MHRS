using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class ReceteIlacB
    {
        public bool ReceteIlacEkle(int receteId,int ilacId)
        {
            return ReceteIlac.ReceteIlacEkle(receteId, ilacId);
        }
    }
}
