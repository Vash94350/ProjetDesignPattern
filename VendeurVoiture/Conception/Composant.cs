using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Conception
{
    public class Composant : IReferenceable
    {
        public Vente.Price price;
        public String name;
        public string reference;

        public String Reference
        {
            get
            {
                return this.reference;
            }
        }

        public Composant(String name,Vente.Price price,String reference)
        {
            this.price = price;
            this.name = name;
            this.reference = reference;
        }

        public void SetPrice(Vente.Price price)
        {
            this.price = price;
        }
    }
}
