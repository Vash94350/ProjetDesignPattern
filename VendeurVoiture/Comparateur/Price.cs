using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Comparateur
{
    class Price
    {
        private double price;
        private string currency;

        public Price(double price, string currency)
        {
            this.price = price;
            this.currency = currency;
        }

        public double Amount { get => this.price; }
        public string Currency { get => this.currency; }
    }
}
