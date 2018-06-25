using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture
{
    class BoiteAGants : IRangement, IReferenceable
    {
        private string name;
        private string reference;
        private int size;
        private String openingSystem;
        private List<IRangement> rangements;

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }

        public String OpeningSystem
        {
            get
            {
                return this.openingSystem;
            }
        }

        public String Reference
        {
            get
            {
                return this.reference;
            }
        }

        public List<IRangement> Rangements
        {
            get
            {
                return rangements;
            }
        }

        public int GetContainsNumber()
        {
            return Rangements.Count;
        }

        public BoiteAGants(string name, int size, string openingSystem, string reference)
        {
            this.openingSystem = openingSystem;
            this.name = name;
            this.reference = reference;
            this.size = size;
            this.rangements = new List<IRangement>();
        }

        public static implicit operator List<object>(BoiteAGants v)
        {
            throw new NotImplementedException();
        }
    }
}
