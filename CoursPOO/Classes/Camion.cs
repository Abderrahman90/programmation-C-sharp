using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Camion : Vehicule
    {
        private double chargeMax;

        public double ChargeMax { get => chargeMax; set => chargeMax = value; }

        public override void Afficher()
        {
            Console.WriteLine($"Un camion de model {Model} et de charge  {ChargeMax}");
        }

        //public override void Afficher()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
