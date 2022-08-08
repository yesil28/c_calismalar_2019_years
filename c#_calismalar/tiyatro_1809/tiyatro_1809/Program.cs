using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiyatro_1809
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiyatro t1 = new Tiyatro(50,10,5);
            char secim;
            int toplamtambilet = 0;
            int toplaminidirmli = 0;
            int tambiletsayisi = 0;
            int indirimlibiletsayisi = 0;
            do
            {
                Console.WriteLine("Kaç adet bilet istersiniz? Tam ve indirimli sayılarını belirtin.20 10");
                string[] biletbilgileri = Console.ReadLine().Split(' ');
                tambiletsayisi = Convert.ToInt32(biletbilgileri[0]);
                indirimlibiletsayisi = Convert.ToInt32(biletbilgileri[1]);
                if (tambiletsayisi + indirimlibiletsayisi < t1.Koltuk_sayisi)
                {

                    toplamtambilet += tambiletsayisi;
                    toplaminidirmli += indirimlibiletsayisi;
                    Console.WriteLine("Boş koltuk sayisi= " + t1.Koltuksayisi_dusur(tambiletsayisi + indirimlibiletsayisi));
                    Console.WriteLine("Başka bilet istermisiniz, e ya da h");
                    secim = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Elimizde istediğiniz adette koltuk yoktur.");
                    secim = 'e';
                }
            } while (secim=='e');

            Console.WriteLine("Toplam ödeyeceğiniz ücret = " + t1.UcretHesapla(toplamtambilet, toplaminidirmli)); 

        }
    }
    class Tiyatro
    {
        private int koltuk_sayisi;
        private int tambilet_ucret;
        private int inidirmlibilet_ucret;

        public int Koltuk_sayisi { get => koltuk_sayisi; set => koltuk_sayisi = value; }

        public Tiyatro(int k_sayisi,int tam,int indirimli)
        {
            Koltuk_sayisi = k_sayisi;
            tambilet_ucret = tam;
            inidirmlibilet_ucret = indirimli;
        }

        public int UcretHesapla(int tam,int indirimli)
        {
            return (tambilet_ucret * tam) + (inidirmlibilet_ucret * indirimli);

        }
        public int Koltuksayisi_dusur(int alinan_koltuk)
        {
            Koltuk_sayisi = Koltuk_sayisi - alinan_koltuk;
            return Koltuk_sayisi;
        }


    }
}
