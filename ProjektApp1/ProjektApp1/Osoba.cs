using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektApp1
{
    public class Osoba : Adres
    {
        private string _imie;
        private string _nazwisko;
 
        public Osoba()
        {
            this._imie = null;
            this._nazwisko = null;
            Ulica = null;
            NumerDomu = 0;
            NumerMieszkania = 0;
            KodPocztowy = null;
            Miasto = null;
            Panstwo = null;
        }

        public void PobierzDane()
        {
            Console.WriteLine("Podaj swoje imię");
            _imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko");
            _nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj swoje ulicę na której mieszkasz");
            Ulica = Console.ReadLine();
            Console.WriteLine("Podaj numer swojego domu");
            NumerDomu = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer swojego mieszkania");
            NumerMieszkania = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kod pocztowy");
            KodPocztowy = Console.ReadLine();
            Console.WriteLine("Podaj swoje miasto");
            Miasto = Console.ReadLine();
            Console.WriteLine("Podaj swoje państwo");
            Panstwo = Console.ReadLine();
        }

        public string PrzedstawSie()
        {
            return $"<{Imie}> <{Nazwisko}>";
        }

        private string Imie
        {
            get
            {
                return _imie;
            }
        }

        private string Nazwisko
        {
            get
            {
                return _nazwisko; 
            }
        }

    }
}
