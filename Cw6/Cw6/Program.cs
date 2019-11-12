using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracowniks = new List<Pracownik>();
            pracowniks.Add(new Programista());
            pracowniks.Add(new Projektant());
            pracowniks.Add(new Ksiegowy());

            foreach(Pracownik p in pracowniks)
            {
                p.Pracuj();
                
            }


            Console.ReadLine();
        }
    }

    public class Pracownik
    {
        public virtual void Pracuj()
        {
            Console.WriteLine("Pracownik pracuje");
        }
             
    }

    public class Programista : Pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki programisty");
        }
    }

    public class Projektant : Pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki projektanta");
        }
    }

    public class Ksiegowy : Pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki ksiegowego");
        }

    }
        
}
