﻿#pragma checksum "..\..\..\Windows\ActAddWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F52251F759B078D1DF8BE35554ED68376154E7D85E4B8116049F3E9F66E7F053"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Rostelekek_WPF_API.Windows;
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


namespace Rostelekek_WPF_API.Windows {
    
    
    /// <summary>
    /// ActAddWindow
    /// </summary>
    public partial class ActAddWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Windows\ActAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBOrder;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\ActAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBStreet;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\ActAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBHome;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Windows\ActAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBFlat;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\ActAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBDate;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\ActAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBWorker;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\ActAddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCreate;
        
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
            System.Uri resourceLocater = new System.Uri("/Rostelekek-WPF-API;component/windows/actaddwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ActAddWindow.xaml"
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
            
            #line 13 "..\..\..\Windows\ActAddWindow.xaml"
            ((Rostelekek_WPF_API.Windows.ActAddWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ActAddWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBOrder = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBStreet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBHome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBFlat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TBDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CBWorker = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.BCreate = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Windows\ActAddWindow.xaml"
            this.BCreate.Click += new System.Windows.RoutedEventHandler(this.AcceptCreate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 69 "..\..\..\Windows\ActAddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
