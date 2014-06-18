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
using AppliDemo.Utils;
using System.Collections.ObjectModel;

namespace AppliDemo
{
    public partial class MainPageDataBinding : PhoneApplicationPage
    {
        public MainPageDataBinding()
        {
            InitializeComponent();

            lgListSelectorLieux.ItemsSource = Lieux.QqsLieux.GroupBy(lieu => lieu.Catégorie)
                                                    .OrderBy(group => group.Key)
                                                    .Select(group => new Group(group));


        }
    }
}