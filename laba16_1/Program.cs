using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace laba16_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList a = new ArrayList() { 4, "dsa", 5, "e"};
            ArrayList b = new ArrayList() { 0, "t", 5,"e", 7 };
            ShowAL(Common(a, b));

            List<char> upPrior = new List<char>() { '*', '/' };
            List<char> lowPrior = new List<char>() { '+', '-' };

            string myStr = "A + B * C";

            Console.WriteLine("Введите инфиксную запись");
            string input = Console.ReadLine();
            var strs = input.Split();
            char[] chrs = new char[strs.Length] ;
            for (int i = 0; i < strs.Length; i++)
            {
                chrs[i] = char.Parse(strs[i]);
            }
            Stack lett = new Stack();
            for (int i = 0; i < chrs.Length; i++)
            {
                if (upPrior.Contains(chrs[i]))
                {
                    
                }
            }

            
            Console.ReadLine();
        }
        static ArrayList Common(ArrayList a, ArrayList b)
        {
            ArrayList common = new ArrayList();
            for (int i = 0; i < a.Count; i++)
            {
                if (b.Contains(a[i]))
                {
                    common.Add(a[i]);
                }
            }
            return common;
        }
        static void ShowAL(ArrayList a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
        }
        
    }
}
