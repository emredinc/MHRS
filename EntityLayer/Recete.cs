using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class Recete
    {
        public int recete_id { get; set; }
        public DateTime VerilisTarih { get; set; }
        public int Randevu_id { get; set; }
        public bool Kayitli_Mi { get; set; }
        public string Teshis { get; set; }
        public int HastaId { get; set; }
        public int PersonelId { get; set; }
    }
}
