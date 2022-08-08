using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sdf");
            Ogrenci ogr1 = new Ogrenci("Ali","Matematik");
            Ogrenci ogr2 = new Ogrenci("Ayşe","Edebiyat");

            Console.WriteLine(ogr1.Ad + " isimli öğrencinin notlarını giriniz. Arada boşluk kullanınız");
            string[] notlar1 = Console.ReadLine().Split(' ');

            ogr1.Y1 = Convert.ToByte(notlar1[0]);
            ogr1.Y2 = Convert.ToByte(notlar1[1]);
            ogr1.P1 = Convert.ToByte(notlar1[2]);

            do
            {
                Console.WriteLine(ogr2.Ad + " isimli öğrencinin notlarını giriniz. Arada boşluk kullanınız");
                string[] notlar2 = Console.ReadLine().Split(' ');

                ogr2.Y1 = Convert.ToByte(notlar2[0]);
                ogr2.Y2 = Convert.ToByte(notlar2[1]);
                ogr2.P1 = Convert.ToByte(notlar2[2]);
                Console.WriteLine("sf" + ogr2.P1);
            } while (ogr2.Y1==250 || ogr2.Y2==250 || ogr2.P1==250);
            Console.WriteLine("Öğrenci ismi giriniz=");
            string isim = Console.ReadLine();

            if (isim==ogr1.Ad)
            {
                Console.WriteLine("bu öğrencinin dersi " + ogr1.Ders);
                Console.WriteLine("bu öğrencinin bu dersten ortalaması " + ogr1.ortalama().ToString());
            }
            else if (isim==ogr2.Ad)
            {
                Console.WriteLine("bu öğrencinin dersi " + ogr2.Ders);
                Console.WriteLine("bu öğrencinin bu dersten ortalaması " + ogr2.ortalama().ToString());
            }
            else
            {
                Console.WriteLine("hatalı giriş");
            }



        }
    }
    class Ogrenci
    {
        private string ad;
        private string ders;
        private byte y1;
        private byte y2;
        private byte p1;
     
        public Ogrenci(string ad,string ders)
            {
            this.ad = ad;
            this.ders = ders;
           
            }

        public string Ad { get => ad; set => ad = value; }
        public string Ders { get => ders; set => ders = value; }
        public byte Y1 {

            get { return y1; }

            set {

                if (value < 0 || value > 100)
                {
                    Console.WriteLine("notu 0 ile 100 arasında giriniz.");
                    y1 = 250;
                }
                else
                {
                    y1 = value;
                    
                }
            }
        }
        public byte Y2
        {

            get { return y2; }

            set
            {

                if (value < 0 || value > 100)
                {
                    Console.WriteLine("notu 0 ile 100 arasında giriniz.");
                    y2 = 250;
                }
                else
                {
                    y2 = value;
                    
                }
            }
        }
        public byte P1
        {

            get { return p1; }

            set
            {

                if (value < 0 || value > 100)
                {
                    Console.WriteLine("notu 0 ile 100 arasında giriniz.");
                    p1 = 250;
                        
                }
                else
                {
                    p1 = value;
                    
                }
            }
        }

      
        public int ortalama()
        {
            return (y1 + y2 + p1) / 3;
        }
    }
}
