﻿#pragma checksum "..\..\Vocabulary.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "86C723B81E8035E00A1D46CE7C0962E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace VocabularyTest {
    
    
    /// <summary>
    /// Vocabulary
    /// </summary>
    public partial class Vocabulary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\Vocabulary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbFinEng;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Vocabulary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbEngFin;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Vocabulary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShow;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Vocabulary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lsbWords;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Vocabulary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/VocabularyTest;component/vocabulary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Vocabulary.xaml"
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
            this.rdbFinEng = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.rdbEngFin = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.btnShow = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\Vocabulary.xaml"
            this.btnShow.Click += new System.Windows.RoutedEventHandler(this.btnShow_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lsbWords = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Vocabulary.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
