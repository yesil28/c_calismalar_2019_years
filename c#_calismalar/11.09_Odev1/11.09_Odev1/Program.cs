using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09_Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici k1 = new Kullanici();
            Kullanici k2 = new Kullanici();
            k1.Ad = "Ali";
            k1.Konum = "İstanbul";
            k2.Ad = "Ayşe";
            k2.Konum = "Ankara";
            Console.WriteLine("İsim giriniz");
            string isim = Console.ReadLine();
            if (isim==k1.Ad)
            {
                Console.WriteLine(k1.Konum);
            }
            else if (isim==k2.Ad)
            {
                Console.WriteLine(k2.Konum);
            }
            else
            {
                Console.WriteLine("böyle bir kullanıcı sistemde yoktur.");
            }

        }
    }
    class Kullanici
    {
        private string ad;
        private string konum;

        public string Ad { get => ad; set => ad = value; }
        //public string Konum { get => konum; set => konum = value; }

        public string Konum {

            get
            {
                return konum;
            }
            set
            {
                if (value == "")
                {
                    konum = "İstanbul";
                }
                else
                {
                    konum = value;
                }
            }
                }
    }
}
