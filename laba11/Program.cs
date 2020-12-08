using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      Создать класс Triangle(треугольник). В классе описать следующие элементы:
//          длины сторон;
//          конструкторы без параметров с параметрами; (проверка на создание треунольника)
//          свойства для установки и получения значений всех сторон;
//          метод сравнения двух объектов(сравнивать треугольники по их площадям);
//          метод вывода длин треугольника на экран в виде(a, b, c). (ToString())

namespace laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle a = new Triangle(60, 60, 60);
            Triangle b = new Triangle(78, 78, 78);
            Console.WriteLine($"создан треугольник 1: {a.ToString()}, его площадь равна {a.Square()}");
            Console.WriteLine($"создан треугольник 2: {b.ToString()}, его площадь равна {b.Square()}");
            if (a.CompareTo(b) == 1)
            {
                Console.WriteLine("площадь первого треугольника больше площади второго треугольника.");
            }
            else
            {
                if (a.CompareTo(b) == -1)
                {
                    Console.WriteLine("площадь первого треугольника меньше площади второго треугольника.");
                }
                
                else
                {
                    Console.WriteLine("площадь первого треугольника равна площади второго треугольника.");
                }

            }
                    Console.ReadLine();
        }
    }
}
