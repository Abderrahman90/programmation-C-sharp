using CoursPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Rectangle : Figure, IDeformable
    {
        private double largeur;
        private double hauteur;

        public double Largeur { get => largeur; set => largeur = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }

        public Rectangle(double posX, double posY, double largeur, double hauteur):base(posX, posY)
        {
            Largeur = largeur;
            Hauteur = hauteur;
        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis un rectangle de largeur {Largeur} et de hauteur {Hauteur}");
        }

        public Figure Deformation(double coeffH, double coeffV)
        {
            if(Largeur * coeffH == Hauteur * coeffV)
            {
                return new Carre(PosX, PosY, Largeur * coeffH);
            }
            else
            {
                return new Rectangle(PosX, PosY, Largeur * coeffH, Hauteur * coeffV);
            }
        }
    }
}
