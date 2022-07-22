// See https://aka.ms/new-console-template for more information

string[] satistakiler = new string[] { "Kitap", "Defter", "Kalem", "Çanta", "Futbol Topu", "Mouse", "Klavye" };


for (int i = 0; i < satistakiler.Length; i++)
{
    Console.WriteLine(satistakiler[i]);
}

foreach (string satis in satistakiler)
{
    Console.WriteLine(satis);
}
