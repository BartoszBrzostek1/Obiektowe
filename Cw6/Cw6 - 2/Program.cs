using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura k = new Kwadrat();
            Console.WriteLine("Pole wynosi: {0}",k.Pole(2,3,4));



            Console.ReadLine();
        }
    }

    abstract public class Figura
    {
        protected int a;
        protected int b;
        protected int c;


        abstract public int Pole(int a, int b, int c);


    }

    public class Kwadrat : Figura
    {

        public override int Pole(int a, int b, int c)
        {
            int pole;
            pole = a * b;
            return pole;
        }

    }

    public class Trojkat : Figura
    {

        public override int Pole(int a, int b, int c)
        {
            int pole;
            pole = 1 / 2 * a * b;
            return pole;
        }
    }
}
