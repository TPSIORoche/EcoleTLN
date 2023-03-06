using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    abstract class Personnel:Contact
    {
        protected string nomLaboratoire;
        protected double salaire;

        protected Personnel(int matricule, string nom, int anneeArrivee) : base(matricule, nom, anneeArrivee)
        {
        }
    }

    class Secretaitre:Personnel
    {

    }

    class Enseignant:Personnel
    {
        protected string section;
    }
}
