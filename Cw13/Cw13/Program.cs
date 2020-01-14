using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw13
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Car
    {
        protected string Name;
        protected string Model;
        readonly string VIN;
        public string Wheels;
        public string Seats;
        public string Engine;
        public List<string> Equipment;
    }

    public interface IBuilder
    {
        void AddSeats();
        void AddWheels();
        void AddEquipment();
        void AddEngine();
        Car GetCar();
    }

    public class AudiX5 : Car
    {
        public AudiX5()
        {
            Name = "Audi";
            Model = "X5";
        }
    }

    public class X5Builder : IBuilder
    {
        private Car car = new AudiX5();
        public void AddEngine()
        {
            car.Engine = "Diselek, niemiec plakal jak sprzedawal";
        }

        public void AddEquipment()
        {
            car.Equipment = new List<string>();
            car.Equipment.Add("Standardowe radio CD + USB");
            car.Equipment.Add("Lakier matowy, kolor czarny");
        }

        public void AddSeats()
        {
            car.Seats = "Klasyczne fotele. Kolor czarno-niebieski";
        }

        public void AddWheels()
        {
            car.Wheels = "16 calowe stalowe felgi. Opona 205/55 Continental, mozna az driftowac";
        }

        public Car GetCar()
        {
            return car;
        }
    }

    public class PassatLX : Car
    {
        public PassatLX()
        {
            Name = "Passat";
            Model = "LX";
        }
    }

    public class LXBuilder : IBuilder
    {
        private Car car = new PassatLX();
        public void AddEngine()
        {
            car.Engine = "Mmmm Passacik w gazie, mokry sen Janusza";
        }

        public void AddEquipment()
        {
            car.Equipment = new List<string>();
            car.Equipment.Add("Standardowe radio CD");
            car.Equipment.Add("Czerwony kolor blachy");
        }

        public void AddSeats()
        {
            car.Seats = "Skorzane fotele. Kolor szary";
        }

        public void AddWheels()
        {
            car.Wheels = "16 calowe stalowe felgi zimówki";
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
