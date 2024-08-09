using System;
using TpVehicule.Classes;

namespace TpVehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture r5 = new Voiture("Renault", "r5", 30);
            r5.Demarrer();
            r5.Rouler(25);
            Console.WriteLine($"il reste {r5.MoteurV.VolumeReservoir}");
            r5.FairePlein(20);
            r5.Rouler(10);
            Console.WriteLine($"il reste {r5.MoteurV.VolumeReservoir}");

        }
    }
}
