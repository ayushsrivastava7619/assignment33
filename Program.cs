using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            internalclass inti = new internalclass();
            inti.x = 45;

            Console.WriteLine("Main class got access the other internal class");
            inti.method();
            Console.Read();
        }
    }
}