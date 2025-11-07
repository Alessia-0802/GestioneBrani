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
        // Permettono di leggere e modificare direttamente i valori 
        public string titolo { get; set; }
        public string autore { get; set; }
        public double durata {  get; set; }

        // Costruttore della classe: iniziaòlizza uhn nuovo oggetto brano
        public Brano(string newTitolo, string newAutore, double newDurata)
        {
            newTitolo = titolo;
            newAutore = autore;
            newDurata = durata;

        }

        // Metodo che restituisce una descrizione testuale dell'oggetto Brano.
        public override string ToString()   // override, per sovrascivere il metodo ToString().
        {
            return $"Titolo: {titolo}. Autore: {autore}. Durata: {durata}";     //Il segno $, è usato per poter mettere all'interno di una strigna direttamente le variabili tramite le parentesi graffe.
        }

        // Metodo che verifica se la durata del brano è minore della soglia.
        public bool ShortSong (double sogliaDurata)
        {
            // Restituisce true se il valore della durata è maggiore della soglia, altrimenti false.
            return durata < sogliaDurata;
        }
    }
}
