﻿#pragma checksum "..\..\..\FunctionUI\ViewPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0571E51F122ED5CC4337494F20E6A7462118CA8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WordBook.FunctionUI;
using WordBook.UserContrl;


namespace WordBook.FunctionUI {
    
    
    /// <summary>
    /// ViewPage
    /// </summary>
    public partial class ViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 113 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ViewMain;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAllShow;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEng;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChn;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRstore;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid WordView;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WordBook.UserContrl.DataGridPage DGpage;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gload;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WordBook.UserContrl.LoadingTask _loading;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCrrBlk;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\..\FunctionUI\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtErrBlk;
        
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
            System.Uri resourceLocater = new System.Uri("/WordBook;component/functionui/viewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FunctionUI\ViewPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.ViewMain = ((System.Windows.Controls.Grid)(target));
            
            #line 113 "..\..\..\FunctionUI\ViewPage.xaml"
            this.ViewMain.KeyDown += new System.Windows.Input.KeyEventHandler(this.ViewMain_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAllShow = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\..\FunctionUI\ViewPage.xaml"
            this.btnAllShow.Click += new System.Windows.RoutedEventHandler(this.btnAllShow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnEng = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\FunctionUI\ViewPage.xaml"
            this.btnEng.Click += new System.Windows.RoutedEventHandler(this.btnEng_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnChn = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\FunctionUI\ViewPage.xaml"
            this.btnChn.Click += new System.Windows.RoutedEventHandler(this.btnChn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRstore = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\..\FunctionUI\ViewPage.xaml"
            this.btnRstore.Click += new System.Windows.RoutedEventHandler(this.btnRstore_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WordView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 157 "..\..\..\FunctionUI\ViewPage.xaml"
            this.WordView.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.WordView_CellEditEnding);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DGpage = ((WordBook.UserContrl.DataGridPage)(target));
            return;
            case 8:
            this.Gload = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this._loading = ((WordBook.UserContrl.LoadingTask)(target));
            return;
            case 10:
            this.txtCrrBlk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.txtErrBlk = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
