using System;
using System.Net;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.ComponentModel;

namespace LieuNamespace
{
    /// <summary>
    /// classe de stockage pour les informations sur un lieu
    /// </summary>
    public class Lieu : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// nom de ce lieu
        /// </summary>
        public string Nom
        {
            get
            {
                return mNom;
            }
            set
            {
                mNom = value;
                //OnPropertyChanged("Nom");
            }
        }
        private string mNom;

        /// <summary>
        /// note sur ce lieu
        /// </summary>
        public int Note
        {
            get;
            set;
        }

        /// <summary>
        /// brève description sur ce lieu
        /// </summary>
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
                //OnPropertyChanged("Description");
            }
        }
        private string mDescription;

        /// <summary>
        /// les coordonnées GPS 
        /// </summary>
        public struct GeoCoordinatesStruct
        {
            public double Longitude
            {
                get;
                set;
            }

            public double Latitude
            {
                get;
                set;
            }
        }

        /// <summary>
        /// coordonnées GPS de ce lieu
        /// </summary>
        public GeoCoordinatesStruct GeoCoordinates
        {
            get;
            set;
        }

        /// <summary>
        /// contact pour ce lieu
        /// </summary>
        public Contact Contact
        {
            get;
            set;
        }

        /// <summary>
        /// collection de photos sur ce lieu
        /// </summary>
        public List<string> Photos
        {
            get
            {
                return mPhotos;
            }
            set
            {
                mPhotos = value;
            }
        }
        List<string> mPhotos = new List<string>();

        public string UnePhoto
        {
            get
            {
                if (mPhotos.Count == 0)
                {
                    return "";
                }
                Random rdm = new Random();
                return mPhotos[rdm.Next(mPhotos.Count)];
            }
        }

        /// <summary>
        /// les différents types de lieux
        /// </summary>
        public enum LieuType
        {
            Inconnu,
            Education,
            Nature,
            Histoire,
            Culture
        }

        /// <summary>
        /// type de ce lieu
        /// </summary>
        public LieuType Catégorie
        {
            get;
            set;
        }

    }
}
