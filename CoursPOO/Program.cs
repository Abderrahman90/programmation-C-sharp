using CoursPOO.Classes;
using System;

namespace CoursPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exemple cours POO et TP Chaise
            //Création d'une voiture
            /*Voiture v1 = new Voiture();
            v1.model = "Kia";
            v1.prix = 10000;
            Console.WriteLine($"La voiture v1 est de model {v1.model} et le prix est de {v1.prix}");
            Voiture v2 = new Voiture();
            v2.model = "Ford";
            v2.prix = 250000;
            Console.WriteLine($"La voiture v2 est de model {v2.model} et le prix est de {v2.prix}");*/
            /*Personne p1 = new Personne();
            p1.nom = "toto";
            p1.prenom = "tata";
            p1.age = 30;
            p1.telephone = "0606060606";
            Personne p2 = new Personne();
            p2.nom = "titi";
            p2.prenom = "minet";
            p2.age = 30;
            p2.telephone = "0606060606";
            //tableau de personnes
            Personne[] personnes = new Personne[3];
            personnes[0] = p1;
            personnes[1] = p2;
            foreach(Personne p in personnes)
            {
                if (p != null)
                    //Console.WriteLine($"Nom : {p.nom}, Prénom : {p.prenom}");
                    p.Afficher();
            }
            p2.Marcher();*/

            //Personne p = new Personne();
            //p.nom = "toto";
            /*Personne p = new Personne("toto", "tata", 30, 1.8,70);
            //p.taille = 1.8;
            //p.poids = 70;
            Console.WriteLine(p.CalculeIMC());
            Console.WriteLine(p.RetourMessageAccueil("Hello"));*/
            //Chaise[] chaises = new Chaise[3];
            //for(int i=0;i < chaises.Length;i++)
            //{
            //    Console.Write("Entrez le nombre de pieds : ");
            //    int nb = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Entrez la couleur : ");
            //    string couleur = Console.ReadLine();
            //    Console.Write("Entrez le type du matériel : ");
            //    string mat = Console.ReadLine();
            //    Chaise c = new Chaise(nb, couleur, mat);
            //    chaises[i] = c;
            //}
            //Chaise[] chaises = CreationChaises();
            //foreach (Chaise c in chaises)
            //{
            //    Console.WriteLine($"Je suis une chaise, avec {c.nbPieds} en {c.materiaux} et de couleur {c.couleur}");
            //}
            //Console.WriteLine($"Nombre chaises : {Chaise.compteur}");
            //char[] tab = new char[] { 'c', 't', 't' };
            //string s = new string(tab);
            //Personne.MethodeStatic();
            #endregion

            #region Correction Pendu
            //IHM ihmPendu = new IHM();
            //ihmPendu.Start();
            #endregion

            #region cours Accesseur 
            //Personne p1 = new Personne();
            //p1.Nom = "abadi";
            //Console.WriteLine(p1.Nom);
            //Personne p2 = new Personne();
            //p2.Nom = "sqsds";
            //Salarie s1 = new Salarie("s1", "c1", "se1", "toto", 1500);
            //Salarie s2 = new Salarie("s2", "c2", "se2", "tata", 2500);
            //Salarie s3 = new Salarie("s3", "c3", "se3", "titi", 3000);
            //Salarie[] tabSalaries= new Salarie[3];
            //tabSalaries[0] = s1;
            //tabSalaries[1] = s2;
            //tabSalaries[2] = s3;
            ////s1.AfficherSalaire();
            ////s2.AfficherSalaire();
            ////s3.AfficherSalaire();
            //foreach(Salarie s in tabSalaries)
            //{
            //    s.AfficherSalaire();
            //}
            //Console.WriteLine($"Le salaire total est de {Salarie.TotalSalaire}, et le nombre de salariés est de {Salarie.Compteur}");
            #endregion

            #region correction Annuaire
            //IHMAnnuaire ihm = new IHMAnnuaire();
            //ihm.Demarrer();
            //new IHMAnnuaire().Demarrer();
            #endregion

            #region cours héritage
            /*//Voiture v = new Voiture();
            //v.Model = "Ford";
            //v.NbPorte = 5;
            Voiture v = new Voiture("Ford", 5);
            //v.Afficher();
            Camion c = new Camion();
            c.Model = "Volvo";
            c.ChargeMax = 30;
            c.Afficher();
            Moto m = new Moto();
            m.Cylindre = 2;
            m.Model = "Ducati";
            //v.Afficher();
            //c.Afficher();
            //m.Afficher();
            Vehicule[] vehicules = new Vehicule[3];
            vehicules[0] = v;
            vehicules[1] = m;
            vehicules[2] = c;
            foreach(Vehicule ve in vehicules)
            {
                ve.Afficher();
                //Console.WriteLine(ve.GetType());
                //Convertion en voiture, camion ou moto
                //1ère façon de convertir
                //if(ve.GetType() == typeof(Voiture))
                //{
                //    Voiture vo = ve as Voiture;
                //    Console.WriteLine(vo.NbPorte);
                //}
                //Voiture vo = ve as Voiture;
                //if(vo != null)
                //    Console.WriteLine(vo.NbPorte);

                //2ème façon de convertir (boxing)
                //if(ve.GetType() == typeof(Voiture))
                //{
                //    Voiture vo = (Voiture)ve;
                //    Console.WriteLine(vo.NbPorte);
                //}
                //3ème façon de convertir is
                //if(ve is Voiture vo)
                //{
                //    Console.WriteLine(vo.NbPorte);
                //}
            }*/
            #endregion

            #region Correction héritage salariés
            new IHMEntreprise().Demarrer();
            #endregion

        }


        static Chaise[] CreationChaises()
        {
            Chaise[] chaises = new Chaise[3];
            for (int i = 0; i < chaises.Length; i++)
            {
                Console.Write("Entrez le nombre de pieds : ");
                int nb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Entrez la couleur : ");
                string couleur = Console.ReadLine();
                Console.Write("Entrez le type du matériel : ");
                string mat = Console.ReadLine();
                Chaise c = new Chaise(nb, couleur, mat);               
                chaises[i] = c;
            }
            return chaises;
        }
    }
}
