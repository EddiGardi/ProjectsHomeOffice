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
    public class Methods
    {
        public static void NewEntry (int call1, int call2, int number, DateTime insertDate, int insertOdo )
        {
            if (call1 == 0)
            {
                if (call2 == 0)
                {
                    var test = new Class.Service(call1)
                    {
                        Motorraum =
                        {
                            new Class.Motorraum(call2)
                            {
                                Luftfilter =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 1)
                {
                    var test = new Class.Service(call1)
                    {
                        Motorraum =
                        {
                            new Class.Motorraum(call2)
                            {
                                Öl =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 2)
                {
                    var test = new Class.Service(call1)
                    {
                        Motorraum =
                        {
                            new Class.Motorraum(call2)
                            {
                                Steuerkette =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 3)
                {
                    var test = new Class.Service(call1)
                    {
                        Motorraum =
                        {
                            new Class.Motorraum(call2)
                            {
                                Kettenspanner =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 4)
                {
                    var test = new Class.Service(call1)
                    {
                        Motorraum =
                        {
                            new Class.Motorraum(call2)
                            {
                                Batterie =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 5)
                {
                    var test = new Class.Service(call1)
                    {
                        Motorraum =
                        {
                            new Class.Motorraum(call2)
                            {
                                Zündkerze =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 6)
                {
                    var test = new Class.Service(call1)
                    {
                        Motorraum =
                        {
                            new Class.Motorraum(call2)
                            {
                                Bremsflüssigkeit =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                };
            }
            else if (call1 == 1)
            {
                if (call2 == 0)
                {
                    var test = new Class.Service(call1)
                    {
                        Vorderrad =
                        {
                            new Class.Vorderrad(call2)
                            {
                                Reifen =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 1)
                {
                    var test = new Class.Service(call1)
                    {
                        Vorderrad =
                        {
                            new Class.Vorderrad(call2)
                            {
                                Bremsscheibe =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                }
                else if (call2 == 2)
                {
                    var test = new Class.Service(call1)
                    {
                        Vorderrad =
                        {
                            new Class.Vorderrad(call2)
                            {
                                Bremsbelag =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                    };
                };
            }
            else if (call1 == 2)
            {
                    if (call2 == 0)
                    {
                        var test = new Class.Service(call1)
                        {
                            Hinterrad =
                        {
                            new Class.Hinterrad(call2)
                            {
                                Reifen =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                        };
                    }
                    else if (call2 == 1)
                    {
                        var test = new Class.Service(call1)
                        {
                            Hinterrad =
                        {
                            new Class.Hinterrad(call2)
                            {
                                Bremsscheibe =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                        };
                    }
                    else if (call2 == 2)
                    {
                        var test = new Class.Service(call1)
                        {
                            Hinterrad =
                        {
                            new Class.Hinterrad(call2)
                            {
                                Bremsbelag =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                        };
                    };
                }
            else if (call1 == 3)
            {
                var test = new Class.Service(call1)
                {
                    Innenraum =
                        {
                            new Class.Innenraum()
                            {
                                Innenraumfilter =
                                { new Class.Part
                                {
                                    Eintrag = number,
                                    Frist = insertDate.AddYears(2),
                                    Zuletzt = insertDate,
                                    Kilometerstand = insertOdo
                                }
                                }
                            }
                        }
                };
            }
        }
    }
}