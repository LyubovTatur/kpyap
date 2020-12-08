using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            
                string text = File.ReadAllText("text.txt");
                Regex reg = new Regex(@"^[бвгджзйклмнпрстфхцчшщ]+\w*", RegexOptions.IgnoreCase);
                bool flag = true;
                string[] mas = text.Split();
                for (int i = 0; i < mas.Length; i++)
                {


                    if (reg.IsMatch(mas[i]))
                    {

                        Console.WriteLine(mas[i]);
                    }
                }

                text = string.Join("<Br>", mas, 0, mas.Length);
                Console.ReadLine();
            

            // Задание 2
            
                string texttohtml = "";
                var text2 = File.ReadAllLines("text2.txt");
                string pattern1 = "(^Fs)(\\d+) ";
                string pattern2 = " P ";
                string pattern3 = "<Pre>";
            for (int i = 0; i < text2.Count(); i++)
            {
                {
                    texttohtml += "<P>";
                    Regex reg2 = new Regex(pattern1);
                    Match match = reg2.Match(text2[i]);
                    text2[i] = reg2.Replace(text2[i], "");
                    Group g = match.Groups[2];
                    texttohtml += $"<Font size = \"{g}\">";
                    reg2 = new Regex(pattern2);
                    text2[i] = reg2.Replace(text2[i], " <Pre>  ", 1);
                    text2[i] = reg2.Replace(text2[i], " </Pre>  ");
                    reg2 = new Regex(pattern3);
                    texttohtml += text2[i];
                    texttohtml += $"</Font>";
                    texttohtml += "</P>";
                }
            }

            GreateHtmlDoc(texttohtml);
        }
        public static void GreateHtmlDoc(string TextInBody)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html >");
            sb.Append("<head >");
            string meta = @"<meta charset=""UTF-8"">";
            sb.Append(meta);
            sb.Append("<title >");
            sb.Append("</title >");
            sb.Append("</head >");
            sb.Append("<body >");
            sb.Append(TextInBody);
            sb.Append("</body >");
            sb.Append("</html >");
            using (StreamWriter sw = new StreamWriter("MyHtml.html"))
            {
                sw.Write(sb.ToString());
                sw.Close();
                Console.WriteLine("Файл создан успешно!");
                System.Diagnostics.Process.Start("MyHtml.html");
            }
        }
    }
}
