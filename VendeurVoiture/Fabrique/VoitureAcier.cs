using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    class VoitureAcier : Voiture
    {
        public VoitureAcier(string name, string reference) : base(name, reference)
        {
            Price = new Stock.Price(4500.0, "EUR");
        }
    }
}
