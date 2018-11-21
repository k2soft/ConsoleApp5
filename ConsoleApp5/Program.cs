using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            string kdkd = null;

            int? s = null; //a, teraz ok


            Product pr = new Product() { Name = "test" };
            Product pr1 = new Product();
            var dres = new { pasek1 = "biały" };

            string vhsh = pr?.Name ?? "e";
            bool fName = true;

            string address = pr?.Name?.ToString();

            string first = "Jon", last = "Snow";
            var s_csharp6 = $"{first} likes {last} now {DateTime.Now:d}";
            var dic = new Dictionary<string, int> { ["x"] = 1, ["y"] = 2, };

            string xmlString = "<Products><Product><Id>1</Id><Name>My XML product</Name></Product><Product><Id>2</Id><Name>My second product</Name></Product></Products>";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("Products"));

            StringReader stringReader = new StringReader(xmlString);

            
            List<Product> productList = (List<Product>)serializer.Deserialize(stringReader);

            string outxml = "";



            serializer = new XmlSerializer(typeof(List<Product>),new XmlRootAttribute("Products"));

            using (StringWriter textWriter = new StringWriter())
            {
                serializer.Serialize(textWriter, productList);
                outxml= textWriter.ToString();
            }

            XmlSerializer serializer1 = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("Products"));

            StringReader stringReader1 = new StringReader(outxml);


            List<Product> productList1 = (List<Product>)serializer1.Deserialize(stringReader1);

        }


    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public string Name2 { get; set; } = "Marian";
        public int Id2 { get; set; }
        public bool IsAdmin { get; set; }

     }

    public class funkcjaY
    {
        public int Idy { get; set; }

    }
}
