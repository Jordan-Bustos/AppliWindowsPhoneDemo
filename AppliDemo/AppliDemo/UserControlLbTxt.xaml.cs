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

        private string _label;
        public string Label
        {
            get { return _label; }
            set
            {
                _label = value;
                label.Text = value;
            }
        }

        private string _texte;
        public string Texte
        {
            get { return _texte; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Visibility = System.Windows.Visibility.Collapsed;
                }
                else
                {
                    Visibility = System.Windows.Visibility.Visible;
                    _texte = value;
                    texte.Text = value;
                }

            }
        }
    }
}
