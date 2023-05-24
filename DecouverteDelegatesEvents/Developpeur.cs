using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteDelegatesEvents
{
    internal class Developpeur
    {
        //public event CodeFini MonCodeEstFini;
        public event Action<Code> MonCodeEstFini;

        public void Ecrire()
        {
            Code code = new Code();

            ///
            //
            //
            this.MonCodeEstFini(code);
        }
    }
}
