﻿#pragma checksum "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71679967507E7EAA02F3A91784165405F982B0EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Slats.ViewModels;
using Slats.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using VALET.UserControls;


namespace Slats.Views {
    
    
    /// <summary>
    /// FlipNotes
    /// </summary>
    public partial class FlipNotes : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUndo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRedo;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ForegroundColor;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnBold;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnItalic;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnUnderline;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontFamily;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontSize;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox FlipPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Slats;component/views/tools/flipnotes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnUndo = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.btnUndo.Click += new System.Windows.RoutedEventHandler(this.btnUndo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRedo = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.btnRedo.Click += new System.Windows.RoutedEventHandler(this.btnRedo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ForegroundColor = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.ForegroundColor.Click += new System.Windows.RoutedEventHandler(this.ForegroundColor_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBold = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 57 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.btnBold.Click += new System.Windows.RoutedEventHandler(this.btnBold_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnItalic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 64 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.btnItalic.Click += new System.Windows.RoutedEventHandler(this.btnItalic_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnUnderline = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 71 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.btnUnderline.Click += new System.Windows.RoutedEventHandler(this.btnUnderline_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbFontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 78 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.cmbFontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbFontFamily_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmbFontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 82 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.cmbFontSize.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.cmbFontSize_TextChanged));
            
            #line default
            #line hidden
            return;
            case 9:
            this.FlipPage = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 97 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.FlipPage.AddHandler(System.Windows.Documents.Hyperlink.ClickEvent, new System.Windows.RoutedEventHandler(this.FlipPage_Click));
            
            #line default
            #line hidden
            
            #line 98 "..\..\..\..\..\..\Views\Tools\FlipNotes.xaml"
            this.FlipPage.SelectionChanged += new System.Windows.RoutedEventHandler(this.FlipPage_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

