using System;
using System.Collections.Generic;
using System.Text;

namespace TpVehicule.Classes
{
    abstract class Vehicule
    {
        private string marque;
        private string model;

        public string Marque { get => marque; set => marque = value; }
        public string Model { get => model; set => model = value; }

        protected Vehicule(string marque, string model)
        {
            Marque = marque;
            Model = model;
        }

        public abstract bool Demarrer();
        public abstract void Arreter();
        public abstract void FairePlein(double volume);
    }
}
