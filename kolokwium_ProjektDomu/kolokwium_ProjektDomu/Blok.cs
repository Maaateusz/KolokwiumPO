using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium_ProjektDomu
{
    class Blok : ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(kolor);
        }

        public override string ToString()
        {
            return "Blok: " + base.ToString();
        }

        public override void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.ZamontujDrzwi("brązowe, dąb");
        }
    }
}
