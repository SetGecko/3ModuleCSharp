using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesConstantsLiterals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Алексей";
            Console.WriteLine(myName);

            Console.WriteLine("\tПривет мир!");
            Console.WriteLine("\tМне 35 лет");
            Console.WriteLine("\tМеня зовут\n Алексей");

            Console.WriteLine("Привет,\n  мир");

            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.ReadLine();
        }
    }
}
