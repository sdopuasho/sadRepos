﻿#pragma checksum "..\..\OperationHistoryPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B0E9376D8F5D079A0E3A727485869D0F945233931B05CEF3F8E4C5CB895527E"
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
    /// OperationHistoryPage
    /// </summary>
    public partial class OperationHistoryPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\OperationHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridConsumable;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\OperationHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FIOCmb;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\OperationHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnWorker;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\OperationHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountigConsumable;component/operationhistorypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OperationHistoryPage.xaml"
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
            case 2:
            this.FIOCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\OperationHistoryPage.xaml"
            this.FIOCmb.DropDownClosed += new System.EventHandler(this.FIOCmb_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnWorker = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\OperationHistoryPage.xaml"
            this.BtnWorker.Click += new System.Windows.RoutedEventHandler(this.BtnWorker_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnHistory = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\OperationHistoryPage.xaml"
            this.BtnHistory.Click += new System.Windows.RoutedEventHandler(this.BtnHistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
