using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class IHMEntreprise
    {
        private Entreprise entreprise;


        public void Demarrer()
        {
            Console.Write("Le nombre d'employés de l'entreprise : ");
            int t = Convert.ToInt32(Console.ReadLine());
            entreprise = new Entreprise(t);
            Console.Clear();
            string choixMenu;
            do
            {
                Menu();
                choixMenu = Console.ReadLine();
                Console.Clear();
                switch(choixMenu)
                {
                    case "1":
                        AjouterEmploye();
                        break;
                    case "2":
                        AfficherSalaireEmployes();
                        break;
                    case "3":
                        RechercherEmploye();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Erreur menu");
                        break;
                }
            } while (choixMenu != "0");
        }

        private void Menu()
        {
            Console.WriteLine("1---Ajouter un employé");
            Console.WriteLine("2---Afficher les salaires des employés");
            Console.WriteLine("3---Rechercher un employés");
            Console.WriteLine("0---Quitter ");
        }


        private void AjouterEmploye()
        {
            Salarie salarie = null;
            Console.Write("Merci de saisir matricule : ");
            string matricule = Console.ReadLine();
            Console.Write("Merci de saisir le service : ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir le categorie : ");
            string categorie = Console.ReadLine();
            Console.Write("Merci de saisir le nom complet : ");
            string nomComplet= Console.ReadLine();
            Console.Write("Merci de saisir le salaire : ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());
            MenuCreationEmploye();
            string choix = Console.ReadLine();
            if(choix == "1")
            {
                salarie = new Salarie(matricule, categorie, service, nomComplet, salaire);
            } else if(choix == "2")
            {
                Console.Write("Merci de saisir le chiffre d'affaire : ");
                decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Merci de saisir la commission :");
                decimal commission = Convert.ToDecimal(Console.ReadLine());
                salarie = new Commercial(matricule, categorie, service, nomComplet, salaire, chiffreAffaire, commission);
            }
            if (entreprise.AjouterSalarie(salarie))
            {
                Console.WriteLine("Salarie ajouté");
            }
            else
            {
                Console.WriteLine("Erreur d'ajout salarié");
            }
        }

        private void MenuCreationEmploye()
        {
            Console.WriteLine("1---Salarié");
            Console.WriteLine("2---Commercial");
        }
        private void AfficherSalaireEmployes()
        {
            foreach(Salarie s in entreprise.Salaries)
            {
                if(s!= null)
                {
                    s.AfficherSalaire();
                    s.AffichageSpecial();
                }
            }
        }
        private void RechercherEmploye()
        {
            Console.Write("Merci de saisir la recherche : ");
            string search = Console.ReadLine();
            Salarie salarie = entreprise.RechercherSalarie(search);
            if(salarie != null)
            {
                salarie.AfficherSalaire();
                if (salarie is Commercial c)
                {
                    c.AffichageSpecial();                 
                }
                else
                {
                    salarie.AffichageSpecial();
                }
                
            }else
            {
                Console.WriteLine("Aucun salarié ne correspond à la recherche");
            }
        }
    }
}
