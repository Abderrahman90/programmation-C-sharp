using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Entreprise
    {
        private Salarie[] salaries;

        
        public Entreprise(int t)
        {
            Salaries = new Salarie[t];
        }

        public Salarie[] Salaries { get => salaries; set => salaries = value; }

        public bool AjouterSalarie(Salarie salarie)
        {
            bool success = false;
            for(int i=0; i < Salaries.Length; i++)
            {
                if(Salaries[i] == null)
                {
                    Salaries[i] = salarie;
                    success = true;
                    break;
                }
            }
            return success;
        }

        public Salarie RechercherSalarie(string search)
        {
            Salarie salarie = null;
            foreach(Salarie s in Salaries)
            {
                if(s!= null && (s.Nom.Contains(search) || s.Service.Contains(search)))
                {
                    salarie = s;
                    break;
                }
            }
            return salarie;
        }

        //public bool AjouterCommercial(Commercial commercial)
        //{
        //    bool success = false;
        //    for (int i = 0; i < salaries.Length; i++)
        //    {
        //        if (salaries[i] == null)
        //        {
        //            salaries[i] = commercial;
        //            success = true;
        //            break;
        //        }
        //    }
        //    return success;
        //}
    }
}
