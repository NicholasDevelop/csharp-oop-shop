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

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            Random r = new Random();

            this.Codice = r.Next(1, 99999999);
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        public void CodiceProdotto()
        {
            Console.WriteLine("Il codice del prodotto è: " + this.Codice);
        }

        public void BasePrice()
        {
            Console.WriteLine("Il prezzo base è: " + this.Prezzo);
        } 

        public void PriceIva()
        {
            double priceIva = (this.Prezzo * this.Iva)/ 100 + this.Prezzo;
            Console.WriteLine("Il prezzo comprensivo di IVA è: " + priceIva);
        }

        public void ExtendedName()
        {
            Console.WriteLine("Il nome esteso del prodotto è: " + (this.Codice + this.Nome));
        }

        public void NewCode()
        {
            string codeToString = this.Codice.ToString();
            string newCode = codeToString;

            for(int i = 0; i < 8 - codeToString.Length; i++)
            {
                if (this.Codice < 10000000)
                {
                    newCode = "0" + codeToString;
                }
            }

            Console.WriteLine("Il codice esteso è: " + newCode);
        }
    }
}
