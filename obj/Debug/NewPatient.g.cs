﻿#pragma checksum "..\..\NewPatient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F01C6A720E4B4FE3CE50FF572AF3C432872BEE068EDC3C805475AAFC26B6DDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekat;
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


namespace Projekat {
    
    
    /// <summary>
    /// NewPatient
    /// </summary>
    public partial class NewPatient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\NewPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patient_Id;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\NewPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patient_First_Name;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\NewPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patient_Last_Name;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\NewPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patient_JMBG;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\NewPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patient_Phone_Number;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\NewPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patient_Username;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\NewPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patient_Password;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekat;component/newpatient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewPatient.xaml"
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
            this.Patient_Id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Patient_First_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Patient_Last_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Patient_JMBG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Patient_Phone_Number = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Patient_Username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Patient_Password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 36 "..\..\NewPatient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

