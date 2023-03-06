using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        private string nom;
        private int anneeCreation;
        private Dictionary<int,Contact> contacts;

        public string Nom { get => nom; set => nom = value; }
        public int AnneeCreation { get => anneeCreation; set => anneeCreation = value; }

        public string afficheTous()
        {
            foreach (Contact contact in contacts.Values)
            {

            }
        }

        public double ancienneteMoyenne()
        {
            int moy = 0;
            foreach (Contact contact in contacts.Values)
            {
                moy += DateTime.Now.Year - contact.AnneeArrivee;
            }
            return moy / contacts.Count;
        }

        public Boolean estEtudiant(Contact contact)
        {
            if (contact is Etudiant)
            {
                return true;
            }
            return false;
        }

        public int nbContacts()
        {
            return this.contacts.Count;
        }

        public double moyenneEtudiantRegulier()
        {
            double moy = 0;
            foreach (Contact contact in contacts.Values)
            {
                if (estEtudiant(contact)&& contact is EtudiantRegulier)
                {
                    moy+=this.contacts.Values.
                }
            }
            return moy / this.nbEtudiants;
        }

        public void ajouterContact(Contact contact)
        {
            this.contacts.Add(contact.Matricule, contact);
        }

        public void ajouterContact(Dictionary<int, Contact> cont)
        {
            contacts = this.contacts.Concat(cont).ToDictionary(x => x.Key, x => x.Value);
        }

        public int nbEtudiants()
        {
            int nb = 0;
            foreach (KeyValuePair<int, Contact> kvp in this.contacts)
            {
                if (estEtudiant(kvp.Value))
                {
                    nb += 1;
                }
            }
            return nb;
        }

        public Boolean existeContact(Contact contact)
        {
            if (contacts.ContainsKey(contact.Matricule))
            {
                return true;
            }
            return false;
        }

        public Boolean existeContact(int matricule)
        {
            if (contacts.ContainsKey(matricule))
            {
                return true;
            }
            return false;
        }
    }

}
