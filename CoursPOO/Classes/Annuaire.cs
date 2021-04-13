using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Annuaire
    {
        private Contact[] contacts;
        private int taille;
        //private int position;
        public Contact[] Contacts { get => contacts;}

        public Annuaire(int t)
        {
            taille = t;
            contacts = new Contact[taille];
            //position = 0;
        }

        public bool AjouterContact(Contact contact)
        {
            //if(position < taille - 1)
            //{
            //    contacts[position] = contact;
            //    position++;
            //    return true;
            //}
            bool retour = false;
            for (int i=0; i < contacts.Length; i++)
            {
                if(contacts[i]== null)
                {
                    contacts[i] = contact;
                    retour = true;
                    break;
                }
            }
            return retour;
        }

        public bool SupprimerContact(int contactId)
        {
            bool retour = false;
            for(int i=0; i < contacts.Length; i++)
            {
                if(contacts[i] != null && contacts[i].Id == contactId)
                {
                    contacts[i] = null;
                    retour = true;
                    break;
                }
            }
            return retour;
        }

        public Contact RechercherContact(string telephone)
        {
            Contact contact = null;
            foreach(Contact c in contacts)
            {
                if(c!=null && c.Telephone == telephone)
                {
                    contact = c;
                    break;
                }
            }
            return contact;
        }
    }
}
