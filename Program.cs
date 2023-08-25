using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsoftLibraryJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Age = 19,
                FirstName = "Newtonsoft",
                LastName = "Men"
            };

            var jsonDatata = JsonConvert.SerializeObject(person);

            var person2 = JsonConvert.DeserializeObject<Person>(jsonDatata);

            //Console.WriteLine(person2);
            Console.ReadKey();
        }
    }
}
