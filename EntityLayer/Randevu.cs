using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Randevu
    {
        public int id { get; set; }
        public int hasta_id { get; set; }
        public int Per_id { get; set; }
        public DateTime randevuTarihi { get; set; }
        public int Saat_id { get; set; }
        public bool Kayitli_mi { get; set; }


    }
}
