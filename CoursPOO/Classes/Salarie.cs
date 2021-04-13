using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Salarie
    {
        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private decimal salaire;
        private static decimal totalSalaire;

        private static int compteur = 0;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }
        public static decimal TotalSalaire { get => totalSalaire; }

        public static int Compteur { get => compteur; }

        public Salarie()
        {
            compteur++;
        }

        public Salarie(string matricule, string categorie, string service, string nom, decimal salaire) : this()
        {
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Nom = nom;
            Salaire = salaire;
            totalSalaire += salaire;
            //compteur++;
        }

        public virtual void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }
        public virtual void AffichageSpecial()
        {
            Console.WriteLine("Cette méthode fait un affichage special pour salarié");
        }
    }
}
