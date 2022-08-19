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

            string myName = "Computer";
            Console.WriteLine("");
            Console.WriteLine("Привет, человек!");
            Console.WriteLine("Меня зовут {0}", myName);
            Console.WriteLine("");
            Console.WriteLine("А как тебя зовут?");
            string YourName = Console.ReadLine();
            Console.WriteLine("Рад встрече, {0}", YourName);

            Console.ReadKey();
        }
    }
}
