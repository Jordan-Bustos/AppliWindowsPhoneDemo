using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace AppliDemo
{
	public partial class UserControlStars : UserControl
	{
		public UserControlStars()
		{
			// Requis pour initialiser les variables
			InitializeComponent();
		}
		
		private bool _isActive;
		public bool IsActive
		{
			get { return _isActive; }
			set
            {
                _isActive = value;
                if (value)
                    StarRegularPolygon.Fill = Resources["FillBrushActive"] as Brush;
                else
                    StarRegularPolygon.Fill = Resources["FillBrushInactive"] as Brush;
            }
		}
	}
}