﻿#pragma checksum "..\..\..\ReserveView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "004B0AD9389934154368EEEF487B1AD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
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


namespace EpgTimer {
    
    
    /// <summary>
    /// ReserveView
    /// </summary>
    public partial class ReserveView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 54 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView_reserve;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView gridView_reserve;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanel_button;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_del;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_change;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_no;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_add_manual;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\ReserveView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_timeShiftPlay;
        
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
            System.Uri resourceLocater = new System.Uri("/EpgTimer;component/reserveview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ReserveView.xaml"
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
            
            #line 7 "..\..\..\ReserveView.xaml"
            ((EpgTimer.ReserveView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\ReserveView.xaml"
            ((EpgTimer.ReserveView)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.UserControl_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 15 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 16 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 17 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 18 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 19 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 20 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 21 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 22 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.headerSelect_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 24 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.ContextMenu)(target)).Loaded += new System.Windows.RoutedEventHandler(this.cmdMenu_Loaded);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 25 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.button_del_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 27 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.button_change_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 29 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.recmode_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 30 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.recmode_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 31 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.recmode_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 32 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.recmode_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 33 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.recmode_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 34 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.button_no_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 37 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.priority_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 38 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.priority_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 39 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.priority_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 40 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.priority_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 41 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.priority_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 44 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_ProgramTable);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 45 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.autoadd_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 46 "..\..\..\ReserveView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.timeShiftPlay_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.listView_reserve = ((System.Windows.Controls.ListView)(target));
            
            #line 54 "..\..\..\ReserveView.xaml"
            this.listView_reserve.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.GridViewColumnHeader_Click));
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\ReserveView.xaml"
            this.listView_reserve.ContextMenuOpening += new System.Windows.Controls.ContextMenuEventHandler(this.ContextMenu_Header_ContextMenuOpening);
            
            #line default
            #line hidden
            return;
            case 31:
            this.gridView_reserve = ((System.Windows.Controls.GridView)(target));
            return;
            case 32:
            this.stackPanel_button = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 33:
            this.button_del = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\ReserveView.xaml"
            this.button_del.Click += new System.Windows.RoutedEventHandler(this.button_del_Click);
            
            #line default
            #line hidden
            return;
            case 34:
            this.button_change = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\..\ReserveView.xaml"
            this.button_change.Click += new System.Windows.RoutedEventHandler(this.button_change_Click);
            
            #line default
            #line hidden
            return;
            case 35:
            this.button_no = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\ReserveView.xaml"
            this.button_no.Click += new System.Windows.RoutedEventHandler(this.button_no_Click);
            
            #line default
            #line hidden
            return;
            case 36:
            this.button_add_manual = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\ReserveView.xaml"
            this.button_add_manual.Click += new System.Windows.RoutedEventHandler(this.button_add_manual_Click);
            
            #line default
            #line hidden
            return;
            case 37:
            this.button_timeShiftPlay = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\..\ReserveView.xaml"
            this.button_timeShiftPlay.Click += new System.Windows.RoutedEventHandler(this.timeShiftPlay_Click);
            
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
            case 30:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 63 "..\..\..\ReserveView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.listView_reserve_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.KeyDownEvent;
            
            #line 64 "..\..\..\ReserveView.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyEventHandler(this.listView_reserve_KeyDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

