﻿#pragma checksum "..\..\ConsumPageAbout.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8045239B05E55A9B3C3CAAD636930C7A4AA36BDE61BFBBBA6B8A98CD67FBE8E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AccountigConsumable;
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


namespace AccountigConsumable {
    
    
    /// <summary>
    /// ConsumPageAbout
    /// </summary>
    public partial class ConsumPageAbout : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridConsumable;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnConsumable;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAbout;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnIssue;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTxt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ManufacturerCmb;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDel;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ConsumPageAbout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCall;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountigConsumable;component/consumpageabout.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ConsumPageAbout.xaml"
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
            this.DGridConsumable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BtnConsumable = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\ConsumPageAbout.xaml"
            this.BtnConsumable.Click += new System.Windows.RoutedEventHandler(this.BtnConsumable_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAbout = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\ConsumPageAbout.xaml"
            this.BtnAbout.Click += new System.Windows.RoutedEventHandler(this.BtnIssue_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnIssue = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\ConsumPageAbout.xaml"
            this.BtnIssue.Click += new System.Windows.RoutedEventHandler(this.BtnIssue_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NameTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\ConsumPageAbout.xaml"
            this.NameTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ManufacturerCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 49 "..\..\ConsumPageAbout.xaml"
            this.ManufacturerCmb.DropDownClosed += new System.EventHandler(this.Manufacturer_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\ConsumPageAbout.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnDel = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\ConsumPageAbout.xaml"
            this.BtnDel.Click += new System.Windows.RoutedEventHandler(this.BtnDel_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnCall = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\ConsumPageAbout.xaml"
            this.btnCall.Click += new System.Windows.RoutedEventHandler(this.btnCall_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 32 "..\..\ConsumPageAbout.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
