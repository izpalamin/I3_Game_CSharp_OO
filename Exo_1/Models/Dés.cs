using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Exo_Monopoly.Models
{
    internal static class Dés
    {
        public static int valeurMin;
        public static int valeurMax;
        public static Random rng = new Random();

        public static int[] Lancer(int nbDés)
        {
            int[] results = new int[nbDés];
            for (int i = 0; i < results.Length; i++) 
            { 
                results[i] = rng.Next(valeurMin, valeurMax+1);
            }
            return results;

        }

    }
}
