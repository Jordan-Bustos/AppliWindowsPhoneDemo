﻿#pragma checksum "U:\licencePM\P3\WindowsPhone\Project\AppliDemo\AppliDemo\UserControlNote.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "00434B331187F614EA8A92439FC851B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18063
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AppliDemo {
    
    
    public partial class UserControlNote : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl userControlNote;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppliDemo;component/UserControlNote.xaml", System.UriKind.Relative));
            this.userControlNote = ((System.Windows.Controls.UserControl)(this.FindName("userControlNote")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
        }
    }
}
