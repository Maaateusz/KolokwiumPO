using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium_ProjektDomu
{
    public enum Kolor
    {
        Niebieski,
        Zielony,
        Fioletowy,
        Czarny,
    }

    class Program
    {
        private static char znak;
        private static Projektant projektant = new Projektant();

        static void Main(string[] args)
        {
            while(true)
            {
                Menu();
                Pobierz_Znak();
            }
        }

        public static void Menu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("A - buduj blok");
            Console.WriteLine("B - buduj dom jednorodzinny");
            Console.WriteLine("X - wyjście z aplikacji");
            Console.WriteLine("--------------------------------------------");
        }

        public static void Wybierz()
        {
            switch (znak)
            {
                case 'A':
                    projektant.BudowaBloku();
                    break;

                case 'B':
                    projektant.BudowaDomuJednorodzinnego();
                    break;

                case 'X':
                    Console.WriteLine("Dziekujemy za skorzystanie z naszej aplikacji ;)");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Błędny znak!!!");
                    break;
            }
        }

        public static void Pobierz_Znak()
        {
            char[] znaki = { 'A', 'B', 'X' };
            bool dobry = false;
            while(!dobry)
            {
                  try
                  {
                      znak = Convert.ToChar(Console.ReadLine());
                      if (znaki.Contains(znak)) dobry = true;
                      else Console.WriteLine("Błąd wczytywania znaku!");
                  }
                  catch
                  {
                      dobry = false;
                      Console.WriteLine("Błąd wczytywania znaku!");
                  }
            }
            Wybierz();
        }
    }
}
