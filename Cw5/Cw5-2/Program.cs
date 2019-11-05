using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba Jan = new Osoba();

            Jan.Graj();

            IGitarzysta g = Jan;
            ISkrzypek s = Jan;

            g.Graj();
            s.Graj();

            Console.ReadLine();
        }
    }

    interface IGitarzysta
    {
        void Graj();
    }

    interface ISkrzypek
    {
        void Graj();
    }

    class Osoba: IGitarzysta, ISkrzypek
    {
        public void Graj()
        {
            Console.WriteLine("Gram ale nie wiem na czym");
        }
        void IGitarzysta.Graj()
        {
            Console.WriteLine("Gram na gitarze");
        }
        void ISkrzypek.Graj()
        {
            Console.WriteLine("Gram na skrzypcach");
        }

    }
}
