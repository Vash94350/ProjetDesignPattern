using System;
using System.Collections.Generic;
using System.Text;
using VendeurVoiture.Stock;

namespace VendeurVoiture.Fabrique
{
    public abstract class Voiture : IVehicule, IReferenceable
    {
        private int nombreDeRoues = 4;
        private String reference = "NULL";
        private String name;
        private List<IRangement> rangements;
        private List<Conception.Composant> lesComposants=new List<Conception.Composant>();
        private Vente.Price price = null;

        public List<Conception.Composant> LesComposants
        {
            get
            {
                return lesComposants;
            }
        }

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

        public List<IRangement> Rangements
        {
            get
            {
                return this.rangements;
            }
        }

        public void AddRangement(IRangement rangement)
        {
            Rangements.Add(rangement);
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

        public String getListDesComposants()
        {
            String result = String.Empty;
            //            foreach (var flyweight in lesComposants)
            //            {
            //                result += flyweight.name + "   ";
            //            }
            lesComposants.ForEach(Composant => result += Composant.name + " avec reference " + Composant.Reference + "    ");

            return result;
        }

        public void AddComposant(Conception.Composant composant)
        {
            lesComposants.Add(composant);
        }

        public Voiture(String name, String reference)
        {
            this.name = name;
            this.reference = reference;
            rangements = new List<IRangement>();
            Stock.StockDeVoiture.Instance.AddVoiture(this);
        }
    }
}
