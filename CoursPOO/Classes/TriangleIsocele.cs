using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class TriangleIsocele : Figure
    {
        private double baseTriangle;
        private double hauteurTriangle;

        public double BaseTriangle { get => baseTriangle; set => baseTriangle = value; }
        public double HauteurTriangle { get => hauteurTriangle; set => hauteurTriangle = value; }

        public TriangleIsocele(double posX, double posY, double baseTriangle, double hauteurTriangle) : base(posX, posY)
        {
            BaseTriangle = baseTriangle;
            HauteurTriangle = hauteurTriangle;
        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis un triangle isocèle avec une base de {BaseTriangle} et de hauteur {HauteurTriangle}");
        }
    }
}
