using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium_ProjektDomu
{
    class DomJednorodzinny : ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(Kolor.Niebieski);
        }

        public override string ToString()
        {
            return "Dom jednorodzinny: " + base.ToString();
        }
    }
}
