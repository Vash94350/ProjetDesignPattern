using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Conception
{
    class ComposantFabric
    {
        Dictionary<String, Composant> composants = new Dictionary<string, Composant>();
        public Composant getComposant(String key)
        {
            if(composants.ContainsKey(key))
            {
                return composants[key];
            }
            else
            {
                var newComposant = new Composant(key,0);
                composants.Add(key, newComposant);
                return newComposant;
            }
        }
    }
}
