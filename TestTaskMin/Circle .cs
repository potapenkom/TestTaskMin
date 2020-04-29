using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskMin
{
   public class Circle : Figures
    {
        public void getCircleSquere()
        {
            Console.WriteLine($"Ваша фигура -{ Name = "Круг"}");
            Console.WriteLine("Введите радус : ");
            Line = Convert.ToDouble(Console.ReadLine());
            Square((Line));
            Console.WriteLine($"Имя фигуры {Name}. Площадь равна {Square((Line))}");
        }
    }
}