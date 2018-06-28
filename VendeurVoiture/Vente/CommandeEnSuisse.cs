using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Vente
{
    class CommandeEnSuisse : BaseCommande
    {
        private double preTaxMontant;

        public CommandeEnSuisse(double preTaxMontant)
        {
            this.preTaxMontant = preTaxMontant;
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
