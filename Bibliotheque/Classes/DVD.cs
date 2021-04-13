using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class DVD : Ouvrage
    {
        private int duree;
        public int Duree { get => duree; set => duree = value; }
        public DVD(string titre, string auteur, decimal prix, int duree) : base(titre, auteur, prix)
        {
            Duree = duree;
        }
    }
}
