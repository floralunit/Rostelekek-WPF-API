﻿#pragma checksum "..\..\..\Windows\EquipWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FFDF2F0DF91D97E084C327238E5F1513DC170F86ED4F40CEA0C8A1E3444D5430"
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
    /// EquipWindow
    /// </summary>
    public partial class EquipWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Windows\EquipWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\EquipWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPrice;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows\EquipWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNotes;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\EquipWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCreate;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\EquipWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEdit;
        
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
            System.Uri resourceLocater = new System.Uri("/Rostelekek-WPF-API;component/windows/equipwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EquipWindow.xaml"
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
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBNotes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BCreate = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Windows\EquipWindow.xaml"
            this.BCreate.Click += new System.Windows.RoutedEventHandler(this.AcceptCreate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BEdit = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Windows\EquipWindow.xaml"
            this.BEdit.Click += new System.Windows.RoutedEventHandler(this.AcceptEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 60 "..\..\..\Windows\EquipWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

