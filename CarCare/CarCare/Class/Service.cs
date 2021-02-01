using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CarCare.Class
{
    [JsonObject]
    public class Service
    {
        [JsonProperty]
        public Motorraum Motorraum { get; set; }
        [JsonProperty]
        public Vorderrad Vorderrad { get; set; }
        [JsonProperty]
        public Hinterrad Hinterrad { get; set; }
        [JsonProperty]
        public Innenraum Innenraum { get; set; }
    }

    public class Motorraum
    {
        [JsonProperty]
        public List<Part> Luftfilter { get; set; }
        [JsonProperty]
        public List<Part> Öl { get; set; }
        [JsonProperty]
        public List<Part> Steuerkette { get; set; }
        [JsonProperty]
        public List<Part> Kettenspanner { get; set; }
        [JsonProperty]
        public List<Part> Batterie { get; set; }
        [JsonProperty]
        public List<Part> Zündkerze { get; set; }
        [JsonProperty]
        public List<Part> Bremsflüssigkeit { get; set; }
        public Motorraum() { }
    }

    public class Vorderrad
    {
        [JsonProperty]
        public List<Part> Reifen { get; set; }
        [JsonProperty]
        public List<Part> Bremsscheibe { get; set; }
        [JsonProperty]
        public List<Part> Bremsbelag { get; set; }
        public Vorderrad() { }
    }

    public class Hinterrad 
    {
        [JsonProperty]
        public List<Part> Reifen { get; set; }
        [JsonProperty]
        public List<Part> Bremsscheibe { get; set; }
        [JsonProperty]
        public List<Part> Bremsbelag { get; set; }
        public Hinterrad() { }
    }

    public class Innenraum 
    {
        [JsonProperty]
        public List<Part> Innenraumfilter { get; set; }
        public Innenraum() { }
    }

    [JsonObject]
    public class Part
    {
        [JsonProperty]
        public int Eintrag { get; set; }
        [JsonProperty]
        public DateTime Frist { get; set; }
        [JsonProperty]
        public DateTime Zuletzt { get; set; }
        [JsonProperty]
        public int Kilometerstand { get; set; }
        [JsonProperty]
        public string Info { get; set; }

        public Part (int insert, DateTime changedDate, int odo, string moreInfos )
        {
            Eintrag = insert;
            Frist = changedDate.AddYears(2);
            Zuletzt = changedDate;
            Kilometerstand = odo;
            Info = moreInfos;
        }
    }
}

