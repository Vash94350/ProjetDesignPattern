using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Vente
{
    class CommandeEnFrance : BaseCommande
    {
        private double preTaxMontant;
        private String devise = "Inconnue";

        public CommandeEnFrance(Fabrique.Voiture voiture)
        {
            this.preTaxMontant = voiture.Price.Amount;
            this.devise = voiture.Price.Currency;
            foreach (Conception.Composant composant in voiture.LesComposants)
            {
                this.preTaxMontant += composant.price.Amount;
            }
        }

        protected override double CalculePreTaxMontant()
        {
            return this.preTaxMontant * 0.196;
        }

        protected override double CalculeTVA()
        {
            return this.preTaxMontant;
        }

        public String getDevise()
        {
            return devise;
        }
    }
}
