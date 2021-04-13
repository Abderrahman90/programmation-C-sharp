using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    abstract class Vehicule
    {
        private string model;

        public string Model { get => model; set => model = value; }

        public Vehicule()
        {

        }

        public Vehicule(string model)
        {
            Model = model;
        }
        public abstract void Afficher();
    }
}
