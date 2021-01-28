using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CarCare.Class
{
    [JsonObject]
    public class Service
    {
        [JsonProperty]
        public List<Motorraum> Motorraum { get; set; }
        [JsonProperty]
        public List<Vorderrad> Vorderrad { get; set; }
        [JsonProperty]
        public List<Hinterrad> Hinterrad { get; set; }
        [JsonProperty]
        public List<Innenraum> Innenraum { get; set; }
        public Service(int call)
        {
            if (call == 0)
            {
                Motorraum = new List<Motorraum>();
            }
            else if (call == 1)
            {
                Vorderrad = new List<Vorderrad>();
            }
            else if (call == 2)
            {
                Hinterrad = new List<Hinterrad>();
            }
            else
            {
                Innenraum = new List<Innenraum>();
            }

        }
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
        public Motorraum(int call)
        {
            if (call == 0)
            {
                Luftfilter = new List<Part>();
            }
            else if (call == 1)
            {
                Öl = new List<Part>();
            }
            else if (call == 2)
            {
                Steuerkette = new List<Part>();
            }
            if (call == 3)
            {
                Kettenspanner = new List<Part>();
            }
            else if (call == 4)
            {
                Batterie = new List<Part>();
            }
            else if (call == 5)
            {
                Zündkerze = new List<Part>();
            }
            else if (call == 6)
            {
                Bremsflüssigkeit = new List<Part>();
            }
        }
    }

    public class Vorderrad
    {
        [JsonProperty]
        public List<Part> Reifen { get; set; }
        [JsonProperty]
        public List<Part> Bremsscheibe { get; set; }
        [JsonProperty]
        public List<Part> Bremsbelag { get; set; }
        public Vorderrad(int call) {
            if (call == 0)
            {
                Reifen = new List<Part>();
            }
            else if (call == 1)
            {
                Bremsscheibe = new List<Part>();
            }
            else if (call == 2)
            {
                Bremsbelag = new List<Part>();
            };
        }
    }

    public class Hinterrad 
    {
        [JsonProperty]
        public List<Part> Reifen { get; set; }
        [JsonProperty]
        public List<Part> Bremsscheibe { get; set; }
        [JsonProperty]
        public List<Part> Bremsbelag { get; set; }
        public Hinterrad(int call)
        {
            if (call == 0)
            {
                Reifen = new List<Part>();
            }
            else if (call == 1)
            {
                Bremsscheibe = new List<Part>();
            }
            else if (call == 2)
            {
                Bremsbelag = new List<Part>();
            };
        }
    }

    public class Innenraum 
    {
        [JsonProperty]
        public List<Part> Innenraumfilter { get; set; }
        public Innenraum() { Innenraumfilter = new List<Part>(); }
    }

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
    }
}

