using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Vente
{
    internal abstract class BaseCommande : ICommande
    {
        public double CalculeMontant()
        {
            return CalculeTVA() + CalculePreTaxMontant();
        }

        protected abstract double CalculeTVA();
        protected abstract double CalculePreTaxMontant();
    }
}
