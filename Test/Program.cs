using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar[] cars =
            {
                new SportCar("tesla",300),
                new SportCar("shesterka", 60),
                new SportCar("honda",150)
            };

            ElectroCar[] cars1 =
            {
                new ElectroCar("tesla",300),
                new ElectroCar("shesterka", 60),
                new ElectroCar("honda",150)
            };

            Tool[] tools =
             {
                new Tool("scissors"),
                new Tool("wrench"),
                new Tool("screwdriver"),
             };

            Array.Sort(cars);

            Garage<SportCar, Tool> garage = new Garage<SportCar, Tool>(cars, tools);

            Garage<ElectroCar,Tool> garage1 = new Garage<ElectroCar, Tool>(cars1, tools);

    
            foreach (var car in garage1)
            {
                Console.WriteLine(car.ToString());
                Console.WriteLine(car.GetType().Name);
            }

            garage[0] = new SportCar("lambo", 10);

            foreach (var car in garage)
            {
                Console.WriteLine(car.ToString());
            }

            foreach (var tool in garage.GetTools())
            {
                Console.WriteLine(tool.ToString());
            }

            Console.ReadKey();

        }
    }
}
