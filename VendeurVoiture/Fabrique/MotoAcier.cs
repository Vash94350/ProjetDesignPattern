using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    class MotoAcier : Moto
    {
        public MotoAcier(string name, string reference) : base(name, reference)
        {
            Price = new Stock.Price(1200.0, "EUR");
        }
    }
}
