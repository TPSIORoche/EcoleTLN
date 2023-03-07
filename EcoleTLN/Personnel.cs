using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    abstract class Personnel : Contact
    {
        private string nomLaboratoire;
        private double salaire;

        protected Personnel(int matricule, string nom, int anneeArrivee,string nomLaboratoire,double salaire) : base(matricule, nom, anneeArrivee)
        {
            NomLaboratoire = nomLaboratoire;
            Salaire = salaire;
        }

        public string NomLaboratoire { get => nomLaboratoire; set => nomLaboratoire = value; }
        public double Salaire { get => salaire; set => salaire = value; }


    }

    class Secretaitre : Personnel
    {
        public Secretaitre(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArrivee, nomLaboratoire, salaire)
        {
        }

        public override string ToString()
        {
            return $"Etudiant Régulier :\n\tMatricule : {this.Matricule}\n\tNom : {this.Nom}\n\tAnnée : {this.AnneeArrivee}\n\tSection : {this.NomLaboratoire}\n\tMoyenne : {this.Salaire}\n";

        }
    }

    class Enseignant : Personnel
    {
        private string section;

        public Enseignant(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire,string section) : base(matricule, nom, anneeArrivee, nomLaboratoire, salaire)
        {
            Section = section;
        }

        public string Section { get => section; set => section = value; }

        public override string ToString()
        {
            return $"Enseignant :\n\tMatricule : {this.Matricule}\n\tNom : {this.Nom}\n\tAnnée : {this.AnneeArrivee}\n\tMoyenne : {this.Salaire}\n\tSection : {this.section}\n";

        }
    }
}

