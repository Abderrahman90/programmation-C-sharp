using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class Biblio
    {
        private Utilisateur[] utilisateurs;
        private Ouvrage[] oeuvres;

        public Utilisateur[] Utilisateurs { get => utilisateurs; set => utilisateurs = value; }
        public Ouvrage[] Oeuvres { get => oeuvres; set => oeuvres = value; }

        public Biblio(int maxOeuvres, int maxUtilisateurs)
        {
            Utilisateurs = new Utilisateur[maxUtilisateurs];
            Oeuvres = new Ouvrage[maxOeuvres];
        }
    }
}
