using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urunler_sinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler u1 = new Urunler("Ekmek","Gıda",1,20);
            Urunler u2 = new Urunler("Ceket","Giyim",50,2);
            u2.Kategori = "Giyim";
            Console.WriteLine("Hangi ürünü almak istersiniz");
            string urun = Console.ReadLine();
            Console.WriteLine("Kaç adet almak istersiniz");
            int adet = Convert.ToInt32(Console.ReadLine());
            if (urun==u1.Urunadi)
            {
                if (adet <= u1.Stok_miktari && u1.Stok_miktari > 0 && adet > 0)
                {

                    Console.WriteLine("Ürün istediğiniz adette başarıyla satılmıştır. " +
                        "Lütfen belirtilen tutarı kasaya ödeyiniz. Tutar= "  + u1.hesabi_gonder(adet)); 
                }
            }
            else if (urun==u2.Urunadi)
            {
                if (adet <= u2.Stok_miktari && u2.Stok_miktari > 0 && adet > 0)
                {

                    Console.WriteLine("Ürün istediğiniz adette başarıyla satılmıştır. " +
                        "Lütfen belirtilen tutarı kasaya ödeyiniz. Tutar= " + u2.hesabi_gonder(adet));
                }
            }

        }
    }
    class Urunler
    {
        private string urunadi;
        private string kategori;
        private int stok_miktari;
        private double fiyat;
        private double kdv;
        private static double otv = 1;

        public Urunler(string urunadi,string kategori,int fiyat,int stok_miktari)
        {
            this.urunadi = urunadi;
            this.kategori = kategori;
            this.fiyat = fiyat;
            this.stok_miktari = stok_miktari;
        }
        public string Urunadi { get => urunadi; set => urunadi = value; }
        public int Stok_miktari { get => stok_miktari; set => stok_miktari = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }

        public string Kategori {

            get
            {
                return kategori;
            }
                set
            {
                if (value == "Gıda")
                {
                    kdv = 8;
                }
                else if (value=="Giyim")
                {
                    Console.WriteLine(value);
                    kdv = 18;
                    Console.WriteLine(kdv);
                }

            }
                }

        public double hesabi_gonder(int miktar)
        {
            Console.WriteLine(kdv);
            double kdv_tutari = ((fiyat * miktar * kdv) / 100);
            double otv_tutari = ((fiyat * miktar * otv) / 100);
            double hesap= (fiyat * miktar) + kdv_tutari + otv_tutari;
            return hesap;
                 
                
        }
    }
}
