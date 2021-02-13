using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cowotainer cowo = new Cowotainer(6, 100);
            Console.WriteLine(cowo.ToString());
            cowo = cowo + 3;
            Console.WriteLine(cowo.ToString());
            Console.WriteLine(cowo.Length);
            Console.WriteLine(cowo[1]);
            Console.WriteLine(cowo[4]);
            Console.WriteLine(cowo[cowo.Length]);
            Console.ReadLine();
        }
    }
}
