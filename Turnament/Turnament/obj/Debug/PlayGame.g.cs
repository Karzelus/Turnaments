﻿#pragma checksum "..\..\PlayGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A62D89BDFC6EDEA3A9790DFAE0158381DA4B7DA5A7F780CBCB1731FB64DE179A"
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
    /// PlayGame
    /// </summary>
    public partial class PlayGame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 98 "..\..\PlayGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FirstTeamName;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\PlayGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SecondTeamName;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\PlayGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TeamGoals1;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\PlayGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TeamGoals2;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\PlayGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Team1Players;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\PlayGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Team2Players;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\PlayGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Referees;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\PlayGame.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Turnament;component/playgame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlayGame.xaml"
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
            this.FirstTeamName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.SecondTeamName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TeamGoals1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TeamGoals2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Team1Players = ((System.Windows.Controls.ListView)(target));
            
            #line 119 "..\..\PlayGame.xaml"
            this.Team1Players.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.InformationListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Team2Players = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.Referees = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 194 "..\..\PlayGame.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickTeam2Score);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 199 "..\..\PlayGame.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickTeam1Score);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 204 "..\..\PlayGame.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickDontSave);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 208 "..\..\PlayGame.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickSave);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 212 "..\..\PlayGame.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.BtnClickExitApp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

