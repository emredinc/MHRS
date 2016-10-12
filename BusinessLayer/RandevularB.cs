using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RandevularB
    {
        public DataTable RandevuSaati(DateTime tarih, int id)
        {
            return Randevular.RandevuSaat(tarih, id);
        }

        public DataTable DoktorRandevuları(int id)
        {
            return Randevular.DoktorRandevuları(id);
        }
        public bool RandevuAl(int hasta_id,int per_id,DateTime randevuTarih,int saat_id)
        {
            return Randevular.RandevuAl(hasta_id, per_id, randevuTarih, saat_id);
        }
    }
}
