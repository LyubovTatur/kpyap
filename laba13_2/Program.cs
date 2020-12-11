using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13_2
{
    delegate string d();
    class Program
    {
        
        static void Main(string[] args)
        {
            d d1;
            while (true)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            d1 = new d(DrawFace.Happy);
                            Console.WriteLine(d1());
                            break;
                        }
                    case "2":
                        {
                            d1 = new d(DrawFace.Sad);
                            Console.WriteLine(d1());
                            break;
                        }
                    case "3":
                        {
                            d1 = new d(DrawFace.Thinky);
                            Console.WriteLine(d1());
                            break;
                        }
                }
            }
            
        }
    }
}
