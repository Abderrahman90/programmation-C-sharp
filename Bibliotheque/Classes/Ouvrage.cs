using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class Ouvrage
    {
        private string titre;
        private string auteur;
        private decimal prix;

        public string Titre { get => titre; set => titre = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public decimal Prix { get => prix; set => prix = value; }

        public Ouvrage(string titre, string auteur, decimal prix)
        {
            Titre = titre;
            Auteur = auteur;
            Prix = prix;
        }
    }
}
