﻿#pragma checksum "..\..\..\..\GUI\UserControl_TabContent\UserControl_TabWelcome.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B60955167CE587F1AFC247CAA3E6233"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Lagerverwaltung_Bauhaus;
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


namespace Lagerverwaltung_Bauhaus {
    
    
    /// <summary>
    /// UserControl_TabWelcome
    /// </summary>
    public partial class UserControl_TabWelcome : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\GUI\UserControl_TabContent\UserControl_TabWelcome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Welcome_Grid;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\GUI\UserControl_TabContent\UserControl_TabWelcome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image GUI_LagerVerwaltungBauhaus_component_Pictures_Bauhaus_Wilkommen_jpg;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\GUI\UserControl_TabContent\UserControl_TabWelcome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DB_Kill;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lagerverwaltung_Bauhaus;component/gui/usercontrol_tabcontent/usercontrol_tabwelc" +
                    "ome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\UserControl_TabContent\UserControl_TabWelcome.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Welcome_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.GUI_LagerVerwaltungBauhaus_component_Pictures_Bauhaus_Wilkommen_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.DB_Kill = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\GUI\UserControl_TabContent\UserControl_TabWelcome.xaml"
            this.DB_Kill.Click += new System.Windows.RoutedEventHandler(this.DB_Kill_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

