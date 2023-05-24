using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteDelegatesEvents
{
    public class Calculateur
    {
        public void Calculer(Afficher afficheur)
        {
            int result = 1 + 3;
            //Console.WriteLine(result);
            // Je veux afficher
            afficheur(result.ToString());
        }
    }
}
