using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskMin
{
    public class Figures
    {
        public string Name;

        protected double line;
        public double Line
        {
            set
            {
                if (value < 0)
                {
                  
                    throw new ArgumentException("Значение должно быть больше нуля");
                }
                else
                {
                    line = value;
                }
            }
            get { return line; }
        }

        public double Square(double Line)
        {
            double result = Math.PI * Math.Pow(Line, 2);
            return Math.Round(result, 2);
        }

        public double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void getInfo()
        {
            Console.WriteLine($"Имя фигуры {Name}. Площадь равна {Square(line)}");
        }

    }
}
