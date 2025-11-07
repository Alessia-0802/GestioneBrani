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
        
        
        
        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }
        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }
        
        

        public Cd(string titolo, string autore)
        {
            Titolo = titolo;
            Autore = autore;
            List<Brano> brani;
        }
        
        public void AggiungiBrano(Brano b)
        {
            brani.Add(b);
        }
        public double Durata()
        {
            double totale = 0;
            foreach (Brano b in brani)
            {
                totale += b.GetDurata();
            }
            return totale;
        }
    }
}
