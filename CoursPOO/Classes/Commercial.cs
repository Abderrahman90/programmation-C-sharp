using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Commercial : Salarie
    {
        private decimal commission;
        private decimal chiffreAffaire;

        public decimal Commission { get => commission; set => commission = value; }
        public decimal ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }

        public Commercial() : base()
        {

        }

        public Commercial(string matricule, string categorie, string service, string nom, decimal salaire, decimal chiffreAffaire, decimal commission) : base(matricule, categorie, service, nom, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }

        public override void AfficherSalaire()
        {
            decimal salaireGlobale = Salaire + (ChiffreAffaire) * Commission/100;
            Console.WriteLine($"Le salaire du commercial {Nom} est de {salaireGlobale} euros");
        }

        public new void  AffichageSpecial()
        {
            Console.WriteLine("Cette méthode fait un affichage special pour commercial");
        }
    }
}
