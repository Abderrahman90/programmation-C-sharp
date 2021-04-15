using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Pile<T>
    {
        private T[] elements;
        private int compteur;

        public Pile(int taille)
        {
            elements = new T[taille];
            compteur = 0;
        }

        public void Empiler(T element)
        {
            if(compteur < elements.Length)
            {
                elements[compteur] = element;
                compteur++;
            }            
        }

        public void Depiler()
        {
            if(compteur > 0)
            {
                elements[compteur - 1] = default(T);
                compteur--;
            }
        }

        public T GetElement(int index)
        {
            if(index >=0 && index < compteur)
            {
                return elements[index];
            }
            else
            {
                return default(T);
            }
        }
    }
}
