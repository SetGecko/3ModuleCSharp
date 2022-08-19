using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine(MyFavoriteDay);

            Console.ReadLine();
        }
        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}
