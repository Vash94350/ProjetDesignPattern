using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    class MotoCarbone : Moto
    {
        public MotoCarbone(string name, string reference) : base(name, reference)
        {
            Price = new Vente.Price(1800.0, "EUR");

        }
    }
}
