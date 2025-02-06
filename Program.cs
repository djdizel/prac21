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
            Calculate obj1 = new Calculate();
            Console.WriteLine(obj1.GetInfo());
            Console.WriteLine("Результат: " + obj1.ProcessValues());

            Calculate obj2 = new Calculate(5);
            Console.WriteLine(obj2.GetInfo());
            Console.WriteLine("Результат: " + obj2.ProcessValues());

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculate obj3 = new Calculate(num1, num2);
            Console.WriteLine(obj3.GetInfo());
            Console.WriteLine("Результат: " + obj3.ProcessValues());

            Console.ReadLine();
        }
    }
}
