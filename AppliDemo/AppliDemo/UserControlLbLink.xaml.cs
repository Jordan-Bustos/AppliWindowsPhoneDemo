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
    public partial class UserControlLbLink : UserControl
    {
        public UserControlLbLink()
        {
            InitializeComponent();
        }

        //private string _typeLink;
        //public string TypeLink
        //{
        //    get { return _typeLink; }
        //    set
        //    {
        //        _typeLink = value;
        //        typeLink.Text = value;
        //    }
        //}

        //private string _nameLink;
        //public string NameLink
        //{
        //    get { return _nameLink; }
        //    set
        //    {
        //        _nameLink = value;
        //        link.Content = value;
        //    }
        //}

        //private string _navigateUriAdress;
        //public string NavigateUriAdress
        //{
        //    get { return _navigateUriAdress; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            Visibility = System.Windows.Visibility.Collapsed;
        //        }
        //        else
        //        {
        //            Visibility = System.Windows.Visibility.Visible;
        //            _navigateUriAdress = value;
        //            link.NavigateUri = new System.Uri(value, UriKind.Absolute);
        //        }
        //    }
        //}



        public string TypeLink
        {
            get { return (string)GetValue(TypeLinkProperty); }
            set { SetValue(TypeLinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TypeLink.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TypeLinkProperty =
            DependencyProperty.Register("TypeLink", typeof(string), typeof(UserControlLbLink), new PropertyMetadata("",
                    new PropertyChangedCallback(OnTypeLinkChanged)));

        public static void OnTypeLinkChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlLbLink;
            String value = (string)args.NewValue;

            self.typeLink.Text = value;
        }



        public string NameLink
        {
            get { return (string)GetValue(NameLinkProperty); }
            set { SetValue(NameLinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NameLink.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameLinkProperty =
            DependencyProperty.Register("NameLink", typeof(string), typeof(UserControlLbLink), new PropertyMetadata(""
                ,new PropertyChangedCallback(OnNameLinkChanged)));

        public static void OnNameLinkChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlLbLink;
            String value = (string)args.NewValue;

            self.link.Content = value;
        }




        public string NavigateUriAdress
        {
            get { return (string)GetValue(NavigateUriAdressProperty); }
            set { SetValue(NavigateUriAdressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NavigateUriAdress.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NavigateUriAdressProperty =
            DependencyProperty.Register("NavigateUriAdress", typeof(string), typeof(UserControlLbLink), new PropertyMetadata(""
                ,new PropertyChangedCallback(OnNavigateUriAdressChanged)));

        public static void OnNavigateUriAdressChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlLbLink;
            String value = (string)args.NewValue;

            if (String.IsNullOrWhiteSpace(value))
            {
                self.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                self.Visibility = System.Windows.Visibility.Visible;
                self.link.NavigateUri = new System.Uri(value, UriKind.Absolute);
            }
        }
        

    }
}
