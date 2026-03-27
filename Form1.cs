using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2411502020_GenelKoleksiyonlar_Hafta11
{
    public partial class Form1 : Form
    {
        List<Arac> aracListesi = new List<Arac>();
        List<Musteri> musteriListesi = new List<Musteri>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAraclar.Items.Clear();
            cmbAracTuru.Items.Add("Otomobil");
            cmbAracTuru.Items.Add("Motosiklet");
            cmbAracTuru.Items.Add("Minibüs");
            cmbAracTuru.SelectedIndex = 0;
            string[] satirlar =File.Exists("araclar.txt") ? File.ReadAllLines("araclar.txt") : new string[0];
            foreach (var line in satirlar)
            {
                Arac arac = Arac.FromDataString(line);
                if (arac != null)
                {
                    aracListesi.Add(arac);
                    cmbAraclar.Items.Add(arac);
                }
            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            string marka = txtMarka.Text;
            string tur = cmbAracTuru.SelectedItem.ToString();

            Arac yeniArac = null;


            switch (tur)
            {
                case "Otomobil":
                    yeniArac = new Otomobil(plaka, marka);
                    break;
                case "Motosiklet":
                    yeniArac = new Motosiklet(plaka, marka);
                    break;
                case "Minibüs":
                    yeniArac = new Minibus(plaka, marka);
                    break;
            }

            if (yeniArac != null)
            {
                aracListesi.Add(yeniArac);
                cmbAraclar.Items.Add(yeniArac);
                File.AppendAllText("araclar.txt", yeniArac.ToDataString() + Environment.NewLine);
                MessageBox.Show("Araç başarıyla  kaydedildi");
            }       


            
            txtMarka.Clear();
            txtPlaka.Clear();

        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            string AdSoyad = txtMusteriAd.Text;
            Arac secilenArac = cmbAraclar.SelectedItem as Arac;
            int gun;
            if (secilenArac != null && !string.IsNullOrWhiteSpace(AdSoyad) && int. TryParse(txtGunSayisi.Text,out gun))
            {
                Musteri musteri = new Musteri(AdSoyad, secilenArac,gun);
                musteriListesi.Add(musteri);
                lstKiralanmaGecmisi.Items.Add(musteri.KiralamaBilgisi());

                cmbAraclar.Items.Remove(secilenArac);
                aracListesi.Remove(secilenArac);
                txtMusteriAd.Clear();
                txtGunSayisi.Clear();

            }
            else
            {
                MessageBox.Show("Lütfen mşteri adı girin ve araç seçin ");
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (lstKiralanmaGecmisi.SelectedIndex != -1)
            {
                Musteri teslimEdilen = musteriListesi[lstKiralanmaGecmisi.SelectedIndex];
                aracListesi.Add(teslimEdilen.KiralananArac);
                cmbAraclar.Items.Add(teslimEdilen.KiralananArac);

                MessageBox.Show($"Teslim edilen {teslimEdilen.KiralananArac.Plaka} plakalı araç teslim alındı.");

                musteriListesi.Remove(teslimEdilen);
                lstKiralanmaGecmisi.Items.RemoveAt(lstKiralanmaGecmisi.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen teslim alınacak aracı seçin.");
            }
        }
    }
}
