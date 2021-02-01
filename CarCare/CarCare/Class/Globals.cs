using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;

namespace CarCare.Class
{
    public static class Globals
    {
        public static bool exists = false;
        public static string uebergabe = "";
        public static string path = System.IO.Path.Combine(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName.ToString(), ("Resources/Data/Service.json"));
        public static Class.Service serviceNew = JsonConvert.DeserializeObject<Class.Service>(File.ReadAllText(path));
        public static ObservableCollection<Class.Part> serviceList;
        public static Class.ServiceFlattened tempService = new Class.ServiceFlattened("", "", DateTime.Parse("01/01/2000"), 0, "");
    }
}
