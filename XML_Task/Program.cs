using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Nya = true;
            while(Nya)
            {
                Console.WriteLine("1. Add sotrudnika after entered.\n" +
                    "2. Find sotrudnika with ZP\n" +
                    "3. Show sotrudnikov\n" +
                    "4. Exit.\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Enter sotrudnik wich will be before");
                            string nameBefore = Console.ReadLine();
                            Console.WriteLine("Enter fio.");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter doljnost");
                            string doljnost = Console.ReadLine();
                            Console.WriteLine("Enter birth");
                            string birth = Console.ReadLine();
                            Console.WriteLine("Enter zarplata");
                            string zarplata = Console.ReadLine();
                            XML_stuff.ChangeXMLDoc(name, doljnost, birth, zarplata, nameBefore);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter ZP");
                            int ZP = int.Parse(Console.ReadLine());
                            XML_stuff.ZPBolsheZadannoy(ZP);
                            break;
                        }
                    case "3":
                        {
                            
                            XML_stuff.ShowDataInXMLDoc("sotrudniki.xml");
                            break;
                        }
                    case "4":
                        {
                            Nya = false;
                            break;
                        }
                    default:
                        break;
                }
            }

        }
       
    }
}
