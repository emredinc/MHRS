using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class Hasta
    {
        public int Hasta_id { get; set; }
        public string TC { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyet { get; set; }
        public bool KayitliMi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Sifre { get; set; }
        public string foto { get; set; }
    }
}
