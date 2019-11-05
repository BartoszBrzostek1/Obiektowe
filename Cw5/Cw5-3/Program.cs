using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();

            obiekt1.liczba = 255;
            obiekt2 = obiekt1;
            obiekt3 = (Test)obiekt1.Clone();
            obiekt1.liczba = 347;

            Console.WriteLine(obiekt1.liczba);
            Console.WriteLine(obiekt2.liczba);
            Console.WriteLine(obiekt3.liczba);

            Console.ReadLine();
        }
    }

    class Test: ICloneable
    {

        public long liczba;
        Test2 poleTestowe;

        public Test()
        {

        }

        public Test(Test2 poleTestowe)
        {
            
            
        }

        public Object Clone()
        {
            return MemberwiseClone();
        }


    }

    class Test2
    {
        public string slowo;

    }
}
