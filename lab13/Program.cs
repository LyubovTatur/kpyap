using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {

        //  Класс круг.Свойства центр и радиус.
        //  Операции ++ и --, увеличивают и 
        //  уменьшают радиус круга.Выдавать 
        //  исключения если радиус меньше либо
        //  равен 0, так же при установке 
        //  свойства радиус.


        //  1) Разработать класс, обязательными членами которого должны являться: конструктор, поля, методы, свойства;
        //  2) Создать свой собственный тип исключения и сгенерировать в заданной ситуации.Обеспечить возможность её возникновения.
        //  3) Произвести перехват исключения в методе Main, а также разработать еще один статический метод в классе Program для перехвата исключения.
        //  4) Реализовать программу на C# в соответствии с вариантом исполнения.
        //  5) Выдать значения StackTrace для первого перехваченного исключения и для второго.Проанализировать результаты.


        static void Main(string[] args)
        {
            Circle circle;
            Console.WriteLine("1.");
            try
            {
                Console.WriteLine("circle = new Circle(6, 1);");
                circle = new Circle(6, 1);
                Console.WriteLine("Все круто!");
            }
            catch(MyException e)
            {
                Console.WriteLine(e.MyMessage);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("2.");

            try
            {
                Console.WriteLine("circle = new Circle(6,0);");
                circle = new Circle(6,0);
                Console.WriteLine("Все круто!");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.MyMessage);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("3.");
            circle = new Circle(6, 1);
            try
            {
                Console.WriteLine("circle = new Circle(6, 1);");
                Console.WriteLine("circle--;");
                circle--;
                Console.WriteLine("Все круто!");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.MyMessage);
                Console.WriteLine(e.StackTrace);
            }
            
            Console.WriteLine("4.");
            try
            {
                Console.WriteLine("circle = new Circle(6, -1);");
                circle = new Circle(6, -1);
                Console.WriteLine("Все круто!");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.MyMessage);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();

        }
    }
}
