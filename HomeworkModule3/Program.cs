using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModule3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет? ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0} и Вам {1} лет. Очень приятно!", name, age);
            Console.WriteLine("Введите Вашу дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Дата Вашего дня рождения: {0}", birthdate);
            Console.ReadKey();
        }
    }
}
