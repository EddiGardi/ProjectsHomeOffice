using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Essensverwaltung
{
    [JsonObject]
    public class Article
    {
        [JsonProperty]
        public string ArticleName { get; set; }

        [JsonProperty]
        public decimal Price { get; set; }

        [JsonProperty]
        public int Amount { get; set; }

        public Article(string name, decimal price, int amount)
        {
            ArticleName = name;
            Price = price;
            Amount = amount;
        }

    }
}
