using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class Personel
    {
        public int personel_id { get; set; }
        public string TC { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int personelTip_id { get; set; }
        public bool KayitliMi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int bolum_id { get; set; }
        public string foto { get; set; }
        public string Sifre { get; set; }

    }
}
