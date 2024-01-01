using System.Xml.Linq;

namespace CSharp.LINQ
{
    public class XML
    {
        public XML() { 
            ParseXML();
        }

        public void ParseXML() {

            string xmlPath = $"""{Directory.GetCurrentDirectory()}/Library.xml""";

            XDocument document = XDocument.Load(xmlPath);

            var elements = document.Descendants("Book");

            foreach ( var element in elements ) { 

                string isbn = element.Attribute("ISBN").Value;

                string title = element.Element("Title").Value;

                Console.WriteLine(isbn);
                Console.WriteLine("---" + title);
            }


            var lsISBS = elements.Select(x => x.Attribute("ISBN").Value);

            var nestedElements = document
                                        .Elements("Section")
                                        .Elements("Book");

            var singleElement = document.Element("Library");

            XDocument copyDocument = XDocument.Parse(singleElement.ToString());

            XElement newElement = new XElement("Book");

            newElement.Add(new XAttribute("ISBN", Guid.NewGuid()));

            document.Element("Library").Elements("Section").Last().Add(newElement);


            document.Descendants("Book").Where(x => x.Attribute("ISBN").Value == "978-0-123456-78-9").Remove();

            document.Save(xmlPath);

            Console.Read();
        }

    }
}
