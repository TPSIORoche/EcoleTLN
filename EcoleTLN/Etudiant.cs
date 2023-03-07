using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    abstract class Etudiant:Contact
    {
        protected string section;

        protected Etudiant(string nom, int matricule, int anneeArrivee, string section):base(matricule, nom, anneeArrivee)
        {
            this.nom = nom;
            this.matricule = matricule;
            this.anneeArrivee = anneeArrivee;
            this.section = section;
        }

    }

    class EtudiantEchange : Etudiant
    {
        private string univesiteOrigine;

        public EtudiantEchange(string nom, int matricule, int anneeArrivee, string section,string univesiteOrigine) : base(nom, matricule, anneeArrivee, section)
        {
            this.univesiteOrigine = univesiteOrigine;
        }

        public override string ToString()
        {
            return $"Etudiant Régulier :\n\tMatricule : {this.matricule}\n\tNom : {this.nom}\n\tAnnée : {this.AnneeArrivee}\n\tSection : {this.section}\n\tMoyenne : {this.univesiteOrigine}";
        }

         

    }

    class EtudiantRegulier : Etudiant
    {
        private double noteMoyen;

        public EtudiantRegulier(string nom, int matricule, int anneeArrivee, string section,double noteMoyen) : base(nom, matricule, anneeArrivee, section)
        {
            this.NoteMoyen = noteMoyen;
        }

        public double NoteMoyen { get => noteMoyen; set => noteMoyen = value; }

        public override string ToString()
        {
            return $"Etudiant Régulier :\n\tMatricule : {this.matricule}\n\tNom : {this.nom}\n\tAnnée : {this.AnneeArrivee}\n\tSection : {this.section}\n\tMoyenne : {this.noteMoyen}";
            
        }
    }

}
