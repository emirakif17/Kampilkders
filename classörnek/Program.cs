using System;

namespace kampilkders
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunadi = "Okul Çantası";
            urun1.urunfiyati = 125.90;
            urun1.indirimorani = "%25";
            urun1.indirimgunleri = "15 Temmuz - 1 Ağustos";

            Urun urun2 = new Urun();
            urun2.urunadi = "Futbol Topu";
            urun2.urunfiyati = 250.00;
            urun2.indirimorani = "%15";
            urun2.indirimgunleri = "2 Eylül - 1 Ekim";

            Urun urun3 = new Urun();
            urun3.urunadi = "Uçurtma Avcısı Kitap";
            urun3.urunfiyati = 30.50;
            urun3.indirimorani = "%10";
            urun3.indirimgunleri = "1 Ocak - 15 Ocak";

            Urun urun4 = new Urun();
            urun4.urunadi = "Wifi Adaptör";
            urun4.urunfiyati = 170.25;
            urun4.indirimorani = "%30";
            urun4.indirimgunleri = "2 Mart - 3 Nisan";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunadi + " - " + urun.urunfiyati + " - " + urun.indirimorani + " - " + urun.indirimgunleri);
            }

        }
    }
    class Urun
    {
        public string urunadi { get; set; }
        public double urunfiyati { get; set; }
        public string indirimorani { get; set; }
        public string indirimgunleri { get; set; }
    }
}
