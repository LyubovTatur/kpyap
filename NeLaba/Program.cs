using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NeLaba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string str = Console.ReadLine();
            {

                //Console.WriteLine("введите слово");
                //string reg = Console.ReadLine();
                //var strsplit = str.Split();
                //var r = new Regex(reg, RegexOptions.IgnoreCase);
                //int k = 0;
                //foreach (var item in strsplit)
                //{
                //    if (r.IsMatch(item))
                //        k++;
                //}
                //Console.WriteLine($"{k} вхождений");
                //Console.ReadKey();
            }
            Regex reg = new Regex(@"(\w)@(\w{2,6})\.(\w{2,4})");
            //Console.WriteLine("Найденные почты:");
            //foreach (var item in reg.Matches(str))
            //{
            //    Console.WriteLine(item);
            //}

            if (reg.IsMatch(str))
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
            Console.ReadLine();
        }
    }
}
