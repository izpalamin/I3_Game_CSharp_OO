using Exo_Monoply.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    internal class Joueur
    {
        public string nom;
        public Pions pions;
        public int position = 0;
        public bool Avancer()
        {
            Dés.valeurMin = 1;
            Dés.valeurMax = 6;
            int[] resultDés = Dés.Lancer(2);
            position += resultDés[0] + resultDés[1];
            return resultDés[0] == resultDés[1];
        }
    }
}
