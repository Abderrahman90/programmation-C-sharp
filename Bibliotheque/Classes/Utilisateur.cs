using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class Utilisateur
    {
        private string nomComplet;
        private decimal solde;
        private int id;
        private Ouvrage[] oeuvres;

        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public int Id { get => id; }
        public Ouvrage[] Oeuvres { get => oeuvres; set => oeuvres = value; }

        private static int compteur = 0;
        public Utilisateur(string nomComplet, decimal solde, int maxOeuvres)
        {
            id = ++compteur;
            NomComplet = nomComplet;
            Solde = solde;
            Oeuvres = new Ouvrage[maxOeuvres];
        }
    }
}
