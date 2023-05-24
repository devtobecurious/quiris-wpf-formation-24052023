using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteMaraudeurSW.Core.Models
{
    public class FauconMilenium : IMoyenDeplacement
    {
        public void SeDeplacer()
        {
            Console.WriteLine("Faucon super rapide");
        }
    }
}
