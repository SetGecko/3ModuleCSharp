using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age2 = 35;
            Console.WriteLine($"Мой возраст {age2}");

            string name = "Jane";
            byte age = 27;
            string favcolor = "black";
            Console.WriteLine("{0}\n  {1}\n {2}", name, age, favcolor);


        }
    }
}
