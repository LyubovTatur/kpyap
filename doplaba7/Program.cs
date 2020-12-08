using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doplaba7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ("У лукоморья дуб зелёный;\n" +
                          "Златая цепь на дубе том:\n" +
                          "И днём и ночью кот учёный\n" +
                          "Всё ходит по цепи кругом;\n" +
                          "Идёт направо — песнь заводит,\n" +
                          "Налево — сказку говорит.\n" +
                          "Там чудеса: там леший бродит,\n" +
                          "Русалка на ветвях сидит;\n" +
                          "Там на неведомых дорожках\n" +
                          "Следы невиданных зверей;\n" +
                          "Избушка там на курьих ножках\n" +
                          "Стоит без окон, без дверей;\n" +
                          "Там лес и дол видений полны;\n" +
                          "Там о заре прихлынут волны\n" +
                          "На брег песчаный и пустой,\n" +
                          "И тридцать витязей прекрасных\n" +
                          "Чредой из вод выходят ясных,\n" +
                          "И с ними дядька их морской;\n" +
                          "Там королевич мимоходом\n" +
                          "Пленяет грозного царя;\n" +
                          "Там в облаках перед народом\n" +
                          "Через леса, через моря\n" +
                          "Колдун несёт богатыря;\n" +
                          "В темнице там царевна тужит,\n" +
                          "А бурый волк ей верно служит;\n" +
                          "Там ступа с Бабою Ягой\n" +
                          "Идёт, бредёт сама собой,\n" +
                          "Там царь Кащей над златом чахнет;\n" +
                          "Там русский дух… там Русью пахнет!\n" +
                          "И там я был, и мёд я пил;\n" +
                          "У моря видел дуб зелёный;\n" +
                          "Под ним сидел, и кот учёный\n" +
                          "Свои мне сказки говорил.");

            //Console.WriteLine(text);
            //funk1(text);
            //Console.WriteLine("________________________________");
            //funk2(text);
            Console.WriteLine("________________________________");
            //GlasSoglas(text);
            DateTime start = DateTime.Now;
            Console.WriteLine(Show(text));
            DateTime end = DateTime.Now;
            Console.WriteLine(end-start);
            DateTime start1 = DateTime.Now;
            Console.WriteLine(Fast(text));
            DateTime end1 = DateTime.Now;
            Console.WriteLine($"string - {end - start}, stringbuilder - {end1 - start1}");
            Console.ReadLine();
            

        }
        static void funk1(string text)
        {
            var words = text.Split();
            //List<StringBuilder> wordsSB = new List<StringBuilder>();
            //words.CopyTo(wordsSB, 0);
           
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(new char[] { '.', ':', ';', '?', '!', ',', '…' });
                StringBuilder wordsSB = new StringBuilder(words[i]);
                if (wordsSB.Length > 6)
                {
                    wordsSB[3] = '#';
                    wordsSB[6] = '#';
                }
                else
                {
                    if(wordsSB.Length > 3)
                    {
                        wordsSB[3] = '#';
                    }
                }
                words[i] = wordsSB.ToString();
                Console.WriteLine(words[i]);
            }


            
        }
        static void funk2(string text)
        {
            var words = customSplit(text);
            HashSet<string> wordSet = new HashSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                wordSet.Add(words[i]);
            }
            int[] kolvo = new int[wordSet.Count];
            int Index = 0;
           
            foreach (var item in wordSet)
            {
                int count = 0;
                for (int i = 0; i < words.Length; i++)
                {
                
                    if (item == words[i])
                        count++;

                }
                kolvo[Index] = count;
                
                Console.WriteLine($"{item} = {kolvo[Index]}");
                Index++;
            }
           


        }
        static void GlasSoglas(string text)
        {
            var words = customSplit(text);
            
            // char[] sogl = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф','х', 'ц', 'ч', 'ш', 'щ' };
            List<string> rightRords = new List<string>();
            
            for (int i = 0; i < words.Length; i++)
            {
                if (IsSoglGl(words[i]))
                {
                    rightRords.Add(words[i]);
                }

            }
            foreach (var item in rightRords)
            {
                Console.WriteLine(item);
            }
               
        }
        private static bool IsSoglGl(string word)
        {
            char[] glas = new char[] { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е', 'Ы', 'У', 'Е', 'Ё', 'А', 'О', 'Э', 'Я', 'И', 'Ю' };
            if (!glas.Contains<char>(word[0]) && glas.Contains<char>(word[word.Length - 1]))
            {
                return true;
            }
            else return false;

        }
        static string[] customSplit(string text)
        {
            var words = text.Split();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(new char[] { '.', ':', ';', '?', '!', ',', '…' });
            }
            return words;
        }


        //      Сформировать и вернуть в методе string Slow(string text)
        //      из случайных слов исходного текста строку string
        //      минимум в сто тысяч символов путем конкатенации.
        //      Слова должны быть склеены через один пробел. Затем 
        //      в Main определить время работы метода Slow
        //      и вывести его(т.е.время) на консоль.Ускорить 
        //      процесс, используя StringBuilder
        //      (сделать новый метод string Fast(string text)
        //      Итог строки должен быть точно такой же как и в 
        //      методе Slow, до буквы) в Main повторить вывод.
        //      Сравнить время работы двух этих методов.
        static string Show(string text)
        {
            var words = customSplit(text);


            
            Random rng = new Random();
            string str = "";
            while(str.Length<100000)
            {
                str += " " + words[rng.Next(words.Length-1)];
            }
            return str;    
            
        }

        static string Fast(string text)
        {
            var words = customSplit(text);


            
            Random rng = new Random();
            StringBuilder str = new StringBuilder(" ");
            while (str.Length < 100000)
            {
                str.Append(" " + words[rng.Next(words.Length - 1)]);
            }
            return str.ToString();

        }
    }
}

