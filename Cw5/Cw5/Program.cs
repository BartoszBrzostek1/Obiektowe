using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw5
{
    class Program
    {
        static void Main(string[] args)
        {

            IRideable car1 = new Car();
            IRideable bicycle1 = new Bicycle();

            car1.Ride();
            bicycle1.Ride();

            Console.ReadLine();
        }
    }

    class Vehicle
    {

    }

    class Car: Vehicle, IRideable
    {
        void IRideable.Ride()
        {
            Console.WriteLine("Jade Samochodem");
    
        }
    }

    class Bicycle : Vehicle, IRideable
    {
        void IRideable.Ride()
        {
            Console.WriteLine("Jade Rowerem");
        }
    }

    interface IRideable
    {
        void Ride();

    }
}
