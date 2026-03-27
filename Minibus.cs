using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2411502020_GenelKoleksiyonlar_Hafta11
{
   public  class Minibus:Arac
    {
        public Minibus(string plaka,string marka): base(plaka, marka) { }

        public override string AracBilgisi()
        {
            return $"[Minibus] {Plaka} - {Marka}";
        }
    }
}
