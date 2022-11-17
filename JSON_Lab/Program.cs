using Newtonsoft.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var file = root + Path.DirectorySeparatorChar + "eragon.json";
            var file2 = root + Path.DirectorySeparatorChar + "eldest.json";
            var file3 = root + Path.DirectorySeparatorChar + "inheritance.json";
            var file4 = root + Path.DirectorySeparatorChar + "fablehaven.json";
            var file5 = root + Path.DirectorySeparatorChar + "brisingr.json";

            string jsonString = string.Empty;

            //var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            //Book1
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file))
            {
                jsonString = Sr.ReadToEnd();
            }

            var eragon = JsonConvert.DeserializeObject<Books>(jsonString);

            Console.WriteLine(eragon);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book2
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file2))
            {
                jsonString = Sr.ReadToEnd();
            }

            var eldest = JsonConvert.DeserializeObject<Books>(jsonString);

            Console.WriteLine(eldest);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book3
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file3))
            {
                jsonString = Sr.ReadToEnd();
            }

            var inheritance = JsonConvert.DeserializeObject<Books>(jsonString);

            Console.WriteLine(inheritance);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book4
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file4))
            {
                jsonString = Sr.ReadToEnd();
            }

            var fablehaven = JsonConvert.DeserializeObject<Books>(jsonString);

            Console.WriteLine(fablehaven);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Book5
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            using (var Sr = new StreamReader(file5))
            {
                jsonString = Sr.ReadToEnd();
            }

            var brisingr = JsonConvert.DeserializeObject<Books>(jsonString);

            Console.WriteLine(brisingr);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            //Create A Book
            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------

            VolumeInfo v = new VolumeInfo("Querybuilder Sucks", new List<string> { "Dylan Pogue, Ethan Webb" }, "Querybuilder was probably the worst lab we have ever done...");

            Item i = new Item(v, "12344321", "http://dontclickthis.org");
            Books newBook = new Books(new List<Item>() { i });

            var querybuilder = JsonConvert.SerializeObject(newBook);
            Console.WriteLine(querybuilder);

            //-------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------
        }
    }
}