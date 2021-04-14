using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Maison<T>
    {
        private  T[] elements;

        public Maison(int taille)
        {
            elements = new T[taille];
        }

        public void Ajouter(T element)
        {
            for(int i=0; i< elements.Length; i++)
            {
                if(elements[i].Equals(default(T)))
                {
                    elements[i] = element;
                    break;
                }
            }
        }
    }
}
