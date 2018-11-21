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

            StudentClass stt = new StudentClass();
            var highScores = from student in StudentClass.students
                             where student.ExamScores[1] > 90 && student.FirstName.IndexOf("a")>-1
                             orderby student.FirstName
                             select new { Name = student.FirstName, Score = student.ExamScores[1] };

            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.Name,-15}{item.Score}");
            }


            List<int> numbers2 = new List<int>() { 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 };

            var numCount = numbers2.Where(n => n < 13 && n > 7).Count();

            var fdf = from num in numbers2
                      where num < 13 && num > 7
                      orderby num ascending
                      select num;

            IEnumerable<int> largeNumbersQuery = numbers2.Where(c => c > 15);


            Stack st = new Stack();
            int[] ax =  { 1, 2, 3, 4, 5, 6, 7,34,23,16,34 };
            st.Table = ax;

            foreach (int cx in st.FromToBy(3,6,1))
            {
                int df = cx;
            }


            string kdkd = null;

            int? s = null; //a, teraz ok


            Product pr = new Product() { Name = "test" };
            Product pr1 = new Product();
            var dres = new { pasek1 = "biały", pasek2 = "czarny", pasek3 = "niebieski" };

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
