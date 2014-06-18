using System;
using System.Net;

namespace LieuNamespace
{
    /// <summary>
    /// contient des informations relatives au contact d'un lieu
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// personne à contacter
        /// </summary>
        public string Personne
        {
            get;
            set;
        }

        /// <summary>
        /// numéro de téléphone de contact
        /// </summary>
        public string Téléphone
        {
            get;
            set;
        }

        /// <summary>
        /// lien vers une page web d'informations
        /// </summary>
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// adresse mail du contact
        /// </summary>
        public string Courriel
        {
            get;
            set;
        }
    }
}
