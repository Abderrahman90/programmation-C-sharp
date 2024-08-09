using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Moto : Vehicule
    {
        private double cylindre;

        public double Cylindre { get => cylindre; set => cylindre = value; }

        public override void Afficher()
        {
            throw new NotImplementedException();
        }
    }
}
