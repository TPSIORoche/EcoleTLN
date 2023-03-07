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
        public Dictionary<int, Contact> Contacts { get => contacts; set => contacts = value; }

        public Ecole(string nom, int anneeCreation)
        {
            Nom = nom;
            AnneeCreation = anneeCreation;
            Contacts = new Dictionary<int, Contact>();
        }

        public string afficheTous()
        {
            string renvoi = $"Parmi les {this.nbContacts()} de l'école {this.Nom}, {this.nbEtudiants()} sont des étudiants\nIls sont à l'école depuis en moyenne {this.ancienneteMoyenne()} ans\n----  Affichage Tous  -----\n";
            foreach (Contact contact in contacts.Values)
            {
                renvoi += $"{contact.ToString()}\n";
            }
            renvoi += $"Moyenne des étudiants réguliers={this.moyenneEtudiantRegulier()}\n";
            renvoi += $"----  Ajout d'un contact -----\n----  Ajout d'une collection de contacts -----\n----  Vérifications -----\n";
            EtudiantRegulier Dembele = new EtudiantRegulier("Dembele", 1444, 2022, "SLAM", 15);
            ajouterContact(Dembele);
            int[] matricule = new int[] { 1200, 9999, 1444, 2222 };
            renvoi += $"Nb contacts : {nbContacts()}\n";

            for (int i = 0; i < matricule.Length; i++)
            {
                if (this.existeContact(matricule[i]))
                {
                    renvoi += $"{matricule[i]} existe\n";
                }
                else
                {
                    renvoi += $"{ matricule[i]} n'existe pas\n";
                }
            }
            return renvoi;
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
            int nb = 0;
            foreach (Contact contact in Contacts.Values)
            {
                if (contact is EtudiantRegulier EtudiantReg)
                {
                    moy +=  EtudiantReg.NoteMoyenne;
                    nb++;
                }
            }
            return moy / nb;
        }

        public void ajouterContact(Contact contact)
        {
            Contacts[contact.Matricule]=contact;
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
