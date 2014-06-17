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
    public partial class UserControlNote : UserControl
    {
        private List<UserControlStars> _stars;
        private Double _startPosition;
        
        public UserControlNote()
        {
            InitializeComponent();
            _stars = new List<UserControlStars>();
        }

        private int _nbStars;
        public int NbStars
        {
            get { return _nbStars; }
            set
            {
                _nbStars = value;

                LayoutRoot.Children.Clear();
                LayoutRoot.ColumnDefinitions.Clear();

                for (int i = 0; i < value; i++)
                {
                    LayoutRoot.ColumnDefinitions.Add(new ColumnDefinition()); //créer une nouvelle colonne
                    UserControlStars userControlStars = new UserControlStars(); //créer un nouveau UserControlStar
                    LayoutRoot.Children.Add(userControlStars); //ajouter le UCStar dans la grille
                    userControlStars.SetValue(Grid.ColumnProperty, i);//le mettre dans la bonne colonne (avec SetValue(blablabla))

                    _stars.Add(userControlStars); //stocker le user control dans une collection interne
                }
            }
        }

        public int Note
        {
            get { return (int)GetValue(NoteProperty); }
            set { SetValue(NoteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Note.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NoteProperty =
            DependencyProperty.Register("Note", typeof(int), typeof(UserControlNote), new PropertyMetadata(0
                , new PropertyChangedCallback(OnNoteChanged)));


        public static void OnNoteChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        {
            var self = o as UserControlNote;

            if ((int)args.NewValue > self.NbStars)

                self.Note = self.NbStars;
            else if ((int)args.NewValue < 0)
                self.Note = self.Note - (int)args.NewValue;
            else
                self.Note = (int)args.NewValue;

            if (self.Note < 0)
                self.Note = 0;

            for (int i = 0; i < self.Note; i++)
                self._stars[i].IsActive = true;

            for (int i = self.Note; i < self._stars.Count(); i++)
                self._stars[i].IsActive = false;
        }


        private void LayoutRoot_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            _startPosition = e.ManipulationOrigin.X; // On récupère la position de départ
        }

        private void LayoutRoot_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            e.Handled = true; // bloquer le pivot.

            // Récupérer la position du doigt en relatif par rapport à la grille
            Point positionDoigt = e.CumulativeManipulation.Translation;

            // En déduire la colonne sur laquelle se trouve le doigt
            Double columnPosition = _startPosition + positionDoigt.X;

            // Modifier en conqéquence la propriété Note du User Control  
            Double sizeStar = LayoutRoot.ActualWidth / NbStars; // On récupère la taille d'une étoile
            Note = (int)(columnPosition / sizeStar + 0.5);
        }

        private void LayoutRoot_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
        }
        
    }
}
