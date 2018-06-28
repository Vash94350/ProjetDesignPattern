using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Vente
{
    class CommandeEnFrance : BaseCommande
    {
        private double preTaxMontant;

        public CommandeEnFrance(double preTaxMontant)
        {
            this.preTaxMontant = preTaxMontant;
        }

        protected override double CalculePreTaxMontant()
        {
            return this.preTaxMontant * 0.196;
        }

        protected override double CalculeTVA()
        {
            return this.preTaxMontant;
        }
    }
}
