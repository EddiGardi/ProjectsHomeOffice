using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CarCare.Class
{
    [JsonObject]
    public class ServiceFlattened
    {
        [JsonProperty]
        public string Group { get; set; }

        [JsonProperty]
        public string PartName { get; set; }

        [JsonProperty]
        public DateTime ChangingDate { get; set; }

        [JsonProperty]
        public DateTime ChangedLast { get; set; }

        [JsonProperty]
        public int Odometer { get; set; }

        [JsonProperty]
        public string MoreInfos { get; set; }

        public ServiceFlattened(string group, string name, DateTime changedDate, int odo, string moreInfos)
        {
            Group = group;
            PartName = name;
            ChangingDate = changedDate.AddYears(2);
            ChangedLast = changedDate;
            Odometer = odo;
            MoreInfos = moreInfos;
        }
    }
}