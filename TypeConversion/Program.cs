using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int olddata = 6;
            string data = olddata.ToString();
            Console.WriteLine(data);
            Console.WriteLine(olddata);
            Console.WriteLine();

            Console.WriteLine("Введите ваш возраст: ");
            int age;
            bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Вам {0} лет", age);
            Console.WriteLine();

            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            byte age2 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Вас зовут {0}, вам {1} лет", name, age2);
            Console.WriteLine();

            Console.WriteLine("Какой ваш любимый день недели?");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш любимый день недели - {0}", day);


            Console.ReadKey();
        }
    }
}
