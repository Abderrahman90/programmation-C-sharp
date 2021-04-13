using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Contact
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private static int compteur = 0;
        public int Id { get => id;}
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public Contact()
        {
            id = ++compteur;
        }

        public Contact(string nom, string prenom, string telephone) : this()
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;           
        }
    }
}
