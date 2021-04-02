using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace laba20
{
    class Program
    {
        static CancellationTokenSource cansel = new CancellationTokenSource();
        static CancellationToken token = cansel.Token;
        static  void Main(string[] args)
        {
           // Func<double, double, int, Test, int> func = Ln;
            Test test = new Test();
            test.Progress = 1;
            //Console.WriteLine("x э (-1;1)");
            //Console.Write("x = ");
            // double x = double.Parse(Console.ReadLine());
            double x = 0.008;
            //Console.Write("delta = ");
            //double delta = double.Parse(Console.ReadLine());
            double delta = 0.0001;
            //Console.WriteLine();
            Task.Run(() => TaskAsync(x, delta, 1, test));
            var s = Console.ReadKey();
            if (s.Key == ConsoleKey.Spacebar)
            {
                cansel.Cancel();
            }
            Console.ReadKey();
        }
        static  void TaskAsync(double value, double delta, int step, Test test)
        {
            
            while (test.Progress > delta)
                {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("(отвлекнулся на печеньку)");
                    break;
                }
                    var t = Ln(value, delta, step,  test);
                //Console.WriteLine($"result = {test.CurrentResult}\t progress = {test.Progress} (Main)");

                Thread.Sleep(300);
                }
                
            
        }
        static  Test Ln(double value,double delta,  int step,  Test test)
        {
            // 3 вариант
            double part = 1;
            for (int i = 0; i < step; i++)
            {
                part *= value;
            }
            part /= step;
            if (step % 2 == 0)
            {
                part *= -1;
            }
            test.CurrentResult += part;
            test.Progress = delta / test.CurrentResult;
            step++;
            Console.WriteLine($"result = {test.CurrentResult}\t progress = {test.Progress} (не Main)");
            return test;
        }
        static  void AsyncCallback(IAsyncResult result)
        {
            Test t = result.AsyncState as Test;
            Console.WriteLine($"result = {t.CurrentResult}\t progress = {t.Progress} (Async)");
            
        }
    }
}
