﻿#pragma checksum "..\..\ZobaczZlecenia.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "32EE8BF58ED3464CCC3039346180AE12"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using System.Windows.Forms;
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
using WarsztatSamochodowy;


namespace WarsztatSamochodowy {
    
    
    /// <summary>
    /// ZobaczZlecenia
    /// </summary>
    public partial class ZobaczZlecenia : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 12 "..\..\ZobaczZlecenia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOrders;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ZobaczZlecenia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn cbStatus;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ZobaczZlecenia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn cbWorkers;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\ZobaczZlecenia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\ZobaczZlecenia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnParagon;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\ZobaczZlecenia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
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
            System.Uri resourceLocater = new System.Uri("/WarsztatSamochodowy;component/zobaczzlecenia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ZobaczZlecenia.xaml"
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
            this.dgOrders = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.cbStatus = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 4:
            this.cbWorkers = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 6:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\ZobaczZlecenia.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnParagon = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\ZobaczZlecenia.xaml"
            this.btnParagon.Click += new System.Windows.RoutedEventHandler(this.btnParagon_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\ZobaczZlecenia.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
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
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 3:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.Selector.SelectionChangedEvent;
            
            #line 28 "..\..\ZobaczZlecenia.xaml"
            eventSetter.Handler = new System.Windows.Controls.SelectionChangedEventHandler(this.StatusSelectionChanged);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 5:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.Selector.SelectionChangedEvent;
            
            #line 45 "..\..\ZobaczZlecenia.xaml"
            eventSetter.Handler = new System.Windows.Controls.SelectionChangedEventHandler(this.WorkerSelectionChanged);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}
