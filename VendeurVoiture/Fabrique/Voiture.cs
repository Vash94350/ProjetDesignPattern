using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    public abstract class Voiture : IVehicule, IReferenceable
    {
        private int nombreDeRoues = 4;
        private String reference = "NULL";
        private String name;
        private List<IRangement> rangements;

        public List<IRangement> Rangements
        {
            get
            {
                return this.rangements;
            }
            set
            {
                this.rangements = value;
            }
        }

        public int NombreDeRoues
        {
            get
            {
                return this.nombreDeRoues;
            }
        }

        public String Reference
        {
            get
            {
                return this.reference;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }

        public Voiture(String name, String reference)
        {
            this.name = name;
            this.reference = reference;
            rangements = new List<IRangement>();
        }
    }
}
