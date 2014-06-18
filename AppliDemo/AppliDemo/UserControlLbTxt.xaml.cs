using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace AppliDemo
{
    public partial class UserControlLbTxt : UserControl
    {
        public UserControlLbTxt()
        {
            InitializeComponent();
        }

        //private string _label;
        //public string Label
        //{
        //    get { return _label; }
        //    set
        //    {
        //        _label = value;
        //        label.Text = value;
        //    }
        //}

        //private string _texte;
        //public string Texte
        //{
        //    get { return _texte; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            Visibility = System.Windows.Visibility.Collapsed;
        //        }
        //        else
        //        {
        //            Visibility = System.Windows.Visibility.Visible;
        //            _texte = value;
        //            texte.Text = value;
        //        }

        //    }
        //}

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(UserControlLbTxt), 
                                         new PropertyMetadata("Label", 
                                                               new PropertyChangedCallback(OnLabelChanged)));

        public static void OnLabelChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlLbTxt;
            String value = (string)args.NewValue;

            self.label.Text = value;
        }



        public string Texte
        {
            get { return (string)GetValue(TexteProperty); }
            set { SetValue(TexteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TexteProperty =
            DependencyProperty.Register("Texte", typeof(string), typeof(UserControlLbTxt), 
                                        new PropertyMetadata("Value",
                                                             new PropertyChangedCallback(OnTexteChanged)));

        public static void OnTexteChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlLbTxt;
            String value = (string)args.NewValue;

            if (String.IsNullOrWhiteSpace(value))
            {
                self.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                self.Visibility = System.Windows.Visibility.Visible;
                self.texte.Text = value;
            }
        }        
        
    }
}
