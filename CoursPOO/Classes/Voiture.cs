using CoursPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Voiture : Vehicule, IAffichable
    {
        //Attributs
        private int nbPorte;

        public int NbPorte { get => nbPorte; set => nbPorte = value; }

        public Voiture()
        {

        }

        public Voiture(string model, int nbPorte) : base(model)
        {
           //Model = model;
            NbPorte = nbPorte;
        }

        public override void Afficher()
        {
            Console.WriteLine($"Voiture de model {Model}, avec {NbPorte} portes");
        }

        //public override bool Equals(object obj)
        //{
        //    if(Model == (obj as Voiture).Model)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
