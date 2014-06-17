using System;
using System.Net;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LieuNamespace
{
    /// <summary>
    /// quelques lieux
    /// </summary>
    public static class Lieux
    {
        public static ReadOnlyCollection<Lieu> QqsLieux = new ReadOnlyCollection<Lieu>(new Lieu[]
            {
                new Lieu()
                {
                    Nom = "IUT d'Informatique",
                    Catégorie = Lieu.LieuType.Education,
                    Description = "Meilleur IUT d'Informatique du monde",
                    Note = 5,
                    Contact = new Contact{ 
                        Personne="Abdel Hasbani", Courriel = @"mailto:abdel.hasbani@udamail.fr", Téléphone = @"+33 (0)4 73 17 71 00", 
                        Url = @"http://iutweb.u-clermont1.fr/recherche-par-diplome.html?pole=info&amp;resultat=true"
                    },
                    Photos = new List<string>(new string[]{"IUT.png"}),
                    GeoCoordinates = new Lieu.GeoCoordinatesStruct{Latitude=45.7623,Longitude=3.1092}
                },
                new Lieu()
                {
                    Nom = "Puy de Dôme",
                    Catégorie = Lieu.LieuType.Nature,
                    Description = "Dôme de reinette et Dôme d'api",
                    Note = 5,
                    Contact = new Contact{ 
                        Url = @"http://fr.wikipedia.org/wiki/Puy_de_D%C3%B4me"
                    },
                    Photos = new List<string>(new string[]{@"Puy_de_Dôme.jpg", @"Puy_de_dôme_depuis_le_puy_de_côme.jpg", @"Puy_de_dome_Temple_mercure_2.jpg"}),
                    GeoCoordinates = new Lieu.GeoCoordinatesStruct{Latitude=45.7725,Longitude=2.964}
                },
                new Lieu()
                {
                    Nom = "Jardin Lecoq",
                    Catégorie = Lieu.LieuType.Nature,
                    Description = "pour avoir les genoux tout vert",
                    Note = 4,
                    Contact = new Contact{ 
                        Url = @"http://www.clermont-ferrand.fr/-Jardin-Lecoq-.html"
                    },
                    Photos = new List<string>(new string[]{@"jardin_lecoq.jpg", @"jardin_lecoq2.jpg", @"jardin_lecoq3.jpg", @"jardin_lecoq4.jpg"}),
                    GeoCoordinates = new Lieu.GeoCoordinatesStruct{Latitude=45.772627,Longitude=3.088381}
                },
                new Lieu()
                {
                    Nom = "Musée Lecoq",
                    Catégorie = Lieu.LieuType.Culture,
                    Description = "Muséum d'Histoire Naturelle de Clermont-Ferrand",
                    Note = 4,
                    Contact = new Contact{ 
                        Personne = "Mickaël Lebras",
                        Url = @"http://www.clermont-ferrand.fr/-Museum-Henri-Lecoq-.html",
                        Téléphone = "+33 (0)4 73 42 32 00"
                    },
                    Photos = new List<string>(new string[]{@"musee_lecoq.jpg", @"musee_lecoq2.jpg", @"musee_lecoq3.jpg", @"musee_lecoq4.jpg", @"musee_lecoq5.jpg"}),
                    GeoCoordinates = new Lieu.GeoCoordinatesStruct{Latitude=45.774146,Longitude=3.088413}
                },
                new Lieu()
                {
                    Nom = "Château de Murol",
                    Catégorie = Lieu.LieuType.Histoire,
                    Description = "Le plus grand château d'Auvergne, près du Lac Chambon",
                    Note = 5,
                    Contact = new Contact{ 
                        Url = @"http://www.chateaudemurol.fr/",
                        Téléphone = "+33 (0)4 73 260 200 "
                    },
                    Photos = new List<string>(new string[]{@"murol.jpg", @"murol2.jpg", @"murol3.jpg", @"murol4.jpg", @"murol5.jpg", @"murol6.jpg"}),
                    GeoCoordinates = new Lieu.GeoCoordinatesStruct{Latitude=45.57828,Longitude=2.94575}
                },
            });
    }
}
