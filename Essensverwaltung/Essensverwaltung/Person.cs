using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Essensverwaltung
{
    [JsonObject]
    public class Person
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string FirstName { get; set; }

        [JsonProperty]
        public decimal Credit { get; set; }

        public Person(string name, string firstname, decimal credit)
        {
            Name = name;
            FirstName = firstname;
            Credit = credit;
        }
    }
}
