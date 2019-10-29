using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1;
            int liczba2 = 30;
            int liczba3 = 0;

            try
            {
                liczba1 = liczba2 / liczba3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally!");
            }

            Console.ReadLine();
        }
    }
}
