using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;
using Json.Net;
using System.Text.Json;
namespace SerializationAndDe
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog()
            {
                Name = "Dileep kumar",
                Description = "Serialization and Deserialization"
            };
            // string jsonData=JsonConvert.SerializeObject(blog);
            //File.WriteAllText("Data.json",jsonData);
             var demo = File.ReadAllText("Data.json");
           // string data = "{\"Name\":\"Dileep\"," + "\"Description\":\"hello\"}";
            var val = JsonConvert.DeserializeObject<Blog>(demo);
            Console.WriteLine(val.Name+" "+ val.Description);
            



        }
        

    }
    public class Blog
    {
        public string Name {  get; set; }
        public string Description { get; set; }
    }
}
