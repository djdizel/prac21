using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac21
{
    internal class Calculate
    {
        private double number1;
        private double number2;

        public Calculate()
        {
            number1 = 0;
            number2 = 0;
        }

        public Calculate(double value)
        {
            number1 = value;
            number2 = value;
        }

        public Calculate(double value1, double value2)
        {
            number1 = value1;
            number2 = value2;
        }

        public string GetInfo()
        {
            return $"Число 1: {number1}, Число 2: {number2}";
        }

        public double ProcessValues()
        {
            return Math.Sqrt(number1 * number2);
        }
    }
}

