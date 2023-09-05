using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment33
{
    internal class internalclass
    {
        internal int x;
        internal void method()
        {
            Console.WriteLine("internal class is accessed");
            Console.WriteLine("internal class variable have value: " + x);
        }
    }
}