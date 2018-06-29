using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    public abstract class Moto : IVehicule, IReferenceable
    {
        private int nombreDeRoues = 2;
        private String reference = "NULL";
        private string name;
        private Vente.Price price = null;

        public Vente.Price Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public int NombreDeRoues
        {
            get
            {
                return this.nombreDeRoues;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Reference
        {
            get
            {
                return this.reference;
            }
        }

        public Moto(String name, String reference)
        {
            this.name = name;
            this.reference = reference;
        }
    }
}
