using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Chaise
    {
        public int nbPieds;
        public string couleur;
        public string materiaux;

        public static int compteur = 0;

        public Chaise()
        {

        }

        public Chaise(int nbPieds, string couleur, string materiaux)
        {
            this.nbPieds = nbPieds;
            this.couleur = couleur;
            this.materiaux = materiaux;
            compteur++;
        }

        public static Chaise[] LireChaisesApartirFichier()
        {
            //Construire les chaises à partir d'un fichier
            return null;
        }
    }
}
