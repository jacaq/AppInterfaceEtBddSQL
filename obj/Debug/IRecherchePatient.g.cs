﻿#pragma checksum "..\..\IRecherchePatient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3AE653AE20E957ED1DD9F605166089400729008805B4C77F9A6EA167F0985602"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

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
using tp01_cSharp;


namespace tp01_cSharp {
    
    
    /// <summary>
    /// IRecherchePatient
    /// </summary>
    public partial class IRecherchePatient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\IRecherchePatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid_listePatient;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\IRecherchePatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_nas_patient;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\IRecherchePatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_nas_patient;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\IRecherchePatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_rechercher_patient;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\IRecherchePatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_titre_recherche;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\IRecherchePatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_retour;
        
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
            System.Uri resourceLocater = new System.Uri("/tp01_cSharp;component/irecherchepatient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\IRecherchePatient.xaml"
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
            this.DataGrid_listePatient = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.tb_nas_patient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lb_nas_patient = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btn_rechercher_patient = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\IRecherchePatient.xaml"
            this.btn_rechercher_patient.Click += new System.Windows.RoutedEventHandler(this.btn_rechercher_patient_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lb_titre_recherche = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btn_retour = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\IRecherchePatient.xaml"
            this.btn_retour.Click += new System.Windows.RoutedEventHandler(this.btn_retour_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
