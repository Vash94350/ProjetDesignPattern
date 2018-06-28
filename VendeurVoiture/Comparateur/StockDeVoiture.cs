using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Comparateur
{
    class StockDeVoiture
    {
        List<Fabrique.Voiture> leStock = new List<Fabrique.Voiture>();

        public void Add(Fabrique.Voiture voiture)
        {
            leStock.Add(voiture);
        }

        public List<Fabrique.Voiture> GetVoitureDisponnible(DateTime date)
        {
            return leStock;
        }

        public Price GetPrixVoiture(Fabrique.Voiture voiture, DateTime date)
        {
            // Get from DB
            var price = new Price(36, "EUR");
            return price;
        }
        private static StockDeVoiture instance = new StockDeVoiture();

        public static StockDeVoiture Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
