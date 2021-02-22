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
        static int t1 = 200;
        static int t2 =550;
        static void Main(string[] args)
        {
            //подсчитать сумму цифр числа, кратным двум из файла number.in
            // t1 =0.4 t2 = 0.55
            StreamReader sr = new StreamReader("number.in");
            object number = (object)sr.ReadLine();

            string num = number.ToString();
             int numCount = num.ToString().Length;
            //Console.WriteLine(numCount);
            sr.Close();
            Thread thread1 = new Thread(new ParameterizedThreadStart(Thread1));
            thread1.Name = "1";
            Thread thread2 = new Thread(new ParameterizedThreadStart(Thread2));
            thread2.Name = "2";
            thread1.Start(number);
            thread2.Start(number);
            Console.ReadLine();
        }

        public static void Thread1(object number)
        {
            
            string num = number.ToString();
            int sum = 0;
            int numCount = num.ToString().Length;
            int x = 1;
            while (x<=numCount)
            {
               
                Iter(ref num, ref sum, ref x, numCount);
                Thread.Sleep(t1);
                

            }



        }
        public static void Thread2(object number)
        {

            string num = number.ToString();
            int sum = 0;
            int numCount = num.ToString().Length;
            int x = 1;
            while (x<=numCount)
            {

                    Iter(ref num, ref sum, ref x, numCount);
                    Thread.Sleep(t2);
                

               
            }

            

        }
        
        public static void Iter(ref string num, ref int sum,ref int x, int numCount)
        {

            Monitor.Enter(locker);
            string str = num.ToString();

            Console.WriteLine(str[x-1]);
            if (char.IsDigit(str[x-1]))
            {
                int digit = int.Parse(str[x-1].ToString());


                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
                StreamWriter sw = new StreamWriter("state.out", true);
                sw.WriteLine($"delegat #{Thread.CurrentThread.Name} |*| iter #{x} | sum:{sum} | time:{DateTime.Now.ToLongTimeString()} | perhent: {(double)x / numCount * 100}% |");
                Console.WriteLine($"delegat #{Thread.CurrentThread.Name} |*| iter #{x} | sum:{sum} | time:{DateTime.Now.ToLongTimeString()} | perhent: {Math.Round((double)x / numCount * 100, 2)} % |");
                x++;
                sw.Close();
            
            num.Substring(num.Length - 1);

            Monitor.Exit(locker);   
            

        }
    }
}
