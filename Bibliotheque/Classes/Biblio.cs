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

        public Ouvrage RechercheOeuvre(string titre)
        {
            Ouvrage ouvrage = null;
            foreach (Ouvrage o in Oeuvres)
            {
                if (o.Titre == titre)
                {
                    ouvrage = o;
                }
            }
            return ouvrage;
        }

        public Utilisateur RechercheUtilisateur(int id)
        {
            Utilisateur utilisateur = null;
            foreach(Utilisateur u in Utilisateurs)
            {
                if(u.Id == id)
                {
                    utilisateur = u;
                    break;
                }
            }
            return utilisateur;
        }

        public bool Acheter(Utilisateur utilisateur, Ouvrage oeuvre)
        {
            bool result = false;
            if(utilisateur.AcheterOeuvre(oeuvre))
            {
                for(int i=0; i < Oeuvres.Length;i++)
                {
                    if(Oeuvres[i] == oeuvre)
                    {
                        Oeuvres[i] = null;
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public bool Echanger(Utilisateur utilisateur1, Utilisateur utilisateur2, Ouvrage o1, Ouvrage o2)
        {
            bool result = false;
            if(EchangePossible(o1, o2))
            {
                utilisateur1.Echange(o1, o2);
                utilisateur2.Echange(o2, o1);
                result = true;
            }
            return result;
        }
        public bool EchangePossible(Ouvrage o1, Ouvrage o2)
        {
            bool result = false;
            if (o1 is BD bd1 && o2 is BD bd2)
            {
                if (bd1.Prix == bd2.Prix)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool AjouterUtilisateur(Utilisateur utilisateur)
        {
            bool success = false;
            for (int i = 0; i < Utilisateurs.Length; i++)
            {
                if (Utilisateurs[i] == null)
                {
                    Utilisateurs[i] = utilisateur;
                    success = true;
                    break;
                }
            }
            return success;
        }
        public bool AjouterOuvrage(Ouvrage ouvrage)
        {
            bool success = false;
            for (int i = 0; i < Oeuvres.Length; i++)
            {
                if (Oeuvres[i] == null)
                {
                    Oeuvres[i] = ouvrage;
                    success = true;
                    break;
                }
            }
            return success;
        }
    }
}
