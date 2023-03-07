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
            EtudiantEchange tetch = new EtudiantEchange("Dembele", 1000, 2022, "ok", "toulon");
            //Console.WriteLine(testToString2(tetch));
            testToString2(tetch);
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
            return etch.nom
        }
    }
}
