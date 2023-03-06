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
            if()
        }

        public int nbContacts()
        {

        }

        public double moyenneEtudiantRegulier()
        {

        }

        public void ajouterContact(Contact contact)
        {

        }

        public int nbEtudaints()
        {

        }

        public Boolean existeContact(Contact contact)
        {

        }
    }

}
