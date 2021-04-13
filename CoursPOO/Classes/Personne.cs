using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Personne
    {
        string nom;
        string prenom;
        int age;
        string telephone;
        double taille;
        double poids;

        public string Nom
        {
            get => nom; set
            {
                if(value.Length >=1)
                nom = value;
            }
        }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public double Taille { get => taille; set => taille = value; }
        public double Poids { get => poids; set => poids = value; }

        public Personne(string n, string p, int a)
        {
            Nom = n;
            Prenom = p;
            Age = a;
        }
        public Personne()
        {

        }



        public Personne(string n, string p, int a, double t, double po) : this(n, p, a)
        {
            //nom = n;
            //prenom = p;
            //age = a;
            Taille = t;
            Poids = po;
        }


        //public string Nom
        //{
        //    get
        //    {
        //        return nom;
        //    }
        //    set
        //    {
        //        if(value.Length >=3 && value.Length <= 10)
        //            nom = value;
        //    }
        //}

        //public void SetNom(string n)
        //{
        //    nom = n;
        //}
        //public string GetNom()
        //{
        //    return nom;
        //}
        public void Afficher()
        {
            Console.WriteLine($"Nom : {Nom}, Prénom : {Prenom}");
        }
        public void Marcher()
        {
            Console.WriteLine($"La personne {Nom} marche");
        }

        public double CalculeIMC()
        {
            double imc = Poids / (Taille * Taille);
            return imc;
        }

        public string RetourMessageAccueil(string message)
        {
            return $"{message} {Nom}";
        }

        public static void MethodeStatic()
        {
            Console.WriteLine("Je suis une méthode statique de la classe personne ");
        }
    }
}
