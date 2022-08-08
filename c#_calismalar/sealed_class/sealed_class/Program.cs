using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Araba
    {
        private int kapisayisi;
        private string plaka;
        public virtual void Git()
        {
            Console.WriteLine("Araba gidiyor");
        }
      }
    class Minibus : Araba
    {
        sealed public override void Git()//başka bir sınıftan devralınmış metod, override edilmiş
        {
            Console.WriteLine("Minibus gidiyor");
         }
        public void Geridon()
        {
            Console.WriteLine("Geri dönüyorum");
        }
    }
    class Kamyon : Minibus
    {
        public override void Git()// git metodunu kullanamaz.
        {
            Console.WriteLine("Kamyon gidiyor.");
        }

    }
}
