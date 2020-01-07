using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab kebab1 = new GigaKebabCienki();
            Console.WriteLine(kebab1.GetOpis() + " kosztuje: " + $"{kebab1.Koszt()}");

            kebab1 = new Oliwki(kebab1);
            Console.WriteLine(kebab1.GetOpis() + " kosztuje: " + $"{kebab1.Koszt()}");

            kebab1 = new SosCzosnkowy(kebab1);
            Console.WriteLine(kebab1.GetOpis() + " kosztuje: " + $"{kebab1.Koszt()}");
            Console.ReadLine();

     

        }

        public abstract class Kebab
        {
            public abstract double Koszt();
            public abstract string GetOpis();
            
        }

        class GigaKebabCienki : Kebab
        {
            double koszt = 5.00;



            public override double Koszt()
            {
               
                return koszt;
            }

            public override string GetOpis()
            {
                return "Giga Kebab na Cienkim";
            }
        }

        public abstract class KebabDekorator : Kebab
        {
            protected Kebab kebab;
            public KebabDekorator(Kebab _kebab)
            {
                kebab = _kebab;
            }

            public override string GetOpis()
            {
                return kebab.GetOpis();
            }

            public override double Koszt()
            {
                return kebab.Koszt();
            }
        }

        class Oliwki : KebabDekorator
        {
            public Oliwki(Kebab _kebab):base(_kebab)
            {

            }
            public override double Koszt()
            {
                return 0.50 + kebab.Koszt();
            }
            public override string GetOpis()
            {
                return kebab.GetOpis() + ", Oliwki";
            }

        }
        class SerFeta : KebabDekorator
        {
            public SerFeta(Kebab _kebab) : base(_kebab)
            {

            }
            public override double Koszt()
            {
                return 0.50 + kebab.Koszt();
            }
            public override string GetOpis()
            {
                return kebab.GetOpis() + ", Ser Feta";
            }

        }

        class Cebula : KebabDekorator
        {
            public Cebula(Kebab _kebab) : base(_kebab)
            {

            }
            public override double Koszt()
            {
                return 0.40 + kebab.Koszt();
            }
            public override string GetOpis()
            {
                return kebab.GetOpis() + ", Cebula";
            }

        }

        class SosCzosnkowy : KebabDekorator
        {
            public SosCzosnkowy(Kebab _kebab) : base(_kebab)
            {

            }
            public override double Koszt()
            {
                return 0.60 + kebab.Koszt();
            }
            public override string GetOpis()
            {
                return kebab.GetOpis() + ", Sos Czonskowy";
            }

        }

        class SosMeksykanski : KebabDekorator
        {
            public SosMeksykanski(Kebab _kebab) : base(_kebab)
            {

            }
            public override double Koszt()
            {
                return 0.60 + kebab.Koszt();
            }
            public override string GetOpis()
            {
                return kebab.GetOpis() + ", Sos Meksykanski";
            }

        }


    }
}
