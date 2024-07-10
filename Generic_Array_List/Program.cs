using System;
using System.Collections;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
             liste.Add("Halil");
             liste.Add(10);
             liste.Add(true);
             liste.Add('A');

            // İçerisindeki verilere erişme

             Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Addrange

            string [] renkler = {"kırmızı", "mavi","yesil"};
            List<int> sayilar = new List<int>(){1,3,5,7,9,12};
             liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //sort 
            liste.Sort();

            
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //BinarySearch

            Console.WriteLine(liste.BinarySearch(9));//düzgün çalışması için sıralama yapmamız gerekiyor.

            // Reverse

            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear

            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }




        }
    }
}