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
    public partial class UserControlContact : UserControl
    {
        public UserControlContact()
        {
            InitializeComponent();
        }

        //private string _personne;
        //public string Personne
        //{
        //    get { return _personne; }
        //    set
        //    {
        //        _personne = value;
        //        FieldPersonne.Label = "Personne : ";
        //        FieldPersonne.Texte = value;
        //    }
        //}

        //private string _email;
        //public string Email
        //{
        //    get { return _email; }
        //    set
        //    {

        //        _email = value;
        //        FieldEMail.TypeLink = "EMail : ";
        //        FieldEMail.NameLink = value;
        //        FieldEMail.NavigateUriAdress = String.Format("mailto:{0}", value);
        //    }
        //}

        //private string _siteWeb;
        //public string SiteWeb
        //{
        //    get { return _siteWeb; }
        //    set
        //    {
        //        _siteWeb = value;
        //        FieldWebSite.TypeLink = "Site Web : ";
        //        FieldWebSite.NameLink = "Click here";
        //        FieldWebSite.NavigateUriAdress = value;
        //    }
        //}

        
        public string Personne
        {
            get { return (string)GetValue(PersonneProperty); }
            set { SetValue(PersonneProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Personne.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonneProperty =
            DependencyProperty.Register("Personne", typeof(string), typeof(UserControlContact),
            new PropertyMetadata("", new PropertyChangedCallback(OnPersonneChanged)));

        public static void OnPersonneChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlContact;
            String value = (string)args.NewValue;

            self.FieldPersonne.Label = "Personne : ";
            self.FieldPersonne.Texte = value;
        }

        

        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Email.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string), typeof(UserControlContact), new PropertyMetadata("", 
                new PropertyChangedCallback(OnEmailChanged)));

        public static void OnEmailChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlContact;
            String value = (string)args.NewValue;

            self.FieldEMail.TypeLink = "EMail : ";
            self.FieldEMail.NameLink = value;
            self.FieldEMail.NavigateUriAdress = String.Format("mailto:{0}", value);
        }




        public string SiteWeb
        {
            get { return (string)GetValue(SiteWebProperty); }
            set { SetValue(SiteWebProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SiteWeb.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SiteWebProperty =
            DependencyProperty.Register("SiteWeb", typeof(string), typeof(UserControlContact), new PropertyMetadata(""
                , new PropertyChangedCallback(OnSiteWebChanged)));

        public static void OnSiteWebChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlContact;
            String value = (string)args.NewValue;

            self.FieldWebSite.TypeLink = "Site Web : ";
            self.FieldWebSite.NameLink = "Click here";
            self.FieldWebSite.NavigateUriAdress = value;
        }        
        
    }
}
