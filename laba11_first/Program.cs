using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      Создать массив целых чисел(случайно и от руки).
//      Отсортировать его при помощи Array.Sort так,
//      чтобы вначале были 10, затем 8, после 6,
//      а далее в обычном порядке.Пример 10, 8, 8 ,25,14,3…

namespace laba11_first
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 5, 8, 8, 10, 4, 6, 10, 5, 6 };
            int[] arr2 = CreateArr(10);
            int n = int.Parse(Console.ReadLine());
            int[] arr3 = CreateArr(n);
            Console.WriteLine("первый");
            PrintArr(arr1, n);
            Array.Sort(arr1, new mysort());
            Console.WriteLine();
            Console.WriteLine("первый отсорт.");
            PrintArr(arr1, n);
            Console.WriteLine();
            Console.WriteLine("рандомный");
            PrintArr(arr2, n);
            Array.Sort(arr2, new mysort());
            Console.WriteLine();
            Console.WriteLine("рандомный отсорт.");
            PrintArr(arr2, n);
            Console.ReadLine();
            PrintArr(arr3, n);
            Array.Sort(arr3, new mysort());

        }

        private static int[] CreateArr(int n)
        {
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = r.Next(20);
            }
            return arr;
        }

        private static void PrintArr(int[] arr1, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
        }
    }
}
