using Newtonsoft.Json;
using System.Collections.Generic;

namespace NewtonsoftLibraryJson
{
    public class Person
    {
        [JsonProperty("Age")]
        public int Age { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Cars")]
        public List<Cars> Cars { get; set; }

    }

    public class Cars
    {
        [JsonProperty("Avto1")]
        public string Auto1 { get; set; }

        [JsonProperty("Avto2")]
        public string Auto2 { get; set; }
    }
}