using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.ClassesEcole;

namespace EcoleTLN
{
    class Program
    {
        static void Main(string[] args)
        {
            Ecole tln = new Ecole("TLN", 1999);
            EtudiantRegulier t1 = new EtudiantRegulier("Gaston Peutimide",1200, 2013, "SSC",6);
            EtudiantRegulier t2 = new EtudiantRegulier("Yvan Rattrapeur", 1204, 2011, "SSC", 2.5);
            EtudiantEchange t3 = new EtudiantEchange("Bjorn Borgue", 1345, 2012, "Informatique","KTH");
            Enseignant t4 = new Enseignant(1114, "Mathieu Matheu", 2011, "SSC", 10000,"Physique");
            Secretaitre t5 = new Secretaitre(1409, "Sophie Scribona", 2005, "LMT", 5000);
            tln.ajouterContact(t1);
            tln.ajouterContact(t2);
            tln.ajouterContact(t3);
            tln.ajouterContact(t4);
            tln.ajouterContact(t5);
            Console.WriteLine(tln.afficheTous());
            //Ecole ecole = new Ecole("Bonaparte",1980);
            //ecole.ajouterContact(tetch);
            Console.ReadKey();
        }
        
        public static string testToString(EtudiantEchange etch)
        {
            return etch.ToString();
        }
        public static void testToString2(EtudiantEchange etch)
        {
            Console.WriteLine(etch.ToString());
        }

        public string testpif(EtudiantEchange etch)
        {
            return etch.Nom;
        }
    }
}
