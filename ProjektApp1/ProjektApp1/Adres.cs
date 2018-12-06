using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektApp1
{
    public class Adres
    {
        private string _ulica;
        private int _numerDomu;
        private int _numerMieszkania;
        private string _kodPocztowy;
        private string _miasto;
        private string _panstwo;

        public string PobierzAdres()
        {
            return $"ul. {_ulica} {_numerDomu}/{_numerMieszkania}" +
                $"\n{_kodPocztowy} {_miasto}" +
                $"\n{_panstwo}";
        }

        protected string Ulica
        {
            set
            {
                _ulica = value;
            }
        }
        protected int NumerDomu
        {
            set
            {
                _numerDomu = value;
            }
        }
        protected int NumerMieszkania
        {
            set
            {
                _numerMieszkania = value;
            }
        }
        protected string KodPocztowy
        {
            set
            {
                _kodPocztowy = value;
            }
        }

        protected string Miasto
        {
            set
            {
                _miasto = value; 
            }
        }
        protected string Panstwo
        {
            set
            {
                _panstwo = value;
            }
        }
    }
}
