using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CarCare.Class
{
    [JsonObject]
    public class Group
    {
        [JsonProperty]
        public string PartName { get; set; }

        public Group(string partName)
        {
            PartName = partName;
        }
    }
}
