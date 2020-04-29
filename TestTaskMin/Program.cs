using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskMin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите фигурe : \n 1.\tКруг;\n 2.\tТриугольник;\n 3.\tВыход;\n ");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Circle circle = new Circle();
                    circle.getCircleSquere();
                    break;
                case 2:
                    Triangle triangle = new Triangle();
                    triangle.getTriangle();
                    break;
                case 3:
                    Console.WriteLine("Выход");
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
            Console.ReadLine();
        }
    }
}
