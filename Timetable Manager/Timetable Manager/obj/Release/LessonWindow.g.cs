﻿#pragma checksum "..\..\LessonWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "576DF505FABA4FCAD88C82611527A83D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Timetable_Manager;


namespace Timetable_Manager {
    
    
    /// <summary>
    /// LessonWindow
    /// </summary>
    public partial class LessonWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\LessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCountDown;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\LessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Start;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\LessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Pause;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\LessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Reset;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\LessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBLessonName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\LessonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_Comments;
        
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
            System.Uri resourceLocater = new System.Uri("/Timetable Manager;component/lessonwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LessonWindow.xaml"
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
            
            #line 8 "..\..\LessonWindow.xaml"
            ((Timetable_Manager.LessonWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBCountDown = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btn_Start = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\LessonWindow.xaml"
            this.btn_Start.Click += new System.Windows.RoutedEventHandler(this.btn_Start_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Pause = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\LessonWindow.xaml"
            this.btn_Pause.Click += new System.Windows.RoutedEventHandler(this.btn_Pause_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Reset = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\LessonWindow.xaml"
            this.btn_Reset.Click += new System.Windows.RoutedEventHandler(this.btn_Reset_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBLessonName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtBox_Comments = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

