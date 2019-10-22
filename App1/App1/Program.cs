using System;

namespace App1
{
    class Program
    {


        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", 1991);
            Car car2 = new Car("Ferrari", 2010);

            Console.WriteLine("Marka = {0} , Rok = {1}", car1.Marka, car1.Rok);
            Console.WriteLine("Marka = {0} , Rok = {1}", car2.Marka, car2.Rok);

           


            Console.ReadKey();
        }

    }
}
