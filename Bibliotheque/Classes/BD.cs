using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    sealed class BD : Livre
    {
        private TypeBD type;

        public BD(string titre, string auteur, decimal prix,int nombrePage,TypeBD type) : base(titre, auteur, prix, nombrePage)
        {
            Type = type;
        }

        public TypeBD Type { get => type; set => type = value; }
    }

    enum TypeBD
    {
        Coulour,
        NoirEtBlanc
    }
}
