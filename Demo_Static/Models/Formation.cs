using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static.Models
{
    internal class Formation
    {
        public static string centre;
        public string nom;
        public List<string> élèves; 
        public void Decrire()
        {
            Console.WriteLine($"La formation est dénommée {nom}, et voici des élèves :");
            foreach (string élèves in élèves)
            {
                Console.WriteLine($"\t- {élèves}");
            }
        }
        public static void  Description ()
        {
            Console.WriteLine($"Regroupe l'ensemble des formations de {centre}.");
        }
    }
}
