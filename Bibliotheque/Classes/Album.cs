using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class Album : Livre
    {
        private int[] pageColoriee;

        public Album(string titre, string auteur, decimal prix, int nombrePage) : base(titre, auteur, prix, nombrePage)
        {
            pageColoriee = new int[nombrePage];
        }

        public int[] PageColoriee { get => pageColoriee; set => pageColoriee = value; }
    }
}
