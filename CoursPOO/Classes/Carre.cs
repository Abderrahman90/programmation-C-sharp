using CoursPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Carre : Figure, IDeformable
    {
        private double longueur;

        public double Longueur { get => longueur; set => longueur = value; }

        public Carre(double posX, double posY, double longueur) :base(posX, posY)
        {
            Longueur = longueur;
        }
        public override void Afficher()
        {
            Console.WriteLine($"Je suis un carré de longueur {Longueur}");
        }

        public Figure Deformation(double coeffH, double coeffV)
        {
            if(coeffH == coeffV)
            {
                return new Carre(PosX, PosY, Longueur * coeffV);
            }
            else
            {
                return new Rectangle(PosX, PosY, Longueur * coeffH, Longueur * coeffV);
            }
        }
    }
}
