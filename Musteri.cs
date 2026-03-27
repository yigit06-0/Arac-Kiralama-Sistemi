using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2411502020_GenelKoleksiyonlar_Hafta11
{
    public class Musteri
    {
        public string AdSoyad { get; set; }
        public Arac KiralananArac { get; set; }

        public int GunSayisi { get; set; }

        public decimal Ucret { get; set; }

        public DateTime KiralamaTarihi { get; set; }

        public Musteri(string adSoyad, Arac kiralananArac, int gunSayisi)
        {
            AdSoyad = adSoyad;
            KiralananArac = kiralananArac;
            GunSayisi = gunSayisi;
            Ucret = HesaplaUcret();
        }
        private decimal HesaplaUcret()
        {
            decimal gunlukUcret = 0;
            if (KiralananArac is Otomobil) gunlukUcret = 500;
            else if (KiralananArac is Motosiklet) gunlukUcret = 300;
            else if (KiralananArac is Minibus) gunlukUcret = 700;
            return gunlukUcret * GunSayisi;

        }
        public string KiralamaBilgisi()
        {
            return $"{AdSoyad} →{KiralananArac.AracBilgisi()} - {GunSayisi} gün - {Ucret:C}";
        }
        
    }
}

