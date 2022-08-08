using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urunler_1809
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler u1 = new Urunler();
            Urunler u2 = new Urunler();

            u1.Urunadi = "Ekmek";
            u1.Stok_miktari = 20;
            u1.Fiyat = 5;
            u2.Urunadi = "Elbise";
            u2.Stok_miktari = 10;
            u2.Fiyat = 40;
            char secim;
            string urunsecimi;
            int miktar;
            do
            {
                Console.WriteLine("Hangi üründen istersiniz?(Ekmek ya da Elbise)");
                urunsecimi = Console.ReadLine();

                Console.WriteLine("Bu üründen ne kadar istersiniz?");
                miktar = Convert.ToInt32(Console.ReadLine());

                if (miktar > u1.Stok_miktari)
                {
                    Console.WriteLine("Bu üründen istediğiniz kadar elimizde yok.");
                }
                else if (u1.Stok_miktari == 0)
                {
                    Console.WriteLine("Bu üründen elimizde hiç kalmamıştır.");
                }
                else
                {
                    Urunler.Sepettutari += u1.FiyatHesapla(miktar);
                    Console.WriteLine("Ürün sepete eklenmiştir");
                }

                Console.WriteLine("Başka ürün ister misiniz,e ya da h şeklinde giriniz");
                secim = Convert.ToChar(Console.ReadLine());
            } while (secim=='e');

            Console.WriteLine( "Sepetinizdeki ürünleri almak istermisiniz.e ya da h");
            secim = Convert.ToChar(Console.ReadLine());
            if (secim == 'e')

            {
                Console.WriteLine("Ürünler nereye gidecek?");
                string adres = Console.ReadLine();
                if (adres != "istanbul")
                {
                    Urunler.Sepettutari += 10;
                }

                Console.WriteLine("Toplam ödeyeceğiniz miktar=" + Urunler.Sepettutari);
            }

            else
            {
                Urunler.Sepettutari = 0;
                Console.WriteLine("siparişiniz iptal edilmiştir");
            }
        }
    }
    class Urunler
    {
        private string urunadi;
        private int stok_miktari;
        private int fiyat;
        private static int sepettutari;


        public string Urunadi { get => urunadi; set => urunadi = value; }
        public int Stok_miktari { get => stok_miktari; set => stok_miktari = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public static int Sepettutari { get => sepettutari; set => sepettutari = value; }

        public int FiyatHesapla(int miktar)
        {
            
            return (miktar * Fiyat) + ((miktar*Fiyat*18)/100);
        }
    }
}
