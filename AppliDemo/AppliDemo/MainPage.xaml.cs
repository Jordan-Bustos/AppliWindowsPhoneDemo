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
using Microsoft.Phone.Controls;

using LieuNamespace;

namespace AppliDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Lieu _lieu = new Lieu();

        // Constructeur
        public MainPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (NavigationContext.QueryString.Count > 0)
            {
                try
                {
                    String nomLieu = NavigationContext.QueryString["Lieu"];
                    //recup le lieu
                    Lieu lieu = Lieux.QqsLieux.First(l => l.Nom.Equals(nomLieu));

                    //le mettre en data context
                    DataContext = lieu;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error recup : {0}",ex.Message));
                }
            }
        }
    }
}