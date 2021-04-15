using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class Annuaire
    {
        //private Contact[] contacts;
        private List<Contact> contacts;
        //private int taille;
        //private int position;
        //public Contact[] Contacts { get => contacts;}
        public List<Contact> Contacts { get => contacts; }
        public Annuaire()
        {
            //taille = t;
            //contacts = new Contact[taille];
            contacts = new List<Contact>();
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
            bool retour = true;
            //for (int i=0; i < contacts.Length; i++)
            //{
            //    if(contacts[i]== null)
            //    {
            //        contacts[i] = contact;
            //        retour = true;
            //        break;
            //    }
            //}
            Contacts.Add(contact);
            return retour;
        }

        public bool SupprimerContact(int contactId)
        {
            //bool retour = false;
            ////for(int i=0; i < contacts.Length; i++)
            ////{
            ////    if(contacts[i] != null && contacts[i].Id == contactId)
            ////    {
            ////        contacts[i] = null;
            ////        retour = true;
            ////        break;
            ////    }
            ////}
            ////Contact contact = null;
            ////foreach(Contact c in contacts)
            ////{
            ////    if(c.Id == contactId)
            ////    {
            ////        retour = true;
            ////        contact = c;
            ////        break;
            ////    }
            ////}
            ////contacts.Remove(contact);

            ////Exemple d'utilisation d'expression lambda

            //return retour;

            return Contacts.RemoveAll(c => c.Id == contactId) > 0;
        }

        public Contact RechercherContact(string telephone)
        {
            //Contact contact = null;
            //foreach(Contact c in contacts)
            //{
            //    if(c!=null && c.Telephone == telephone)
            //    {
            //        contact = c;
            //        break;
            //    }
            //}
            //return contact;
            //exemple avec expression lambda
            return contacts.Find(c => c.Telephone == telephone);
        }
    }
}
