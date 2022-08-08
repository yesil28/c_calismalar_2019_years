using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen yenidikdortgen = new Dikdortgen(20,30);
            Ucgen yeniucgen = new Ucgen();
            //yeniucgen.Genislik = 10;
            //yeniucgen.Yukseklik = 15;
            //yenidikdortgen.bilgileri_goster();
            //yeniucgen.bilgileri_goster();
            //Console.WriteLine("Dikdörtgenin Alanı = " + yenidikdortgen.AlanHesapla());
            //Console.WriteLine("Üçgenin Alanı = " + yeniucgen.AlanHesapla());

            //Kare k = new Kare(20,20);
            //Console.WriteLine(k.AlanHesapla());
            
        }
    }
    class Cokgen
    {
        private int genislik;
        private int yukseklik;

        public int Genislik { get => genislik; set => genislik = value; }
        public int Yukseklik { get => yukseklik; set => yukseklik = value; }

        public void bilgileri_goster()
        {
            Console.WriteLine(Genislik);
            Console.WriteLine(Yukseklik);
        }
    }
    class Dikdortgen: Cokgen
    {
        public Dikdortgen(int g, int y)
        {
            Genislik = g;
            Yukseklik = y;
        }
        public int AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
     class Kare : Dikdortgen
    {
        public Kare(int a):base(25,25)
        {
            Genislik = 25;
            Yukseklik = 25;
        }
      
    }
    class Ucgen : Cokgen
    {
        public int AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }
    }
}
