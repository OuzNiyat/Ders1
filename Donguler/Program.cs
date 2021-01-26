using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array = diziler 
            string[] kurslar = new string[] {"Yazılım Geliştirici Kursu","Proglamlamaya Başlangıç Kursu","Java","Python","C#" };
            

            for (int i = 0; i<kurslar.Length; i++) // elamanların sonuna kadar sayar.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
        }
        
    }
}
