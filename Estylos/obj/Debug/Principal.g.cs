﻿#pragma checksum "..\..\Principal.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6D4ED42E3538D7187FD830856A7F288E2B8167C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Estylos;
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


namespace Estylos {
    
    
    /// <summary>
    /// Principal
    /// </summary>
    public partial class Principal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 572 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Salir;
        
        #line default
        #line hidden
        
        
        #line 573 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button estiloApp;
        
        #line default
        #line hidden
        
        
        #line 574 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button estiloExterno;
        
        #line default
        #line hidden
        
        
        #line 575 "..\..\Principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button materialD;
        
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
            System.Uri resourceLocater = new System.Uri("/Estylos;component/principal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Principal.xaml"
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
            this.Salir = ((System.Windows.Controls.Button)(target));
            
            #line 572 "..\..\Principal.xaml"
            this.Salir.Click += new System.Windows.RoutedEventHandler(this.Salir_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.estiloApp = ((System.Windows.Controls.Button)(target));
            
            #line 573 "..\..\Principal.xaml"
            this.estiloApp.Click += new System.Windows.RoutedEventHandler(this.EstiloApp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.estiloExterno = ((System.Windows.Controls.Button)(target));
            
            #line 574 "..\..\Principal.xaml"
            this.estiloExterno.Click += new System.Windows.RoutedEventHandler(this.EstiloExterno_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.materialD = ((System.Windows.Controls.Button)(target));
            
            #line 575 "..\..\Principal.xaml"
            this.materialD.Click += new System.Windows.RoutedEventHandler(this.MaterialD_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

