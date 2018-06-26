using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Conception
{
    class Composant
    {
        int price;
        public String name;

        public Composant(String name,int price)
        {
            this.price = price;
            this.name = name;
        }
    }
}
