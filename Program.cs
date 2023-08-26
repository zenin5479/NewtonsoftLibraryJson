using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace NewtonsoftLibraryJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = File.Exists("person.json")
                ? JsonConvert.DeserializeObject<Person>(File.ReadAllText("person.json")) : new Person
                {
                    Age = 19,
                    FirstName = "Newtonsoft",
                    LastName = "Men",
                    Cars = new List<Cars>
                    {
                        new Cars
                        {
                            Auto1 = "BMV",
                            Auto2 = "AUDI"
                        }
                    }
                };

            File.WriteAllText("person.json", JsonConvert.SerializeObject(person));
            var obj = JsonConvert.DeserializeObject<Person>(File.ReadAllText("person.json"));

            //Console.WriteLine(obj);
            Console.ReadKey();
        }
    }
}
