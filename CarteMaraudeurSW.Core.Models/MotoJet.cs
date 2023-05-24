using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteMaraudeurSW.Core.Models
{
    public class MotoJet : IMoyenDeplacement
    {
        public void SeDeplacer()
        {
            Console.WriteLine("Moto jet bzzzz");
        }
    }
}
