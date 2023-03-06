﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Classes.ClassesEcole
{
    abstract class Contact
    {
        private int matricule;
        protected string nom;
        protected int anneeArrivee;

        protected Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            AnneeArrivee = anneeArrivee;
        }

        public int AnneeArrivee
        {
            get => anneeArrivee;
            set
            {
                if (value > DateTime.Now.Year)
                {
                    anneeArrivee = value;
                }
                else
                {
                    throw new Exception("L'année n'est pas valide");
                }
            }
        }

        public int Matricule
        {
            get => matricule;
            set
            {
                if (Regex.IsMatch((string)value, @"^[0-9]{4}$"))
                {
                    this.matricule = value;
                }
                else
                {
                    throw new Exception("erreur : Matricule non valide");
                }
            }
        }
    }

}
