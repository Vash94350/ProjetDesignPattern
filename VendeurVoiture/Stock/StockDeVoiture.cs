using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Stock
{
    class StockDeVoiture
    {
        List<Fabrique.Voiture> leStock = new List<Fabrique.Voiture>();

        public void AddVoiture(Fabrique.Voiture voiture)
        {
            leStock.Add(voiture);
        }

        public void RemoveVoiture(Fabrique.Voiture voiture)
        {
            leStock.Remove(voiture);
        }

        public List<Fabrique.Voiture> GetVoitureDisponnible(DateTime date)
        {
            return leStock;
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
