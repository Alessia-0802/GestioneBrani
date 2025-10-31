using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBrani
{
    class Cd
    {
        private string _titolo;
        private string _autore;
        private List<Brano> _brani;

        public Cd(string titolo, string autore)
        {
            _titolo = titolo;
            _autore = autore;
            _brani = new List<Brano>();
        }
        public string GetTitolo()
        {
            return _titolo;
        }
        public void SetTitolo(string titolo)
        {
            _titolo = titolo;
        }
        public string GetAutore()
        {
            return _autore;
        }
        public void SetAutore(string autore)
        {
            _autore = autore;
        }
        public void AggiungiBrano(Brano b)
        {
            _brani.Add(b);
        }
        public double Durata()
        {
            double totale = 0;
            foreach (Brano b in _brani)
            {
                totale += b.GetDurata();
            }
            return totale;
        }
    }
}
