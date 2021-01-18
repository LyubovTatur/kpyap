using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace laba15_dop
{
    class Program
    {
        static string[] names = { "Боба", "Шлепик", "Борька", "Мася", "Маруська", "Попик", "Крыська" };
        static string[] colors = { "розовый", "порозовее", "посветлее", "светлый", "маленький", "большой", "пушистый" };
        static string[] made_of = { "плосмаски","сырового", "моей майки которую мама у меня украла", "тканевых обрывков", "бумаговых материалов", "кортоны" };
        static void Main(string[] args)
        {
            Random random = new Random();
            Kotiksi[][] kotiksis = new Kotiksi[4][];
            for (int i = 0; i < kotiksis.GetLength(0); i++)
            {
                kotiksis[i] = new Kotiksi[5]; 
                for (int j = 0; j < 5; j++)
                {
                    kotiksis[i][j] = new Kotiksi(names[random.Next(names.Length)], colors[random.Next(colors.Length)]);
                }
               
            }
            Boxes[] boxes = new Boxes[4];
            
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new Boxes(i, made_of[random.Next(made_of.Length)], kotiksis[i]);
            }
            SerializeBoxes(boxes);
        }
        static void SerializeBoxes(Boxes[] boxes)
        {
            SoapFormatter formatter = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("koropki.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, boxes);

                Console.WriteLine("Объект сериализован");
            }
        }
    }
    
}
