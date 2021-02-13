using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Task
{
    static class XML_stuff
    {
        public static void ShowDataInXMLDoc(string path)
        {
            //string path = "sotrudniki.xml";
            XmlDocument document = new XmlDocument();
            document.Load(path);
            XmlElement root = document.DocumentElement;
            foreach (XmlNode node in root)
            {
                if (node.Attributes.Count > 0)
                {
                    XmlNode attribute = node.Attributes.GetNamedItem("name");
                    if (attribute != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
                        Console.WriteLine(attribute.Value);
                    }
                }

                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "doljnost")
                    {
                        Console.WriteLine($"Должность: {childNode.InnerText}");
                    }
                    if (childNode.Name == "birth")
                    {
                        Console.WriteLine($"ДР: {childNode.InnerText}");
                    }
                    
                    if (childNode.Name == "zarplata")
                    {
                        Console.WriteLine($"ЗП: {childNode.InnerText}");
                    }
                }
            }
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
            Console.WriteLine();
        }
        public static void ChangeXMLDoc(string nameS, string doljnostS, string birthS,  string zarplataS , string namesotrudnikBefore)
        {
            string path = "sotrudniki.xml";
            
            XmlDocument document = new XmlDocument();
            document.Load(path);
            //
            var sotrudnikiChild = document.SelectSingleNode("sotrudniki");
            //
            XmlElement root = document.DocumentElement;
            //
            var newDoc = new XmlDocument();
            var node = newDoc.CreateElement("sotrudniki");
            newDoc.AppendChild(node);
            var sotrudnikiChildNodes = sotrudnikiChild.ChildNodes;
            
            //
            XmlElement sotrudnik = document.CreateElement("sotrudnik");
            XmlAttribute attributeName = document.CreateAttribute("name");
            XmlElement doljnost = document.CreateElement("doljnost");
            XmlElement birth = document.CreateElement("birth");
            XmlElement zarplata = document.CreateElement("zarplata");

            XmlText nameText = document.CreateTextNode(nameS);
            XmlText doljnostText = document.CreateTextNode(doljnostS);
            XmlText birthText = document.CreateTextNode(birthS);
            XmlText zarplataText = document.CreateTextNode(zarplataS);

            attributeName.AppendChild(nameText);
            doljnost.AppendChild(doljnostText);
            birth.AppendChild(birthText);
            zarplata.AppendChild(zarplataText);
            
            sotrudnik.Attributes.Append(attributeName);
            sotrudnik.AppendChild(doljnost);
            sotrudnik.AppendChild(birth);
            sotrudnik.AppendChild(zarplata);

            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                if (root.ChildNodes[i].Attributes["name"].Value == namesotrudnikBefore)
                {
                    root.InsertAfter(sotrudnik, root.ChildNodes[i]);
                }
            }

            //var nodeBefore = root.SelectSingleNode($sotrudnik[@name='{namesotrudnikBefore}’]");
            //root.AppendChild(sotrudnik);
            //root.InsertAfter(sotrudnik, nodeBefore);
            document.Save(path);

        }
        public static void ZPBolsheZadannoy(int ZP)
        {
            string path = "sotrudniki.xml";

            XmlDocument document = new XmlDocument();
            document.Load(path);
            //
            var sotrudnikiChild = document.SelectSingleNode("sotrudniki");
            //
            XmlElement root = document.DocumentElement;
            //
            var newDoc = new XmlDocument();
            var node = newDoc.CreateElement("sotrudniki");
            newDoc.AppendChild(node);
            var sotrudnikiChildNodes = sotrudnikiChild.ChildNodes;

            //XmlElement sotrudnik = newDoc.CreateElement("sotrudnik");
            //XmlAttribute attributeName = newDoc.CreateAttribute("name");
            //XmlElement doljnost = newDoc.CreateElement("doljnost");
            //XmlElement birth = newDoc.CreateElement("birth");
            //XmlElement zarplata = newDoc.CreateElement("zarplata");

            //sotrudnik.Attributes.Append(attributeName);
            //sotrudnik.AppendChild(doljnost);
            //sotrudnik.AppendChild(birth);
            //sotrudnik.AppendChild(zarplata);

            for (int i = 0; i < sotrudnikiChildNodes.Count; i++)
            {
                if (int.Parse(sotrudnikiChildNodes[i].SelectSingleNode("zarplata").InnerText) >= ZP)
                {
                    Console.WriteLine("_-_-_");
                    Console.WriteLine($"name: { sotrudnikiChildNodes[i].Attributes["name"].InnerText}");
                    Console.WriteLine($"ZP: {sotrudnikiChildNodes[i].SelectSingleNode("zarplata").InnerText}");
                    Console.WriteLine("_-_-_");
                    Console.WriteLine();

                    //newDoc.FirstChild.AppendChild(sotrudnikiChildNodes[i]);
                }
            }
            
            //newDoc.Save("newdoc.xml");
            //ShowDataInXMLDoc("newdoc.xml");
        }
    }
}
//сотрудник:
//фио
//должность
//дог родзения
//зп

//-запись нового после заданного
//-поиск по зп больше заданной


//  var countryChild = document.SelectSingleNode("countries");
//  var newDocument = new XmlDocument();
//  var node = newDocument.CreateElement("countries");
//  newDocument.AppendChild(node);
//  var countryChildNodes = countryChild?.ChildNodes;
//  if (countryChildNodes == null) return newDocument;
//  for (var i = 0; i < countryChildNodes.Count; i++)
//  {
//      var population = int.Parse(countryChildNodes?[i].SelectSingleNode("Population")?.InnerText!);
//      if (population >= startRange &&
//          population <= finishRange)
//          newDocument.FirstChild.AppendChild(countryChildNodes?[i]!);
//  }

//  return newDocument;