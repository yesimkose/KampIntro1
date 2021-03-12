using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            //Ogrenci.Add(134, "Tolga Demirer");
            //Ogrenci.Add(158, "Ümit Özkan");
            //Ogrenci.Add(115, "Kadir Aydemir");
            //Ogrenci.Add(174, "Cemal Çiftçi");

            MyDictionary<int, string> Ogrenci = new MyDictionary<int,string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");
            foreach (KeyValuePair<int, string> veri in Ogrenci)
                Console.WriteLine("Numara:{0} - İsim:{1}", veri.Key, veri.Value);
        }
    }
    "
}
