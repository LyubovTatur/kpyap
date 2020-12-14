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
    class Triangle : IComparable <Triangle>
    {
        public Triangle()
        {
        }

        public Triangle(double AtoB, double BtoC, double CtoA)
        {
            if (AtoB+BtoC>CtoA && BtoC+CtoA > AtoB && CtoA+AtoB>BtoC)
            {
                this.AtoB = AtoB;
                this.BtoC = BtoC;
                this.CtoA = CtoA;
            }
            else
            {
                Console.WriteLine("Невозможно создать треугольник");
                AtoB = 0;
                BtoC = 0;
                CtoA = 0;
            }
        }

        private double atob;
        private double btoc;
        private double ctoa;

        public double AtoB
        {
            get
            {
                return atob;
            }
            set
            {
                if (value < 0)
                {
                    atob = Math.Abs(value);
                    Console.WriteLine("в сторону с отрицательным значением был записан модуль числа");
                }
                else
                {
                    atob = value;
                }
            }
        }
        public double BtoC
        {
            get
            {
                return btoc;
            }
            set
            {
                if (value < 0)
                {
                    btoc = Math.Abs(value);
                    Console.WriteLine("в сторону с отрицательным значением был записан модуль числа");
                }
                else
                {
                    btoc = value;
                }
            }
        }
        public double CtoA
        {
            get
            {
                return ctoa;
            }
            set
            {
                if (value < 0)
                {
                    ctoa = Math.Abs(value);
                    Console.WriteLine("в сторону с отрицательным значением был записан модуль числа");
                }
                else
                {
                    ctoa = value;
                }
            }
        }

        private double HalfP()
        {
            return (AtoB + BtoC + CtoA) / 2;
        }
        public double Square()
        {
            return Math.Round(Math.Sqrt(HalfP()*(HalfP()-AtoB)*( HalfP()-BtoC)*(HalfP()-CtoA)), 2);
        }
        public int CompareTo(Triangle triangle)
        {
            if (Square()>triangle.Square())
            {
                return 1;
            }
            else
            {
                if (Square() < triangle.Square())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public override string ToString()
        {
            return $"({AtoB},{BtoC},{CtoA})";
        }

    }
}
