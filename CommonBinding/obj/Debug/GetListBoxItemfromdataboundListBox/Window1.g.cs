#pragma checksum "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0D7DCF8663103D0ACA40B13049E13D8720DAC02ECC26C4EAB7CB369E9814636E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CommonBinding.GetListBoxItemfromdataboundListBox;
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


namespace CommonBinding.GetListBoxItemfromdataboundListBox {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxGods;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showItem;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showItemFromIndex;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showItemWithCurrentItem_Click;
        
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
            System.Uri resourceLocater = new System.Uri("/CommonBinding;component/getlistboxitemfromdataboundlistbox/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
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
            this.listBoxGods = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.showItem = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
            this.showItem.Click += new System.Windows.RoutedEventHandler(this.showItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.showItemFromIndex = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
            this.showItemFromIndex.Click += new System.Windows.RoutedEventHandler(this.showItemFromIndex_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.showItemWithCurrentItem_Click = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\GetListBoxItemfromdataboundListBox\Window1.xaml"
            this.showItemWithCurrentItem_Click.Click += new System.Windows.RoutedEventHandler(this.showItemWithCurrentItem_Click_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

