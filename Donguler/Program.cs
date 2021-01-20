using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kursu2 = "Programlamaaya baslangic icin temel kurs";
            string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlamaaya baslangic icin temel kurs", "Java","Python","C#" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
