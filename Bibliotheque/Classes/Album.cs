using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.Classes
{
    class Album : Livre
    {
        private bool[] pageColoriee;

        public Album(string titre, string auteur, decimal prix, int nombrePage) : base(titre, auteur, prix, nombrePage)
        {
            pageColoriee = new bool[nombrePage];
        }

        public bool[] PageColoriee { get => pageColoriee; set => pageColoriee = value; }

        public bool Colorier(int numeroPage)
        {
            bool result = false;
            if(!PageColoriee[numeroPage-1])
            {
                PageColoriee[numeroPage] = true;
                result = true;
            }
            return result;
        }
    }
}
