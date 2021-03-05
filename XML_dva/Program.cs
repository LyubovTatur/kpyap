using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_dva
{
    class Program
    {
        static void Main(string[] args)
        {
            //XDocument xdoc = new XDocument();
            //// создаем первый элемент
            //XElement iphone6 = new XElement("yam");
            //// создаем атрибут
            //XAttribute iphoneNameAttr = new XAttribute("name", "1");
            //XElement iphoneCompanyElem = new XElement("sweetness", "1");
            //XElement iphonePriceElem = new XElement("chocolatness", "1");
            //XElement am = new XElement("amount", "1");
            //// добавляем атрибут и элементы в первый элемент
            //iphone6.Add(iphoneNameAttr);
            //iphone6.Add(iphoneCompanyElem);
            //iphone6.Add(iphonePriceElem);
            //iphone6.Add(am);

            //XElement phones = new XElement("yams");
            //// добавляем в корневой элемент
            //phones.Add(iphone6);
            //// добавляем корневой элемент в документ
            //xdoc.Add(phones);
            ////сохраняем документ
            //xdoc.Save("yams.xml");

            while (true)
            {
                Show();
                Console.WriteLine("1 post\n" +
                    "2 pok\n" +
                    "3 poisk1\n" +
                    "4 poisk2\n" +
                    "5 vstavka");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Postavka();
                        break;
                    case "2":
                        Pocupka();
                        break;
                    case "3":
                        var str = Console.ReadLine();
                        Poisk1(str);
                        break;
                    case "4":
                        var str1 = Console.ReadLine();
                        Poisk2(str1);
                        break;
                    case "5":
                        Console.WriteLine("name posle");
                        var n1= Console.ReadLine();
                        Console.WriteLine("name");

                        var n = Console.ReadLine();
                        Console.WriteLine("swit");

                        var s = Console.ReadLine();
                        Console.WriteLine("choc");

                        var c = Console.ReadLine();
                        Console.WriteLine("amount");

                        var am = Console.ReadLine();
                        Vstavka(n1, n, s, c, am);
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
        static void Postavka()
        {
            XDocument xdoc = XDocument.Load("yams.xml");
            foreach (var yam in xdoc.Element("yams").Elements("yam").ToList())
            {
                
                
                yam.Element("amount").Value = (int.Parse(yam.Element("amount").Value) + 1).ToString();
                
            }
            xdoc.Save("yams.xml");
        }
        static void Pocupka()
        {
            XDocument xdoc = XDocument.Load("yams.xml");
            foreach (XElement yam in xdoc.Element("yams").Elements("yam"))
            {
                if(yam.Element("amount").Value != "0")
                {
                    yam.Element("amount").Value = (int.Parse(yam.Element("amount").Value)-1).ToString();
                }
            }
            xdoc.Save("yams.xml");
        }
        static void Poisk1(string str)
        {
            XDocument xdoc = XDocument.Load("yams.xml");
            foreach (XElement yam in xdoc.Element("yams").Elements("yam"))
            {
                if (yam.Element("sweetness").Value == str)
                {
                    
                    Console.WriteLine($"i find yam! it is { yam.Attribute("name").Value}!");
                }
            }
            xdoc.Save("yams.xml");
        }
        static void Poisk2(string str)
        {
            XDocument xdoc = XDocument.Load("yams.xml");
            foreach (XElement yam in xdoc.Element("yams").Elements("yam"))
            {
                if (yam.Element("chocolatness").Value == str)
                {
                    Console.WriteLine($"i find yam! it is { yam.Attribute("name").Value}!");
                }
            }
            xdoc.Save("yams.xml");
        }
        static void Vstavka(string str, string name, string sw, string ch, string amount)
        {
            XDocument xdoc = XDocument.Load("yams.xml");
            bool find = false;
            foreach (XElement yam in xdoc.Element("yams").Elements("yam"))
            {
                if (yam.Attribute("name").Value == str)
                {
                    find = true;
                }
                if (find)
                {
                    find = false;
                    XElement a = new XElement("yam");
                    // создаем атрибут
                    XAttribute n = new XAttribute("name", name);
                    XElement s = new XElement("sweetness", sw);
                    XElement c = new XElement("chocolatness", ch);
                    XElement am = new XElement("amount", amount);
                    a.Add(n);
                    a.Add(s);
                    a.Add(c);
                    a.Add(am);
                    xdoc.Element("yams").Element("yam").AddAfterSelf(a);
                }
            }
            xdoc.Save("yams.xml");
        }

        static void Show()
        {
            XDocument xdoc = XDocument.Load("yams.xml");
            foreach (XElement yam in xdoc.Element("yams").Elements("yam"))
            {
                XAttribute name = yam.Attribute("name");
                XElement sweetness = yam.Element("sweetness");
                XElement chocolatness = yam.Element("chocolatness");
                XElement amount = yam.Element("amount");
                if (name != null && sweetness != null && chocolatness != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                    Console.WriteLine($"Yum: {name.Value}");
                    Console.WriteLine($"sweetness: {sweetness.Value}");
                    Console.WriteLine($"chocolatness: {chocolatness.Value}");
                    Console.WriteLine($"amount: {amount.Value}");
                    Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
