﻿#pragma checksum "..\..\Page1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B20EBEDB57F3652C09D226694F41001BAD7E4C2FC1A9A69021B420AAEC7D83AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AddData;
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


namespace AddData {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ZizkaGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertZiBx;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertMgBx;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateZiBx;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateMgBx;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IdsBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/AddData;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
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
            this.ZizkaGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\Page1.xaml"
            this.ZizkaGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.ZizkaGrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.InsertZiBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.InsertMgBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.InsertBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Page1.xaml"
            this.InsertBtn.Click += new System.Windows.RoutedEventHandler(this.InsertBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpdateZiBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.UpdateMgBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Page1.xaml"
            this.UpdateBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.IdsBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.DelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Page1.xaml"
            this.DelBtn.Click += new System.Windows.RoutedEventHandler(this.DelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
