using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Conception
{
    class ComposantFabric
    {
        String reference;
        int incrementReference = 0;
        Dictionary<String, Composant> composants = new Dictionary<string, Composant>();
        public Composant getComposant(String key)
        {
            if(composants.ContainsKey(key))
            {
                return composants[key];
            }
            else
            {
                reference = "c000" + incrementReference.ToString();
                incrementReference++;
                var newComposant = new Composant(key,new Stock.Price(0.0,"EUR"),reference);
                composants.Add(key, newComposant);
                return newComposant;
            }
        }
    }
}
