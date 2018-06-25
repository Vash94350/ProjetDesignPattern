using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture
{
    class Poche : IRangement, IReferenceable
    {
        private string name;
        private string reference;
        private int size;

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

        public String Reference
        {
            get
            {
                return this.reference;
            }
        }

        public Poche(string name, int size, string reference)
        {
            this.name = name;
            this.reference = reference;
            this.size = size;
        }
    }
}
