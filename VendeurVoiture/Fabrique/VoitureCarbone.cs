﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    class VoitureCarbone : Voiture
    {
        public VoitureCarbone(string name, string reference) : base(name, reference)
        {
            Price = new Stock.Price(6300.0, "EUR");

        }
    }
}
