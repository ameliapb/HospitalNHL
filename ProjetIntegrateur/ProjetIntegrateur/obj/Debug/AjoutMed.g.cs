﻿#pragma checksum "..\..\AjoutMed.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059D0660FC48AB07F0694D9F83013E877A348030"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetIntegrateur;
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


namespace ProjetIntegrateur {
    
    
    /// <summary>
    /// AjoutMed
    /// </summary>
    public partial class AjoutMed : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AjoutMed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AjoutMed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AjoutMed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrenom;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AjoutMed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSpecialite;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AjoutMed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjout1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AjoutMed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnnuler1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AjoutMed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetour;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetIntegrateur;component/ajoutmed.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AjoutMed.xaml"
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
            this.groupBox1 = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.txtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtSpecialite = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnAjout1 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AjoutMed.xaml"
            this.btnAjout1.Click += new System.Windows.RoutedEventHandler(this.btnAjout_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAnnuler1 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AjoutMed.xaml"
            this.btnAnnuler1.Click += new System.Windows.RoutedEventHandler(this.btnAnnuler_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnRetour = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AjoutMed.xaml"
            this.btnRetour.Click += new System.Windows.RoutedEventHandler(this.btnRetour_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

