using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Garage<T, T2> : IEnumerable where T:Car where T2:Tool
    {
        private T[] cars;
        private T2[] tools;
        public Garage(T[] cars)
        {
            this.cars = new T[cars.Length];
            cars.CopyTo(this.cars, 0);
        }
        public Garage(T[] cars, T2[] tools)
            : this(cars)
        {
            this.tools = new T2[tools.Length];
            tools.CopyTo(this.tools, 0);
        }
        public T this[int index]
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
