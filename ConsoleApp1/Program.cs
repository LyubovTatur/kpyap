using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            SortWords();
            SecondFunk();
            Console.ReadLine();
        }
        static void SortWords()
        {
            Console.WriteLine("Введите");
            string str = Console.ReadLine();
            string[] str1 = str.Split(' ');
            str1[0] = str1[0].Trim();
            
            int I = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i]!="")
                {
                    //str2[I] = str1[i];
                    I++;
                }
            }
            string[] str2 = new string[I];
            I = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != "")
                {
                    str2[I] = str1[i];
                    I++;
                }
            }
            string[] str3 = new string[str2.Length];
            str3 = Sort(str2,true);
            foreach (var item in str3)
            {
                Console.Write('/');
                Console.Write(item);
                Console.Write('/');
                Console.WriteLine();
            }
        }
        public static string[] Sort(string[] array, bool order)
        {
            string box;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (order)
                    {
                        if (array[i].Length > array[j].Length)
                        {
                            box = array[i];
                            array[i] = array[j];
                            array[j] = box;

                        }
                    }
                    else
                    {
                        if (array[i].Length < array[j].Length)
                        {
                            box = array[i];
                            array[i] = array[j];
                            array[j] = box;
                        }
                    }
                }
            }
            return array;
           
        }
        static void SecondFunk()
        {
            Console.WriteLine("Введите 1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите 2");
            string str2 = Console.ReadLine();
            if(str1.Length > str2.Length)
            {
                if(str1.IndexOf(str2)!=-1)
                {
                    Console.WriteLine("В первой строке, которая длиннее, содержится вторая.");
                }
                else
                {
                    Console.WriteLine("В первой строке, которая длиннее, не содержится вторая.");

                }
            }
            if(str1.Length < str2.Length)
            {
                if (str2.IndexOf(str1) != -1)
                {
                    Console.WriteLine("Во второй строке, которая длиннее, содержится первая.");
                }
                else
                {
                    Console.WriteLine("Во второй  строке, которая длиннее, не содержится первая.");

                }

            }
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("Строки равные по длинне.");
            }

            
        }
    }
    
}
