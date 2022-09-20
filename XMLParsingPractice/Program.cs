using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParsingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                //string filePath = AppDomain.CurrentDomain.BaseDirectory + "XMLParcingPractice.xml";


                string filePath = AppDomain.CurrentDomain.BaseDirectory + "HTMLPage1.html";
                
                if (true)
                {
                    xmlDoc.Load(@"C:\Users\Mubashir Siddique\Documents\Visual Studio 2012\Projects\XMLParsingPractice_12_22_2020\XMLParsingPractice\HTMLPage1.html");
                    //xmlDoc.Load(filePath);

                    XmlNodeList itemNodes = xmlDoc.SelectNodes("//bookstore/book[price>35]");

                    if (itemNodes != null)
                    {
                        foreach (XmlNode itemNode in itemNodes)
                        {
                            if (itemNode != null)
                                Console.WriteLine(itemNode.OuterXml);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Requested Nodes are not present in given XML Document");
                    }
                }
                else
                {
                    Console.WriteLine("The Requested file does not Exists");
                }
                               
                // Previous Practice code 

                //foreach (XmlNode itemNode in itemNodes)
                //{
                //    XmlNode titleNode = itemNode.SelectSingleNode("title");
                //    XmlNode dateNode = itemNode.SelectSingleNode("pubDate");
                //    if ((titleNode != null) && (dateNode != null))
                //        Console.WriteLine(dateNode.InnerText + ": " + titleNode.InnerText);
                //}
                Console.ReadKey();
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Exception Occurs. Please check whether you are performing valid IO operation !!");
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
