using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isci_sorusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Isci i1 = new Isci();
            Isci i2 = new Isci();
            i1.Id = 1;
            i1.Departman = "Muhasebe";
            i1.Maas = 1000;
            i2.Id = 2;
            i2.Departman = "Yonetim";
            i2.Maas = 2000;

            Console.WriteLine("işçi id'si giriniz");
            int id = Convert.ToInt32(Console.ReadLine());
            Isci igenel = new Isci();// mevcut işçi nesnesini belirtir.
            if (id==i1.Id)
            {
                igenel = i1;
                Console.WriteLine("1.işçinin Maaşı = " + i1.Maas_Hesaplama()); 
            }
            else if (id == i2.Id)
            {
                igenel = i2;
                Console.WriteLine("2.işçinin Maaşı = " + i2.Maas_Hesaplama());
            }
            else
            {
                Console.WriteLine("var olmayan işçi id'si girdiniz");
            }
            Console.WriteLine("İşçiye zam yapılsın mı e ya da h");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim=='e')
            {
                //if (id == i1.Id)
                //{
                //    i1.Zamyap();
                //    Console.WriteLine(i1.Maas_Hesaplama()); 
                //}
                igenel.Zamyap();
                Console.WriteLine(igenel.Maas_Hesaplama());
            }
        
            Console.WriteLine("Ek ödenek değiştirilsin mi e ya da h");
            secim = Convert.ToChar(Console.ReadLine());
            if (secim == 'e')
            {
                Console.WriteLine("Ek ödenek ne olsun");
                int yeni_ekodenek = Convert.ToInt32(Console.ReadLine());
                Isci.Ekodenek = yeni_ekodenek;//static field
                
                Console.WriteLine(i1.Maas_Hesaplama()); 
                Console.WriteLine(i2.Maas_Hesaplama());
            }
           


        }
    }
    class Isci
    {
        private int id;
        private int maas;
        private string departman;
        private byte departman_oran;
        private static int ekodenek=100;

        public int Id { get => id; set => id = value; }
        public int Maas { get => maas; set => maas = value; }
        public string Departman {
            get { return departman; }
            set {
                if (value == "Muhasebe")
                {
                    departman_oran = 10;
                }
                else if (value=="Yonetim")
                {
                    departman_oran = 20;
                }
                else
                {
                    Console.WriteLine("Hatalı Departman Girişi");
                }
            }

        }
        public static int Ekodenek { get => ekodenek; set => ekodenek = value; }

        public void Zamyap()
        {
            maas = maas+(maas * 10 / 100);
        }

        public void Ekodenek_degistir(int ekodenek)
        {
            Ekodenek = ekodenek;
        }
        public int Maas_Hesaplama()
        {
            return maas + ((maas * departman_oran) / 100) + Ekodenek;
        }
    }
}
