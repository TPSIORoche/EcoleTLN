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
            Nom = nom;
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
            return $"Etudiant Régulier :\n\tMatricule : {this.matricule}\n\tNom : {this.Nom}\n\tAnnée : {this.AnneeArrivee}\n\tSection : {this.section}\n\tMoyenne : {this.univesiteOrigine}\n";
        }

         

    }

    class EtudiantRegulier : Etudiant
    {
        protected double noteMoyenne;
        public double NoteMoyenne { get => noteMoyenne; set => noteMoyenne = value; }


        public EtudiantRegulier(string nom, int matricule, int anneeArrivee, string section,double noteMoyenne) : base(nom, matricule, anneeArrivee, section)
        {
            NoteMoyenne = noteMoyenne;
        }


        public override string ToString()
        {
            return $"Etudiant Régulier :\n\tMatricule : {this.matricule}\n\tNom : {this.Nom}\n\tAnnée : {this.AnneeArrivee}\n\tSection : {this.section}\n\tMoyenne : {NoteMoyenne}\n";
            
        }
    }

}
