﻿#pragma checksum "..\..\..\..\EpgView\EpgMainView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E47E32918F1A06D21931CCC6211286AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using EpgTimer.EpgView;
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
    /// EpgMainView
    /// </summary>
    public partial class EpgMainView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\EpgView\EpgMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EpgTimer.EpgView.DateView dateView;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\EpgView\EpgMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_PG;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\EpgView\EpgMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_now;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\EpgView\EpgMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EpgTimer.EpgView.TimeView timeView;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\EpgView\EpgMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EpgTimer.EpgView.ServiceView serviceView;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\EpgView\EpgMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EpgTimer.EpgView.ProgramView epgProgramView;
        
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
            System.Uri resourceLocater = new System.Uri("/EpgTimer;component/epgview/epgmainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\EpgView\EpgMainView.xaml"
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
            
            #line 8 "..\..\..\..\EpgView\EpgMainView.xaml"
            ((EpgTimer.EpgMainView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\EpgView\EpgMainView.xaml"
            ((EpgTimer.EpgMainView)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.UserControl_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dateView = ((EpgTimer.EpgView.DateView)(target));
            return;
            case 3:
            this.grid_PG = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.button_now = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\EpgView\EpgMainView.xaml"
            this.button_now.Click += new System.Windows.RoutedEventHandler(this.button_now_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.timeView = ((EpgTimer.EpgView.TimeView)(target));
            return;
            case 6:
            this.serviceView = ((EpgTimer.EpgView.ServiceView)(target));
            return;
            case 7:
            this.epgProgramView = ((EpgTimer.EpgView.ProgramView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

