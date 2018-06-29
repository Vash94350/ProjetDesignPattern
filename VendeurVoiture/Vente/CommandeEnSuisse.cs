using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Vente
{
    class CommandeEnSuisse : BaseCommande
    {
        private double preTaxMontant;
        private String devise = "Inconnue";

        public CommandeEnSuisse(Fabrique.Voiture voiture)
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
            return this.preTaxMontant * 0.23;
        }

        protected override double CalculeTVA()
        {
            return this.preTaxMontant;
        }
    }
}
