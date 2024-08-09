using System;
using System.Collections.Generic;
using System.Text;

namespace TpVehicule.Classes
{
    abstract class VehiculeAMoteur : Vehicule
    {
        private Moteur moteurV;

        public Moteur MoteurV { get => moteurV; set => moteurV = value; }

        public VehiculeAMoteur(string model, string marque) : base(model, marque)
        {
            MoteurV = new Moteur();
        }

        public override bool Demarrer()
        {
            return MoteurV.Demarrer();
        }

        public override void Arreter()
        {
            MoteurV.Arreter();
        }

        public override void FairePlein(double volume)
        {
            MoteurV.Arreter();
            MoteurV.FairePlein(volume);
            MoteurV.Demarrer();
        }
    }
}
