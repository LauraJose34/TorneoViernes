﻿#pragma checksum "..\..\Menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6DF38F48F00C2B314008A5E2F8F8509A99F7BDCD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using OxyPlot.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Torneo.GUI;


namespace Torneo.GUI {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDeportePuntosEquipos;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker clcFechaPuntosEquipos;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PuntosEquiposBuscador;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PuntosRegresarTabla;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgPuntosEquipos;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPuntosToneroIdentificador;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPuntosToneroEquipo1;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPuntosToneroEquipo2;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPuntosMarcador1;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPuntosMarcador2;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker clcFechaEstadisticos;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEstadisticosEquipos;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalcularEstadisticos;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgTablaEstadisticos;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView Grafica;
        
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
            System.Uri resourceLocater = new System.Uri("/Torneo.GUI;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
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
            this.cmbDeportePuntosEquipos = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.clcFechaPuntosEquipos = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.PuntosEquiposBuscador = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\Menu.xaml"
            this.PuntosEquiposBuscador.Click += new System.Windows.RoutedEventHandler(this.PuntosEquiposBuscador_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PuntosRegresarTabla = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\Menu.xaml"
            this.PuntosRegresarTabla.Click += new System.Windows.RoutedEventHandler(this.PuntosRegresarTabla_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtgPuntosEquipos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 74 "..\..\Menu.xaml"
            this.dtgPuntosEquipos.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dtgPuntosEquipos_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPuntosToneroIdentificador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtPuntosToneroEquipo1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtPuntosToneroEquipo2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtPuntosMarcador1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtPuntosMarcador2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.clcFechaEstadisticos = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 12:
            this.cmbEstadisticosEquipos = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.btnCalcularEstadisticos = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\Menu.xaml"
            this.btnCalcularEstadisticos.Click += new System.Windows.RoutedEventHandler(this.btnCalcularEstadisticos_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.dtgTablaEstadisticos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 15:
            this.Grafica = ((OxyPlot.Wpf.PlotView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

