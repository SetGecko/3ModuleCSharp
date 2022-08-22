using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMainOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);

            double result2 = 14.0 % 7.0;
            Console.WriteLine("14 % 7 = {0}", result2);
            Console.WriteLine();

            int counter = 10;
            Console.WriteLine("Значение счётчика: {0} Префикс Инкремент счётчика: {1}", counter, ++counter);
            Console.WriteLine("Значение счётчика: {0} Префикс Декремент счётчика: {1}", counter, --counter);
            Console.WriteLine("Значение счётчика: {0} Постфикс Инкремент счётчика: {1}", counter, counter++);
            Console.WriteLine("Значение счётчика: {0} Постфикс Декремент счётчика: {1}", counter, counter--);
            Console.WriteLine("Значение счётчика: {0}", counter);
            Console.WriteLine();

            double result3 = 10.0 * 2.0 / 5.0;
            Console.WriteLine("Значение 10 * 2 / 5 = {0}", result3);
            Console.WriteLine();

            Console.WriteLine("Совмещение с арифмитическими операциями");
            double before1 = 10.0;
            double after1 = 5.0;
            after1 += before1;
            Console.WriteLine("Операция присваивания после сложения (10 += 5): {0}", after1);
            double after2 = 15.0;
            after2 -= before1;
            Console.WriteLine("Операция присваивания после вычитания (15 -= 10): {0}", after2);
            double after3 = 15.0;
            after3 *= before1;
            Console.WriteLine("Операция присваивания после умножения  (15 *= 10): {0}", after3);
            double after4 = 200.0;
            after4 /= before1;
            Console.WriteLine("Операция присваивания после деления  (200 /= 10): {0}", after4);
            double after5 = 305.0;
            after5 %= before1;
            Console.WriteLine("Операция присваивания после остатка от деления  (305 %= 10): {0}", after5);
            Console.WriteLine();

            double result4 = 5 % 6;
            Console.WriteLine(result4);

            Console.ReadKey();
        }
    }
}
