
using System;

namespace kampilkders
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kurs_adi = "Python";
            kurs1.kurs_egitmen = "Emir Öztürk";
            kurs1.kurs_izlenme_orani = 57;

            Kurs kurs2 = new Kurs();
            kurs2.kurs_adi = "C#";
            kurs2.kurs_egitmen = "Engin  Demiroğ";
            kurs2.kurs_izlenme_orani = 82;

            Kurs kurs3 = new Kurs();
            kurs3.kurs_adi = "Java";
            kurs3.kurs_egitmen = "Murat Yücedağ";
            kurs3.kurs_izlenme_orani = 49;

            //Console.WriteLine(kurs2.kurs_adi + " --> " + kurs2.kurs_egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kurs_adi + " : " + kurs.kurs_egitmen + " : " + kurs.kurs_izlenme_orani);
            }
        }
    }
    class Kurs
    {
        public string kurs_adi { get; set; }
        public string kurs_egitmen { get; set; }
        public int kurs_izlenme_orani { get; set; }

    }
}