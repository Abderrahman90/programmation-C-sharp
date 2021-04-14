using System;
using System.Collections.Generic;
using System.Text;

namespace TpVehicule.Classes
{
    class Voiture : VehiculeAMoteur
    {
        public Voiture(string model, string marque, double volumeInitial) : base(model, marque)
        {
            MoteurV.VolumeReservoir = volumeInitial;
            MoteurV.VolumeTotal = volumeInitial;
        }

        public void Rouler(double volume)
        {
            bool roulerOk = true;
            if(!MoteurV.Demarre)
            {
                if(!Demarrer())
                {
                    roulerOk = false;
                }
            }
            if(roulerOk)
            {
                MoteurV.Utiliser(volume);
            }
        }
    }
}
