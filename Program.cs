using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time obj1 = new Time();
            obj1 = new Time();
            Console.WriteLine(obj1.GetInfo());
            Console.WriteLine("Общее количество минут: " + obj1.CalculateTotalMinutes());
            Console.WriteLine("Общее количество секунд: " + obj1.CalculateTotalSeconds());

            Time obj2 = new Time(5, 30);
            Console.WriteLine(obj2.GetInfo());
            Console.WriteLine("Общее количество минут: " + obj2.CalculateTotalMinutes());
            Console.WriteLine("Общее количество секунд: " + obj2.CalculateTotalSeconds());

            Console.Write("Введите количество часов: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество минут: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество секунд: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            Time obj3 = new Time(hours, minutes, seconds);
            Console.WriteLine(obj3.GetInfo());
            Console.WriteLine("Общее количество минут: " + obj3.CalculateTotalMinutes());
            Console.WriteLine("Общее количество секунд: " + obj3.CalculateTotalSeconds());

            Console.ReadLine();
        }
    }
}
