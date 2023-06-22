﻿#pragma checksum "..\..\Team.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F3632C6A485E1FB571E5E389031741B6A2DBE06396FE9CD1A0094A89DCD05E75"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using Turnament;


namespace Turnament {
    
    
    /// <summary>
    /// Team
    /// </summary>
    public partial class Team : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 96 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TeamName;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Name;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Shortcut;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock VictoryNumber;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LossesNumber;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LostGoals;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ScoredGoals;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PlayersListView;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\Team.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Turnament;component/team.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Team.xaml"
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
            this.TeamName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Shortcut = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.VictoryNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.LossesNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.LostGoals = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ScoredGoals = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.PlayersListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            
            #line 171 "..\..\Team.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickSelect);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 176 "..\..\Team.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickAddPlayer);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 181 "..\..\Team.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickBack);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 184 "..\..\Team.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.BtnClickExitApp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

