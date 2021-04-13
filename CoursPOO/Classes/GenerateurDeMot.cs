using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class GenerateurDeMot
    {
        string[] tableauMots = new string[] { "google", "microsoft", "apple", "amazon" };

        public string Generer()
        {
            Random r = new Random();
            int index = r.Next(tableauMots.Length);
            string mot = tableauMots[index];
            return mot;
        }
    }
}
