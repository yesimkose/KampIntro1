﻿using System;

namespace ClassInto
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs2.Egitmen = "ayhan demiroğ";
            kurs2.IzlenmeOrani = 68;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "pyhton";
            kurs3.Egitmen = "berkay demiroğ";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi + " : " + kurslar[i].Egitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
