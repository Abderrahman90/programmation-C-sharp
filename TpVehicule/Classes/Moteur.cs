using System;
using System.Collections.Generic;
using System.Text;

namespace TpVehicule.Classes
{
    class Moteur
    {
        private double volumeReservoir;
        private double volumeTotal;
        private bool demarre;

        public double VolumeReservoir { get => volumeReservoir; set => volumeReservoir = value; }
        public double VolumeTotal { get => volumeTotal; set => volumeTotal = value; }
        public bool Demarre { get => demarre; set => demarre = value; }

        public bool Demarrer()
        {
            bool result = false;
            if(VolumeReservoir >= 0.1 && !Demarre)
            {
                Console.WriteLine("Je démarre");
                Demarre = true;
                VolumeReservoir -= 0.1;
                result = true;
                //return true;
            }
            //else
            //{
            //    return false;
            //}
            return result;
        }

        public double Utiliser(double volume)
        {
            if(volume <= VolumeReservoir)
            {
                Console.WriteLine($"Le moteur utilise {volume} litres");
                VolumeReservoir -= volume;
            }
            else
            {
                Console.WriteLine($"Le moteur a utilisé {VolumeReservoir} litres, panne essence");
                VolumeReservoir = 0;
                Demarre = false;
            }
            return VolumeReservoir;
        }

        public void FairePlein(double volume)
        {
            VolumeReservoir += volume;
            VolumeTotal += volume;
            Console.WriteLine($"Plein effectué avec {volume}");
        }

        public void Arreter()
        {
            Console.WriteLine("Moteur arrêté");
            Demarre = false;
        }
    }
}
