using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Tool
    {
        string name;
        public Tool(string name)
        {
            this.name = name;
        }


        public override string ToString() 
        {
            return $"{name} ";
        }
    }
}
