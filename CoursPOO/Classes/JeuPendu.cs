using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class JeuPendu
    {
        public int nbEssai;
        public string masque;
        string motAtrouve;

        GenerateurDeMot generateur;

        public JeuPendu()
        {
            generateur = new GenerateurDeMot();
            nbEssai = 10;
        }

        public void GenererMasque()
        {
            motAtrouve = generateur.Generer();
            masque = "";
            for(int i=0; i < motAtrouve.Length; i++)
            {
                masque += "*";
            }
        }

        public bool TestChar(char c)
        {
            bool found = false;
            string tmpMasque = "";
            for(int i=0; i < motAtrouve.Length; i++)
            {
                if(motAtrouve[i] == c)
                {
                    found = true;
                    tmpMasque += c;
                }
                else
                {
                    tmpMasque += masque[i];
                }
            }

            masque = tmpMasque;
            if (!found)
                nbEssai--;
            return found;
        }

        public bool TestWin()
        {
            return (nbEssai > 0 && motAtrouve == masque);
        }

    }
}
