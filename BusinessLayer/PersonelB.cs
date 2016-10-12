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
   public class PersonelB
    {
       public DataTable PersonelListe()
       {
         return  Personeller.PersonelListe();
       }
       public DataTable PersonelAra(string kelime)
       {
           return Personeller.PersonelAra(kelime);
       }
       public bool PersonelSil(int id)
       {
           return Personeller.PersonelSil(id);
       }
       public bool PersonelEkle(Personel personel)
       {
         return  Personeller.PersonelEkle(personel);
       }
       public DataTable DoktorBilgileri(string tc)
       {
          return Personeller.DoktorBilgileri(tc);
       }
       public DataTable DoktorHasta(int id)
       {
           return Personeller.DoktorHasta(id);
       }
    }
}
