using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBrani
{
    class Brano 
    {
        public string titolo { get; set; }
        public string autore { get; set; }
        public double durata {  get; set; }

        public Brano(string newTitolo, string newAutore, double newDurata)
        {
            newTitolo = titolo;
            newAutore = autore;
            newDurata = durata;

        }
    }

    
}
