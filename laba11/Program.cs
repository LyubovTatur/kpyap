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
            int n = 20;
            Triangle[] arr = new Triangle[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Triangle(random.Next(10, 100), random.Next(10, 100), random.Next(10, 100));
            }
            ShowArray(arr);
            Array.Sort(arr);
            ShowArray(arr);
            //Console.WriteLine($"создан треугольник 1: {a.ToString()}, его площадь равна {a.Square()}");
            //Console.WriteLine($"создан треугольник 2: {b.ToString()}, его площадь равна {b.Square()}");
            //switch (a.CompareTo(b))
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("площадь первого треугольника больше площади второго треугольника.");
            //            break;
            //        }
            //    case -1:
            //        {
            //            Console.WriteLine("площадь первого треугольника меньше площади второго треугольника.");
            //            break;
            //        }
            //    case 0:
            //        {
            //            Console.WriteLine("площадь первого треугольника равна площади второго треугольника.");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Ошибка.");
            //            break;
            //        }
            //}
            Console.ReadLine();
            
                    
        }
        static void ShowArray(Triangle[] arr)
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString() + " "+ arr[i].Square().ToString());
            }
        }
    }
}
