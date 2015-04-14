using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace _02XML文件
{
    class Program
    {
        static void Main(string[] args)
        {

            //引用命名空间

            //1.创建XML文件

            //2.创建XML文件

            XmlDocument doc = new XmlDocument();
           
            

            //两个概念 Node Element

            //所有的都是元素

            //一个个标签 是节点 （元素包含节点）

            //创建描述信息，添加到doc文档中

            XmlDeclaration xmld = doc.CreateXmlDeclaration("1.0", "utf-8", null);

            doc.AppendChild(xmld);

            XmlElement books = doc.CreateElement("Books");

           


            //给根节点books创建节点

            XmlElement book1 = doc.CreateElement("Book");

            books.AppendChild(book1);

            //给book1 创建子节点

            XmlElement name1 = doc.CreateElement("Name");        

            XmlElement price1 = doc.CreateElement("Price");

            XmlElement des1 = doc.CreateElement("Des");

            name1.InnerText = "<p>我是一个P标签</p>";

            des1.InnerXml = "<p>我也是一个P标签</p>";

            price1.InnerText = "10.0";


            book1.AppendChild(name1);

            book1.AppendChild(price1);

            book1.AppendChild(des1);


            //给book2创建


            XmlElement book2 = doc.CreateElement("Book");

            books.AppendChild(book2);

          

            XmlElement name2 = doc.CreateElement("Name");

            XmlElement price2 = doc.CreateElement("Price");

            XmlElement des2 = doc.CreateElement("Des");

            name2.InnerText = "水浒装";

            des2.InnerText = "108拆迁队";

            price2.InnerText = "20.0";


            book2.AppendChild(name2);

            book2.AppendChild(price2);

            book2.AppendChild(des2);



            doc.AppendChild(books);


            //创建带属性的XML

            XmlElement xmlitems = doc.CreateElement("Items");

            books.AppendChild(xmlitems);

            XmlElement item = doc.CreateElement("Item");

            item.SetAttribute("Name", "码表");

            item.SetAttribute("Count", "15");

            XmlElement item2 = doc.CreateElement("Item");

            item2.SetAttribute("Name", "卡曼");

            item2.SetAttribute("Count", "20");

            xmlitems.AppendChild(item);
            xmlitems.AppendChild(item2);


            


            doc.Save("books.xml");


            //追加XML文件

            //文件存在|文件不存在

            XmlDocument xmldoc = new XmlDocument();

            if (File.Exists("books.xml"))
            {
                //加载XML文件

                doc.Load("books.xml");

                //如果存在拿到根节点

                XmlElement xmlelement = doc.DocumentElement;

                //在后面追加内容
            }
            else
            {

                XmlDeclaration xmldes = doc.CreateXmlDeclaration("1.0", "utf-8", null);

                xmldoc.AppendChild(xmldes);


 
            }


            //读取XML文件内容

            XmlElement xmlddd = doc.DocumentElement;

            XmlNodeList xmllist = doc.ChildNodes;

            foreach (XmlNode xl in xmllist)
            {
                Console.WriteLine(xl.InnerText);

                //xl.Attributes["Name"].Value;   Node属性值


            }


            Console.ReadKey();

        }
    }
}
