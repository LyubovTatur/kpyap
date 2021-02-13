using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notations
{
    class Program
    {
        static char[] operators = { '/', '*', '-', '+' };
        static void Main(string[] args)
        {
            string text = "A+C*D";
            Console.WriteLine(text);
            Console.WriteLine(Postf(text));
            Console.WriteLine(Prefx(text));
            Console.ReadLine();
        }

        static string Postf(string symbs)
        {
            string queue = "";
            Stack<char> stack = new Stack<char>();
            //Queue<char> queue = new Queue<char>();
            for (int i = 0; i < symbs.Length; i++)
            {
                //1
                if (Char.IsLetter(symbs[i]))
                {
                    queue+=symbs[i];// если переменная то в очередягу
                }
                //2
                if (operators.Contains(symbs[i]))
                {

                    if ((stack.Count == 0 || stack.Peek() == '(') || ((stack.Peek() == '+' || stack.Peek() == '-') && (symbs[i] == '*' || symbs[i] == '/')))
                    {
                        stack.Push(symbs[i]);
                    }
                    else
                    {
                        
                            while (stack.Peek() != '+' && stack.Peek() != '-' && stack.Peek() != '(')
                            {
                                queue+=stack.Pop();
                                if (stack.Count == 0)
                                break;
                                
                            }
                        
                        stack.Push(symbs[i]);
                    }
                }
                //3
                if (symbs[i] == '(')
                {

                    stack.Push(symbs[i]);
                }
                //4
                if (symbs[i] == ')')
                {

                    while (stack.Peek() != '(')
                        queue += stack.Pop();
                    stack.Pop();
                }

            }
            //5
            while (stack.Count != 0)
            {
                queue += stack.Pop();
            }
            
            return queue;
        }
        static string Prefx(string input)
        {
            string reverseInput = "";
            //for (int i = input.Length-1; i >= 0; i--)
            //{
            //    reverseInput += input[i];
            //}
            reverseInput = new string(input.ToCharArray().Reverse().ToArray());
            reverseInput = Postf(reverseInput);
            string result = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    result += reverseInput[i];
            //}

            return new string(reverseInput.ToCharArray().Reverse().ToArray());
        }
        static int priority(char e)
        {
            int pri = 0;

            if (e == '*' || e == '/' || e == '%')
            {
                pri = 2;
            }
            else
            {
                if (e == '+' || e == '-')
                {
                    pri = 1;
                }
            }
            return pri;
        }
    }
}
