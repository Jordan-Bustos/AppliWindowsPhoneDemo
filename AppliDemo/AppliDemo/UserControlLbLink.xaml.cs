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

        private string _typeLink;
        public string TypeLink
        {
            get { return _typeLink; }
            set
            {
                _typeLink = value;
                typeLink.Text = value;
            }
        }

        private string _nameLink;
        public string NameLink
        {
            get { return _nameLink; }
            set
            {
                _nameLink = value;
                link.Content = value;
            }
        }

        private string _navigateUriAdress;
        public string NavigateUriAdress
        {
            get { return _navigateUriAdress; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Visibility = System.Windows.Visibility.Collapsed;
                }
                else
                {
                    Visibility = System.Windows.Visibility.Visible;
                    _navigateUriAdress = value;
                    link.NavigateUri = new System.Uri(value, UriKind.Absolute);
                }
            }
        }
    }
}
