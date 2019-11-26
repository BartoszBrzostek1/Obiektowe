using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Cw8p
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myInt = new ArrayList();
            myInt.Add(1);
            myInt.Add(5);
            ArrayList myStr = new ArrayList();
            myStr.Add("Siwi");
            myStr.Add("Wow!");
            ArrayList myOso = new ArrayList();

            Osoba o = new Osoba();
            o.UstawImie("Bartosz");
            o.UstawWiek(22);
            myOso.Add(o);
            
           

            Console.ReadLine();
        }
    }

    class Osoba
    {
        private string imie;
        private int wiek;

        public Osoba()
        {

        }

        public Osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }

        public void UstawImie(string imie)
        {
            this.imie = imie;
        }
           

        public void UstawWiek(int wiek)
        {
            this.wiek = wiek;
        }
    }

}

