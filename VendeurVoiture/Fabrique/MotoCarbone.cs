using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    class MotoCarbone : Moto
    {
        public MotoCarbone(string name, string reference) : base(name, reference)
        {
            Price = new Stock.Price(1800.0, "EUR");

        }
    }
}
