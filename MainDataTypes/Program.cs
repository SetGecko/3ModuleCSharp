using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Алексей";
            byte MyAge = 35;
            bool HaveIPet = true;
            double MyShoesSize = 41.0;

            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine("Мой возраст " + MyAge + " лет");
            Console.WriteLine("У меня есть животное? " + HaveIPet);
            Console.WriteLine("Мой размер ноги - " + MyShoesSize);

            Console.WriteLine("Минимальное значение типа Int равно {0}", int.MinValue);
            Console.WriteLine("Максимальное значение типа Int равно {0}", int.MaxValue);

            Console.ReadLine();
        }
    }
}
