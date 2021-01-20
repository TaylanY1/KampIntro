using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // type safety - tip guvenligi
           // Do not repeat yourself - kendini tekrarlama
           // deger tutucu, alias
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.5;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmisMi==true)

            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
