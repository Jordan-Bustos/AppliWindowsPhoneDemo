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

        private string _personne;
        public string Personne
        {
            get { return _personne; }
            set
            {
                _personne = value;
                FieldPersonne.Label = "Personne : ";
                FieldPersonne.Texte = value;
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {

                _email = value;
                FieldEMail.TypeLink = "EMail : ";
                FieldEMail.NameLink = value;
                FieldEMail.NavigateUriAdress = String.Format("mailto:{0}", value);
            }
        }

        private string _siteWeb;
        public string SiteWeb
        {
            get { return _siteWeb; }
            set
            {
                _siteWeb = value;
                FieldWebSite.TypeLink = "Site Web : ";
                FieldWebSite.NameLink = "Click here";
                FieldWebSite.NavigateUriAdress = value;
            }
        }
    }
}
