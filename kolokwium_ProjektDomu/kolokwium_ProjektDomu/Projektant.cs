using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium_ProjektDomu
{
    class Projektant
    {
        private ProjektDomu projektDomu;

        public void Buduj(string rodzajOkien, string rodzajDrzwi, Kolor kolor)
        {
            projektDomu.NowyDom();
            projektDomu.WstawOkna(rodzajOkien);
            projektDomu.ZamontujDrzwi(rodzajDrzwi);
            projektDomu.PomalujElewacje(kolor);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void WybierzProjekt(ProjektDomu projekt)
        {
            this.projektDomu = projekt;
        }

        public void BudowaBloku()
        {
            string rodzaj_okien;
            string rodzaj_drzwi;
            string kolor;
            Kolor kolorEnum;
            Console.WriteLine("Budowanie bloku...");
            Console.WriteLine("Podaj rodzaj okien: ");
            rodzaj_okien = Console.ReadLine();
            Console.WriteLine("Podaj rodzaj drzwi: ");
            rodzaj_drzwi = Console.ReadLine();
            Console.WriteLine("Podaj kolor (Niebieski, Zielony, Fioletowy, Czarny,): ");
            kolor = Console.ReadLine();
            try
            {
                kolorEnum = (Kolor)Enum.Parse(typeof(Kolor), kolor);
            }
            catch
            {
                kolorEnum = Kolor.Niebieski;
                Console.WriteLine("Nie rozpoznano koloru!");
            }
            Buduj(rodzaj_okien, rodzaj_drzwi, kolorEnum);
            Console.WriteLine("Budowa została zakończona pomyślnie.");
            Console.WriteLine("Utworzono: {0}", ToString());
        }

        public void BudowaDomuJednorodzinnego()
        {
            string rodzaj_okien;
            string rodzaj_drzwi;
            string kolor;
            Kolor kolorEnum;
            Console.WriteLine("Budowanie domu jednorodzinnego...");
            Console.WriteLine("Podaj rodzaj okien: ");
            rodzaj_okien = Console.ReadLine();
            Console.WriteLine("Podaj rodzaj drzwi: ");
            rodzaj_drzwi = Console.ReadLine();
            Console.WriteLine("Podaj kolor (Niebieski, Zielony, Fioletowy, Czarny,): ");
            kolor = Console.ReadLine();
            try
            {
                kolorEnum = (Kolor)Enum.Parse(typeof(Kolor), kolor);
            }
            catch
            {
                kolorEnum = Kolor.Niebieski;
                Console.WriteLine("Nie rozpoznano koloru!");
            }
            Buduj(rodzaj_okien, rodzaj_drzwi, kolorEnum);
            Console.WriteLine("Budowa została zakończona pomyślnie.");
            Console.WriteLine("Utworzono: {0}", ToString());
        }
    }
}
