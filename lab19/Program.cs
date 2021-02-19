using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace lab19
{
    class Program
    {
        static object locker = new object();
        static int t1 = 400;
        static int t2 =550;
        static void Main(string[] args)
        {
            //подсчитать сумму цифр числа, кратным двум из файла number.in
            // t1 =0.4 t2 = 0.55
            StreamReader sr = new StreamReader("number.in");
            object number = (object)sr.ReadLine();
            sr.Close();
            Thread thread1 = new Thread(new ParameterizedThreadStart(Thread1));
            Thread thread2 = new Thread(new ParameterizedThreadStart(Thread2));
            thread1.Start(number);
            thread2.Start(number);
            Console.ReadLine();
        }

        public static void Thread1(object number)
        {
            bool locker2 = false;
            try
            {
                Monitor.Enter(locker, ref locker2);
                int num = int.Parse(number.ToString());
                int sum = 0;
                int numCount = num.ToString().Length;
                int x = 1;
                StreamWriter sw = new StreamWriter("state.out");
                while (num > 0)
                {
                  sw.WriteLine($"delegat #1 |*| iter #{x} | sum:{sum} | time:{DateTime.Now.ToLongTimeString()} | perhent: {(double)x / numCount * 100}% |");
                    Iter1(ref num, ref sum);
                    Thread.Sleep(t1);
                    x++;
                }
            }
            finally
            {
                if (locker2) Monitor.Exit(locker);
            }



        }
        public static void Thread2(object number)
        {

            bool locker2 = false;
            try
            {

                Monitor.Enter(locker, ref locker2);
                int num = int.Parse(number.ToString());
                int sum = 0;
                int numCount = num.ToString().Length;
                StreamWriter sw = new StreamWriter("state.out");
                int x = 1;
                while (num > 0)
                {
                    sw.WriteLine($"delegat #2 |*| iter #{x} | sum:{sum} | time:{DateTime.Now.ToLongTimeString()} | perhent: {(double)x/numCount*100}% |");
                    Iter2(ref num, ref sum);
                    Thread.Sleep(t2);
                    x++;
                }
            }
            finally
            {
                if (locker2) Monitor.Exit(locker);
            }

            

        }
        public static void Iter1(ref int num, ref int sum)
        {
                if (num % 10 % 2 == 0)
                {
                    sum += num % 10;
                }
                num /= 10;

            
        }
        public static void Iter2(ref int num, ref int sum)
        {
            
            
                if (num % 10 % 2 == 0)
                {
                    sum += num % 10;
                }
                num /= 10;

            
        }
    }
}
