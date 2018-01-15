using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium_ProjektDomu
{
    abstract class ProjektDomu
    {
        protected Dom dom;

        public void NowyDom()
        {
            dom = new Dom();
        }

        public abstract void PomalujElewacje(Kolor kolor);

        public override string ToString()
        {
            return dom.ToString();
        }

        public virtual void WstawOkna(string rodzajOkien)
        {
            dom.WstawOkna(rodzajOkien);
        }

        public virtual void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.ZamontujDrzwi(rodzajDrzwi);
        }
    }
}
