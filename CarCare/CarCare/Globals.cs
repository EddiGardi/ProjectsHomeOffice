using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace CarCare
{
    public static class Globals
    {
        public static int i = 0;
        public static bool vorhanden = false;
        public static string uebergabe = "";
        public static List<Service> service = JsonConvert.DeserializeObject<List<Service>>(File.ReadAllText(@"C:\Users\Edgard Frank\source\repos\CarCare\Datenbank\Service.json"));
        public static Service tempService = new Service("", "", DateTime.Parse("01/01/2000"), 0, "");

        public static void CheckExisting(string groupname, string partsname)
        {
            i = 0;
            vorhanden = false;
            if (service != null)
            {
                while (i < service.Count && service[i].Group != groupname && service[i].PartName != partsname)
                {
                    i++;
                }
                if (i == service.Count)
                {
                    MessageBox.Show("Es ist noch nichts für die " + partsname + " " + groupname + " angelegt.");
                }
                else
                {
                    vorhanden = true;
                }
            }
            else
            {
                MessageBox.Show("Es ist noch nichts angelegt.");
            }
        }

    }
}
