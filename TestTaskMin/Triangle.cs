using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskMin
{
   public class Triangle : Figures
    {
       
        public void getTriangle()
        {
            Console.WriteLine($"Ваша фигура -{ Name = "Треугольник"}");
            Console.WriteLine("Ввелите линию: ");
            Line = Convert.ToDouble(Console.ReadLine());
            double a = Line;
            Console.WriteLine("Ввелите линию: ");
            Line = Convert.ToDouble(Console.ReadLine());
            double b = Line;
            Console.WriteLine("Ввелите линию: ");
            Line = Convert.ToDouble(Console.ReadLine());
            double c = Line;
            Square(a, b, c);
            Console.WriteLine($"Имя фигуры {Name}. Площадь равна {Square(a, b, c)}");
        }  
    }
}
