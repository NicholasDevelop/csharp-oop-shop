using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int Codice{ get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }

        public Prodotto(int codice, string nome, string descrizione, double prezzo, int iva)
        {
            this.Codice = codice;
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        public void BasePrice()
        {
            Console.WriteLine("Il prezzo base è di: " + this.Prezzo + "€");
        } 

        public double PriceIva()
        {
            return (Prezzo*22)/100 + Prezzo;
        }

        public string ExtendedName()
        {
            return this.Codice + this.Nome;
        }
    }
}
