using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;
using System.Collections.ObjectModel;

namespace CarCare
{
    public static class Globals
    {
        public static bool exists = false;
        public static string uebergabe = "";
        public static string path = System.IO.Path.Combine(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName.ToString(), ("Resources/Data/Service.json"));
        public static string path2 = System.IO.Path.Combine(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName.ToString(), ("Resources/Data/Service2.json"));
        public static List<Class.Service> serviceNew = JsonConvert.DeserializeObject<List<Class.Service>>(File.ReadAllText(path2));
        public static List<Service> service = JsonConvert.DeserializeObject<List<Service>>(File.ReadAllText(path));
        public static ObservableCollection<Service> serviceList;
        public static Service tempService = new Service("", "", DateTime.Parse("01/01/2000"), 0, "");
        public static int call = 0;

        public static void CheckExisting(string groupname, string partsname)
        {
            exists = false;
            if (service != null)
            {
                serviceList = new ObservableCollection<Service>(Globals.service.FindAll(service => service.Group == groupname)
                                                                                .FindAll(service => service.PartName == partsname));
                if (serviceList.Count == 0)
                {
                    MessageBox.Show("Es ist noch nichts für die " + partsname + " " + groupname + " angelegt.");
                }
                else
                {
                    service = service.Except(serviceList).ToList();
                    exists = true;
                }
            }
            else
            {
                MessageBox.Show("Es ist noch nichts angelegt.");
            }
        }

    }
}
