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

        public bool AcheterOeuvre(Ouvrage oeuvre)
        {
            bool result = false;
            if(Solde >= oeuvre.Prix)
            {
                for(int i=0; i < Oeuvres.Length;i++)
                {
                    if(Oeuvres[i]==null)
                    {
                        Oeuvres[i] = oeuvre;
                        Solde -= oeuvre.Prix;
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public void Echange(Ouvrage o1, Ouvrage o2)
        {
            for(int i=0; i< Oeuvres.Length;i++)
            {
                if(Oeuvres[i]==o1)
                {
                    Oeuvres[i] = o2;
                    break;
                }
            }
        }

        public Ouvrage Rercherche(string titre)
        {
            Ouvrage ouvrage = null;
            foreach(Ouvrage o in Oeuvres)
            {
                if(o.Titre == titre)
                {
                    ouvrage = o;
                }
            }
            return ouvrage;
        }
    }
}
