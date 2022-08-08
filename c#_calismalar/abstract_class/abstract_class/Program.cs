using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan asli = new Insan();
            kim_konusacak(asli);
            Kopek foni = new Kopek();

            kim_konusacak(foni);
        }

        public static void kim_konusacak(Canli yenicanli)
        {
            yenicanli.Konus();

        }
        
    }
    abstract class Canli//base class,temel sınıf
    {
        private int el;
        private int ayak;
        private string tur;
        abstract public void Konus();
    }
    class Insan:Canli
    {
        public override void Konus()
        {
            Console.WriteLine("ben konuştum");
        }
    }
    class Kopek : Canli
    {
       
        public override void Konus()
        {
            Console.WriteLine("hav hav");
        }
    }
}
