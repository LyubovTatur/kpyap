using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace srez
{
    class Program
    {
        static void Main(string[] args)
        {
            var mas = Reader.GetArray("in");
            Reader.ReplaceOddElement(mas, 0);
            Reader.SaveToFile(mas, "out");
            Console.ReadLine(   );
        }
    }
    static class Reader
    {
        public static int[] GetArray(string NameOfFile)
        {
            string[] StrArray  = File.ReadAllLines(NameOfFile+".txt");
            int n = int.Parse(StrArray[0]);
            int[] IntArray = new int[n];
            for (int i = 1; i <= n; i++)
            {
                IntArray[i - 1] = int.Parse(StrArray[i]);
            }
            return IntArray;
        }
        public static void ReplaceOddElement(int[] mas, int value)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]);
                Console.Write(" " );
                if(mas[i] % 2 != 0)
                    mas[i] = value;
                Console.Write(mas[i]);
                Console.WriteLine();
            }
        }
        public static void SaveToFile(int[] mas, string NameOfFile)
        {
            //FileStream f = new FileStream(NameOfFile + ".txt", FileMode.Append);
            string[] text = new string[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                text[i] += mas[i].ToString();
            }
            File.AppendAllLines(NameOfFile + ".txt", text);
        }
    }

}
