using System.Collections.Generic;
using System.Windows.Controls;

namespace CarCare.Views
{
    /// <summary>
    /// Interaktionslogik für Überblick.xaml
    /// </summary>
    public partial class Überblick : Page
    {
        public Überblick()
        {
            InitializeComponent();

            List<Class.ServiceFlattened> dg_serviceActual = new List<Class.ServiceFlattened>();
            List<Class.ServiceFlattened> dg_serviceOld = new List<Class.ServiceFlattened>();

            Class.Methods.FlattenedList(dg_serviceActual,dg_serviceOld);

            dg_servicesA.ItemsSource = dg_serviceActual;
            dg_servicesO.ItemsSource = dg_serviceOld;
        }
    }
}
