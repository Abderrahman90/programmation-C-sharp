using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class IHMAnnuaire
    {
        private Annuaire annuaire;


        public void Demarrer()
        {
            //Console.Write("Merci de saisir la taille de l'annuaire : ");
            //int t = Convert.ToInt32(Console.ReadLine());
            annuaire = new Annuaire();
            string choixMenu;
            do
            {
                Menu();
                choixMenu = Console.ReadLine();
                Console.Clear();
                switch(choixMenu)
                {
                    case "1":
                        AjouterContact();
                        break;
                    case "2":
                        SupprimerContact();
                        break;
                    case "3":
                        RechercherContact();
                        break;
                    case "4":
                        ModifierContact();
                        break;                    
                    case "0":
                        break;
                    default:
                        break;
                }
            } while (choixMenu != "0");
        }
        private void Menu()
        {
            Console.WriteLine("1---Ajouter contact");
            Console.WriteLine("2---Supprimer contact");
            Console.WriteLine("3---Rechercher contact");
            Console.WriteLine("4---Modifier contact");
            Console.WriteLine("0---Quitter");
        }

        private void AjouterContact()
        {
            Console.Write("Merci de saisir le nom du contact : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le prénom du contact : ");
            string prenom = Console.ReadLine();
            Console.Write("Merci de saisir le téléphone du contact : ");
            string telephone = Console.ReadLine();
            Contact contact = new Contact(nom, prenom, telephone);
            if(annuaire.AjouterContact(contact))
            {
                Console.WriteLine("Votre contact a bien été ajouté");
            }
            else
            {
                Console.WriteLine("Erreur d'ajout contact");
            }
        }
        private void SupprimerContact()
        {
            Contact contact = RechercherContact();
            if(contact != null)
            {
                if (annuaire.SupprimerContact(contact.Id))
                {
                    Console.WriteLine("Contact supprimé");
                }
                else
                {
                    Console.WriteLine("Erreur de suppression");
                }
            }
        }
        private Contact RechercherContact()
        {
            Console.Write("Merci de saisir le téléphone du contact : ");
            string search = Console.ReadLine();
            Contact contact = annuaire.RechercherContact(search);
            if(contact == null)
            {
                Console.WriteLine("Aucun contact avec ce numéro");
            }
            else
            {
                Console.WriteLine($"Nom : {contact.Nom}, Prénom : {contact.Prenom}, Téléphone : {contact.Telephone}");
            }
            return contact;
        }

        private void ModifierContact()
        {
            Contact contact = RechercherContact();
            if(contact != null)
            {
                Console.Write("Merci de saisir le nouveau nom : ");
                contact.Nom = Console.ReadLine();
                Console.Write("Merci de saisir le nouveau prénom : ");
                contact.Prenom = Console.ReadLine();
                Console.Write("Merci de saisir le nouveau téléphone : ");
                contact.Telephone = Console.ReadLine();
                Console.WriteLine("Contact modifié");
            }
        }
    }
}
