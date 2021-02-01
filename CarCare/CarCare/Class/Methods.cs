using System.Collections.Generic;
using System.Windows;
using System.Collections.ObjectModel;
using System.Reflection;

namespace CarCare.Class
{
    public class Methods
    {

        public static void RightList(string call1, string call2)
        { 
            if (call1 == "Motorraum")
            {
                if (call2 == "Luftfilter")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Motorraum.Luftfilter);
                }
                else if (call2 == "Öl")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Motorraum.Öl);
                }
                else if (call2 == "Steuerkette")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Motorraum.Steuerkette);
                }
                else if (call2 == "Kettenspanner")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Motorraum.Kettenspanner);
                }
                else if (call2 == "Batterie")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Motorraum.Batterie);
                }
                else if (call2 == "Zündkerze")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Motorraum.Zündkerze);
                }
                else if (call2 == "Bremsflüssigkeit")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit);
                };
            }
            else if (call1 == "Vorderrad")
            {
                if (call2 == "Reifen")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Vorderrad.Reifen);
                }
                else if (call2 == "Bremsscheibe")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Vorderrad.Bremsscheibe);
                }
                else if (call2 == "Bremsbelag")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Vorderrad.Bremsbelag);
                };
            }
            else if (call1 == "Hinterrad")
            {
                if (call2 == "Reifen")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Hinterrad.Reifen);
                }
                else if (call2 == "Bremsscheibe")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Hinterrad.Bremsscheibe);
                }
                else if (call2 == "Bremsbelag")
                {
                    Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Hinterrad.Bremsbelag);
                };
            }
            else if (call1 == "Innenraum")
            {
                Class.Globals.serviceList = new ObservableCollection<Class.Part>(Class.Globals.serviceNew.Innenraum.Innenraumfilter);
            }
        }
        
        public static void CheckExisting(string groupname, string partsname)
        {
            Class.Globals.exists = false;
            RightList(groupname, partsname);
            if (Class.Globals.serviceList.Count == 0)
            {
                MessageBox.Show("Es ist noch nichts für die " + partsname + " " + groupname + " angelegt.");
            }
            else
            {
                Class.Globals.exists = true;
            }
        }

        public static void SortedClose (string call1, string call2, List<Class.Part> list)
        {
            if (call1 == "Motorraum")
            {
                if (call2 == "Luftfilter")
                {
                    Class.Globals.serviceNew.Motorraum.Luftfilter.Clear();
                    Class.Globals.serviceNew.Motorraum.Luftfilter.AddRange(list);
                }
                else if (call2 == "Öl")
                {
                    Class.Globals.serviceNew.Motorraum.Öl.Clear();
                    Class.Globals.serviceNew.Motorraum.Öl.AddRange(list);
                }
                else if (call2 == "Steuerkette")
                {
                    Class.Globals.serviceNew.Motorraum.Steuerkette.Clear();
                    Class.Globals.serviceNew.Motorraum.Steuerkette.AddRange(list);
                }
                else if (call2 == "Kettenspanner")
                {
                    Class.Globals.serviceNew.Motorraum.Kettenspanner.Clear();
                    Class.Globals.serviceNew.Motorraum.Kettenspanner.AddRange(list);
                }
                else if (call2 == "Batterie")
                {
                    Class.Globals.serviceNew.Motorraum.Batterie.Clear();
                    Class.Globals.serviceNew.Motorraum.Batterie.AddRange(list);
                }
                else if (call2 == "Zündkerze")
                {
                    Class.Globals.serviceNew.Motorraum.Zündkerze.Clear();
                    Class.Globals.serviceNew.Motorraum.Zündkerze.AddRange(list);
                }
                else if (call2 == "Bremsflüssigkeit")
                {
                    Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit.Clear();
                    Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit.AddRange(list);
                };
            }
            else if (call1 == "Vorderrad")
            {
                if (call2 == "Reifen")
                {
                    Class.Globals.serviceNew.Vorderrad.Reifen.Clear();
                    Class.Globals.serviceNew.Vorderrad.Reifen.AddRange(list);
                }
                else if (call2 == "Bremsscheibe")
                {
                    Class.Globals.serviceNew.Vorderrad.Bremsscheibe.Clear();
                    Class.Globals.serviceNew.Vorderrad.Bremsscheibe.AddRange(list);
                }
                else if (call2 == "Bremsbelag")
                {
                    Class.Globals.serviceNew.Vorderrad.Bremsbelag.Clear();
                    Class.Globals.serviceNew.Vorderrad.Bremsbelag.AddRange(list);
                };
            }
            else if (call1 == "Hinterrad")
            {
                if (call2 == "Reifen")
                {
                    Class.Globals.serviceNew.Hinterrad.Reifen.Clear();
                    Class.Globals.serviceNew.Hinterrad.Reifen.AddRange(list);
                }
                else if (call2 == "Bremsscheibe")
                {
                    Class.Globals.serviceNew.Hinterrad.Bremsscheibe.Clear();
                    Class.Globals.serviceNew.Hinterrad.Bremsscheibe.AddRange(list);
                }
                else if (call2 == "Bremsbelag")
                {
                    Class.Globals.serviceNew.Hinterrad.Bremsbelag.Clear();
                    Class.Globals.serviceNew.Hinterrad.Bremsbelag.AddRange(list);
                };
            }
            else if (call1 == "Innenraum")
            {
                Class.Globals.serviceNew.Innenraum.Innenraumfilter.Clear();
                Class.Globals.serviceNew.Innenraum.Innenraumfilter.AddRange(list);
            }
        }

        public static void FlattenedList (List<Class.ServiceFlattened> list, List<Class.ServiceFlattened> list2)
        {
            foreach (var item in Class.Globals.serviceNew.Motorraum.Luftfilter)
            {
                if (Class.Globals.serviceNew.Motorraum.Luftfilter.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Motorraum", "Luftfilter", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Motorraum", "Luftfilter", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Motorraum.Öl)
            {
                if (Class.Globals.serviceNew.Motorraum.Öl.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Motorraum", "Öl", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Motorraum", "Öl", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Motorraum.Steuerkette)
            {
                if (Class.Globals.serviceNew.Motorraum.Steuerkette.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Motorraum", "Steuerkette", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Motorraum", "Steuerkette", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Motorraum.Kettenspanner)
            {
                if (Class.Globals.serviceNew.Motorraum.Kettenspanner.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Motorraum", "Kettenspanner", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Motorraum", "Kettenspanner", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Motorraum.Batterie)
            {
                if (Class.Globals.serviceNew.Motorraum.Batterie.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Motorraum", "Batterie", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Motorraum", "Batterie", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Motorraum.Zündkerze)
            {
                if (Class.Globals.serviceNew.Motorraum.Zündkerze.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Motorraum", "Zündkerze", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Motorraum", "Zündkerze", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit)
            {
                if (Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Motorraum", "Bremsflüssigkeit", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Motorraum", "Bremsflüssigkeit", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Vorderrad.Reifen)
            {
                if (Class.Globals.serviceNew.Vorderrad.Reifen.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Vorderrad", "Reifen", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Vorderrad", "Reifen", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Vorderrad.Bremsscheibe)
            {
                if (Class.Globals.serviceNew.Vorderrad.Bremsscheibe.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Vorderrad", "Bremsscheibe", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Vorderrad", "Bremsscheibe", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Vorderrad.Bremsbelag)
            {
                if (Class.Globals.serviceNew.Vorderrad.Bremsbelag.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Vorderrad", "Bremsbelag", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Vorderrad", "Bremsbelag", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Hinterrad.Reifen)
            {
                if (Class.Globals.serviceNew.Hinterrad.Reifen.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Hinterrad", "Reifen", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Hinterrad", "Reifen", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Hinterrad.Bremsscheibe)
            {
                if (Class.Globals.serviceNew.Hinterrad.Bremsscheibe.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Hinterrad", "Bremsscheibe", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Hinterrad", "Bremsscheibe", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Hinterrad.Bremsbelag)
            {
                if (Class.Globals.serviceNew.Hinterrad.Bremsbelag.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Hinterrad", "Bremsbelag", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Hinterrad", "Bremsbelag", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
            foreach (var item in Class.Globals.serviceNew.Innenraum.Innenraumfilter)
            {
                if (Class.Globals.serviceNew.Innenraum.Innenraumfilter.Count != 0)
                {
                    if (item.Eintrag == 1)
                    {
                        list.Add(new Class.ServiceFlattened("Innenraum", "Innenraumfilter", item.Zuletzt, item.Kilometerstand, item.Info));
                    }
                    else list2.Add(new Class.ServiceFlattened("Innenraum", "Innenraumfilter", item.Zuletzt, item.Kilometerstand, item.Info));
                }
            }
        }
    }
}