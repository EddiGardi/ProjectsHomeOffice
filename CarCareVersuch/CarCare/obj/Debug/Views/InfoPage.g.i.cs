#pragma checksum "..\..\..\Views\InfoPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "794988EF5EC64F32D174072466CEAAC29A50B5D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using CarCare;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CarCare.Views
{


    /// <summary>
    /// InfoPage
    /// </summary>
    public partial class InfoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox group;

#line default
#line hidden


#line 20 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox partname;

#line default
#line hidden


#line 22 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox changein;

#line default
#line hidden


#line 24 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker changelast;

#line default
#line hidden


#line 26 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox odo;

#line default
#line hidden


#line 28 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox infos;

#line default
#line hidden


#line 39 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bearbeiten;

#line default
#line hidden


#line 56 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid loeschen;

#line default
#line hidden


#line 65 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid hinzufuegen;

#line default
#line hidden


#line 78 "..\..\..\Views\InfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_serviceList;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CarCare;component/views/infopage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Views\InfoPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.group = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.partname = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.changein = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.changelast = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 5:
                    this.odo = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.infos = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.bearbeiten = ((System.Windows.Controls.Button)(target));

#line 39 "..\..\..\Views\InfoPage.xaml"
                    this.bearbeiten.Click += new System.Windows.RoutedEventHandler(this.Bearbeiten_Click);

#line default
#line hidden
                    return;
                case 8:

#line 48 "..\..\..\Views\InfoPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Schließen_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.loeschen = ((System.Windows.Controls.Grid)(target));
                    return;
                case 10:

#line 57 "..\..\..\Views\InfoPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Loeschen_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.hinzufuegen = ((System.Windows.Controls.Grid)(target));
                    return;
                case 12:

#line 66 "..\..\..\Views\InfoPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hinzufuegen_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.dg_serviceList = ((System.Windows.Controls.DataGrid)(target));

#line 78 "..\..\..\Views\InfoPage.xaml"
                    this.dg_serviceList.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.Dg_serviceList_SelectedCellsChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

