﻿#pragma checksum "..\..\..\UserContrl\DataGridPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968EE6A655E4EBC933C934B044797264CD80D94A"
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


namespace WordBook.UserContrl {
    
    
    /// <summary>
    /// DataGridPage
    /// </summary>
    public partial class DataGridPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 87 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbkRecords;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFirst;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrev;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLast;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pageGo;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\UserContrl\DataGridPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGo;
        
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
            System.Uri resourceLocater = new System.Uri("/WordBook;component/usercontrl/datagridpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserContrl\DataGridPage.xaml"
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
            this.tbkRecords = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnFirst = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnFirst.Click += new System.Windows.RoutedEventHandler(this.btnFirst_Click_1);
            
            #line default
            #line hidden
            
            #line 103 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnFirst.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnFirst_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnPrev = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnPrev.Click += new System.Windows.RoutedEventHandler(this.btnPrev_Click_1);
            
            #line default
            #line hidden
            
            #line 107 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnPrev.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnPrev_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click_1);
            
            #line default
            #line hidden
            
            #line 118 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnNext.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnNext_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnLast = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnLast.Click += new System.Windows.RoutedEventHandler(this.btnLast_Click_1);
            
            #line default
            #line hidden
            
            #line 122 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnLast.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnLast_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pageGo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnGo = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\UserContrl\DataGridPage.xaml"
            this.btnGo.Click += new System.Windows.RoutedEventHandler(this.btnGo_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

