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

        protected Etudiant(string section) : base(matricule, nom, anneeArrivee)
        {
            this.section = section;
        }
    }

    class EtudiantEchange : Etudiant
    {
        private string UnivesiteOrigine;


    }

    class EtudiantRegulier : Etudiant
    {
        private double noteMoyen;

        public EtudiantRegulier(double noteMoyen):base(section)
        {
            NoteMoyen = noteMoyen;
        }

        public double NoteMoyen { get => noteMoyen; set => noteMoyen = value; }
    }

}
