using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Domates";
            urun1.Fiyati = 12;
            urun1.Aciklama = "Sulu sulu domates";

            Urun urun2 = new Urun();
            urun2.Adi = "Salatalık";
            urun2.Fiyati = 5;
            urun2.Aciklama = "Isırdın mı şartt eder!!";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " --> " + urun.Fiyati + " --> " + urun.Aciklama);
            }

            Console.WriteLine("---------------Metotlar--------------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle2("Armut", "Sulu armut", 15, 2);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır karpuzu", 120, 5);
            sepetmanager.Ekle2("Çilek", "Yerden bitme çilek", 35, 3);


        }
    }
}