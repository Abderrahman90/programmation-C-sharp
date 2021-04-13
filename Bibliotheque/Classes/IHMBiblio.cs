using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class IHMBiblio
    {
        private Biblio biblio;

        public IHMBiblio()
        {
        }
        public void Start()
        {
            Initialisation();
            Console.Clear();
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        ActionAjouterUtilisateur();
                        break;
                    case "2":
                        ActionAjouterOeuvre();
                        break;
                    case "3":
                        ActionAcheterOeuvre();
                        break;
                    case "4":
                        ActionEchangerOeuvres();
                        break;
                }
            } while (choix != "0");
        }
        private void Initialisation()
        {
            Console.Write("Merci de saisir le nombre d'utilisateur max : ");
            int maxUtilisateurs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir le nombre d'oeuvres max : ");
            int maxOeuvres = Convert.ToInt32(Console.ReadLine());
            biblio = new Biblio(maxOeuvres, maxUtilisateurs);
        }


        private void MenuPrincipal()
        {
            Console.WriteLine("1---- Ajouter un utilisateur");
            Console.WriteLine("2---- Ajouter une oeuvre dans la bibliothèque");
            Console.WriteLine("3---- Acheter une oeuvre par un utilisateur");
            Console.WriteLine("4---- Echanger une oeuvre");
        }
        private void MenuTypeOuvrage()
        {
            Console.WriteLine("1---DVD");
            Console.WriteLine("2---BD");
            Console.WriteLine("3---Album");
            Console.WriteLine("0---Quitter");
            Console.WriteLine("\nFaites un choix : ");
        }

        private void ActionAjouterUtilisateur()
        {
            Console.Write("Merci de saisir le nom complet de l'utilisateur : ");
            string nomComplet = Console.ReadLine();
            Console.Write("Merci de saisir le solde : ");
            decimal solde = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nombre d'oeuvres max : ");
            int maxOeuvres = Convert.ToInt32(Console.ReadLine());
            Utilisateur utilisateur = new Utilisateur(nomComplet, solde, maxOeuvres);
            if (biblio.AjouterUtilisateur(utilisateur))
            {
                AfficherMessage($"L'utilisateur a bien été ajouté avec l'id {utilisateur.Id}", ConsoleColor.Green);
            }
            else
            {
                AfficherMessage("Erreur d'ajout utilisateur", ConsoleColor.Red);
            }
        }
        public void ActionAjouterOeuvre()
        {
            int choix;
            Ouvrage ouvrage = null;
            do
            {
                MenuTypeOuvrage();
                choix = Convert.ToInt32(Console.ReadLine());
                if(choix >=1 && choix <= 3)
                {
                    Console.Write("Merci de saisir le titre de l'oeuvre : ");
                    string titre = Console.ReadLine();
                    Console.Write("Merci de saisir l'auteur de l'oeuvre : ");
                    string auteur = Console.ReadLine();
                    Console.Write("Merci de saisir le prix : ");
                    decimal prix = Convert.ToDecimal(Console.ReadLine());
                    switch (choix)
                    {
                        case 1:
                            Console.Write("Merci de saisir la durée du film : ");
                            int duree = Convert.ToInt32(Console.ReadLine());
                            ouvrage = new DVD(titre, auteur, prix, duree);
                            break;
                        case 2:
                            Console.Write("Merci de saisir le nombre de page : ");
                            int nombre = Convert.ToInt32(Console.ReadLine());
                            Console.Write("La BD est-elle couleur ou noir et blanc ? (0 => couleur, 1=> noir et blanc): ");
                            TypeBD type = (TypeBD)Convert.ToInt32(Console.ReadLine());
                            ouvrage = new BD(titre, auteur, prix, nombre, type);
                            break;
                        case 3:
                            Console.Write("Merci de saisir le nombre de page : ");
                            int nombrePage = Convert.ToInt32(Console.ReadLine());
                            ouvrage = new Album(titre, auteur, prix, nombrePage);
                            break;
                    }
                    if(ouvrage != null)
                    {
                        if (biblio.AjouterOuvrage(ouvrage))
                        {
                            AfficherMessage("L'oeuvre a été ajoutée",ConsoleColor.Green);
                            ouvrage = null;
                        }
                        else
                        {
                            AfficherMessage("Erreur d'ajout oeuvre", ConsoleColor.Red);
                        }
                    }
                }
                else
                {
                    AfficherMessage("Merci de choisir une valeur entre 1 et 3", ConsoleColor.Red);
                }
                
                
            } while (choix != 0);
        }
        private void ActionAcheterOeuvre()
        {

        }
        private void ActionEchangerOeuvres()
        {

        }

        private void AfficherMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Une touche pour continuer...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
