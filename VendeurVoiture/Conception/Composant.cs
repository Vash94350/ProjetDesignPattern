using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Conception
{
    public class Composant : IReferenceable
    {
        public Stock.Price price;
        public String name;
        public string reference;

        public String Reference
        {
            get
            {
                return this.reference;
            }
        }

        public Composant(String name,Stock.Price price,String reference)
        {
            this.price = price;
            this.name = name;
            this.reference = reference;
        }

        public void SetPrice(Stock.Price price)
        {
            this.price = price;
        }
    }
}
