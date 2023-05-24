using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteMaraudeurSW.Core.Models
{
    public class HumeurMoyenDeplacement
    {
        private Dictionary<Humeur, IMoyenDeplacement> moyensDeplacements = new()
        {
            { Humeur.Heureux, new MotoJet() },
            { Humeur.EnColere, new FauconMilenium() }
        };

        public IMoyenDeplacement Create(Humeur humeur)
        {
            return this.moyensDeplacements[humeur];
        }
    }
}
