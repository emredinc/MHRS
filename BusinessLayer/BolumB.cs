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
    public class BolumB
    {
        public DataTable BolumListele()
        {
            return Bolumler.BolumListe();
        }
        public DataTable BolumAra(string kelime)
        {
            return Bolumler.BolumAra(kelime);
        }
        public bool BolumEkle(Bolum b)
        {
         return   Bolumler.BolumEkle(b);
        }
        public bool BolumSil(int id)
        {
            return Bolumler.BolumSil(id);
        }
        public DataTable DoktorBolum(int id)
        {
            return Bolumler.DoktorBolum(id);
        }
    }
}
