using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Car:IComparable
    {
        int speed;
        string name;
        public Car(string name, int speed)
        {
            this.speed = speed;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp == null)
            {
                throw new NullReferenceException();
            }
            return speed.CompareTo(temp.speed);
        }

        public override string ToString()
        {
            return $"{name} : {speed}";
        }
        public virtual void Upgrade(int speed)
        {
            speed++;
            Console.WriteLine("speed: {0}", speed);
        }
    }
}
