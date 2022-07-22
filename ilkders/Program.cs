using System;

namespace kampilkders
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGiris = false;
            double dolarDun = 12.56;
            double dolarBugun = 12.73;

            if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Eğilimi");
            }
            else if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Eğilimi");
            }
            else
            {
                Console.WriteLine("Piyasa değişmedi.");
            }

            if(sistemeGiris == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonı");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
