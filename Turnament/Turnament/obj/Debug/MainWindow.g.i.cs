﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8ED7883F08ED00DD8CF40CD4DB5CA49C3F29E2CFAF963E20881F5CEC6BEDCCDA"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 137 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BracketBtn;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RankingBtn;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TeamsBtn;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HistoryBtn;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform basketball;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform football;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform volleyball;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform tennis;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform rugby;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\MainWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Turnament;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.BracketBtn = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\MainWindow.xaml"
            this.BracketBtn.Click += new System.Windows.RoutedEventHandler(this.BtnClickBracket);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RankingBtn = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\MainWindow.xaml"
            this.RankingBtn.Click += new System.Windows.RoutedEventHandler(this.BtnClickRanking);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TeamsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\MainWindow.xaml"
            this.TeamsBtn.Click += new System.Windows.RoutedEventHandler(this.BtnClickTeams);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HistoryBtn = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\MainWindow.xaml"
            this.HistoryBtn.Click += new System.Windows.RoutedEventHandler(this.BtnClickHistory);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 152 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickExitTournament);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 7:
            this.basketball = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 8:
            this.football = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 9:
            this.volleyball = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 10:
            this.tennis = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 11:
            this.rugby = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 12:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 215 "..\..\MainWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.BtnClickExitApp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

