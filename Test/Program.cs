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
            Car[] cars =
            {
                new Car("Tesla",300),
                new Car("shesterka", 60),
                new Car("Honda",150)
            };
            Tool[] tools =
             {
                new Tool("scissors"),
                new Tool("wrench"),
                new Tool("screwdriver"),
             };

            Array.Sort(cars);

            Garage garage = new Garage(cars, tools);

            foreach (var car in garage)
            {
                Console.WriteLine(car.ToString());
            }

            garage[0] = new Car("lambo", 10);

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
