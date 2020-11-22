using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Garage : IEnumerable
    {
        private Car[] cars;
        private Tool[] tools;
        public Garage(Car[] cars)
        {
            this.cars = new Car[cars.Length];
            cars.CopyTo(this.cars, 0);
        }
        public Garage(Car[] cars, Tool[] tools)
            : this(cars)
        {
            this.tools = new Tool[tools.Length];
            tools.CopyTo(this.tools, 0);
        }
        public Car this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        public IEnumerable GetTools()
        {
            foreach (var tool in tools)
            {
                yield return tool;
            }
        }
            
        
    }
}
