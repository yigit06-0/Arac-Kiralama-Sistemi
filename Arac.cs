using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2411502020_GenelKoleksiyonlar_Hafta11
{
    public abstract class Arac
    {
        public string Plaka {  get; set; }
        public string Marka { get; set; }

        public  Arac (string plaka , string marka)
        {
            Plaka = plaka;
            Marka = marka;
        }
        public abstract string AracBilgisi();

        public virtual string ToDataString()
        {
            return $"{GetType().Name} | {Plaka} | {Marka}";
        }
        public static Arac FromDataString(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 3) return null;

            string tur = parts[0];
            string plaka = parts[1];
            string marka = parts[2];

            Arac arac = null;

            switch (tur)
            {
                case "Otomobil":
                    arac = new Otomobil(plaka, marka);
                    break;
                case "Motosiklet":
                    arac = new Motosiklet(plaka, marka);
                    break;
                case "Minibus":
                    arac = new Minibus(plaka, marka);
                    break;
            }

            return arac;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {Plaka} = {Marka}";
        }

    }
}
