using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_урока_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первой вершиный x1,y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второй вершины x2,y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второй вершины x3,y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int a = (x2 - x1) * (x3 - x1) + (y2 - y1) * (y3 - y1);
            // противоположные стороны прямоуголника равны, т.е А=С и B=D
            // условие паралельности осям выполняется если 

            if (y1 == y2 & x2 == x3)
            {
                int x4 = x1;
                int y4 = y3;
                Console.WriteLine(x4);
                Console.WriteLine(y4);
            }
            else
            {
                Console.WriteLine("Ne pravda");
            }

            Console.ReadKey();
        }

        }
    }

