﻿#pragma checksum "..\..\..\Control\MenuUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0962C238B1BDE5D135CC54C8EBED41DC09E915287D13425EF405895B30DC43A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using ManagerBook.Control;
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


namespace ManagerBook.Control {
    
    
    /// <summary>
    /// MenuUserControl
    /// </summary>
    public partial class MenuUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Control\MenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDBoard;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Control\MenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCtm;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Control\MenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBookMana;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Control\MenuUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/ManagerBook;component/control/menuusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Control\MenuUserControl.xaml"
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
            this.btnDBoard = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Control\MenuUserControl.xaml"
            this.btnDBoard.Click += new System.Windows.RoutedEventHandler(this.btnDBoard_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCtm = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Control\MenuUserControl.xaml"
            this.btnCtm.Click += new System.Windows.RoutedEventHandler(this.btnCtm_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnBookMana = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Control\MenuUserControl.xaml"
            this.btnBookMana.Click += new System.Windows.RoutedEventHandler(this.btnBookMana_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnOrder = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Control\MenuUserControl.xaml"
            this.btnOrder.Click += new System.Windows.RoutedEventHandler(this.btnOrder_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 46 "..\..\..\Control\MenuUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

