using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class Livre : Ouvrage
    {
        private int nbPages;

        public int NbPages { get => nbPages; set => nbPages = value; }

        public Livre(string titre, string auteur, decimal prix,int nbPages) : base(titre, auteur, prix)
        {
            NbPages = nbPages;
        }
    }
}
