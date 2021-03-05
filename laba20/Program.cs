﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace laba20
{
    class Program
    {
        static void Main(string[] args)
        {
           // Func<double, double, int, Test, int> func = Ln;
            Test test = new Test();
            Console.WriteLine("x э (-1;1)");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("delta = ");
            double delta = double.Parse(Console.ReadLine());
            TaskAsync(x, delta, 1, test);

        }
        static async void TaskAsync(double value, double delta, int step, Test test)
        {
            await Task.Run(() => 
            {
                while (t.Progress>delta)
                {
                    var t = Ln(value, delta, step,  test);
                     
                }
                
            });
            
        }
        static async Test Ln(double value,double delta,  int step,  Test test)
        {
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
            Console.WriteLine($"result = {test.CurrentResult}\t progress = {test.Progress} (Main)");
            return test;
        }
        static  void AsyncCallback(IAsyncResult result)
        {
            Test t = result.AsyncState as Test;
            Console.WriteLine($"result = {t.CurrentResult}\t progress = {t.Progress} (Async)");
            
        }
    }
}
