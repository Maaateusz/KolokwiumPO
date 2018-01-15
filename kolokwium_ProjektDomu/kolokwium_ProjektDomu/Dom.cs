using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium_ProjektDomu
{
    class Dom
    {
        private string drzwi;
        private Kolor kolorElewacji;
        private string okno;

        public void PomalujElewacje(Kolor kolor)
        {
            this.kolorElewacji = kolor;
        }

        public override string ToString()
        {
            return "Okna: " + okno + ", Drzwi: " + drzwi + ", Kolor: " + kolorElewacji; 
        }

        public void WstawOkna(string okno)
        {
            this.okno = okno;
        }

        public void ZamontujDrzwi(string rodzajDrzwi)
        {
            this.drzwi = rodzajDrzwi;
        }
    }
}
