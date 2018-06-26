using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Conception
{
    class Voiture
    {
        public List<Composant> lesComposants= new List<Composant>();

        public String toString()
        {
            String result=String.Empty;
            //            foreach (var flyweight in lesComposants)
            //            {
            //                result += flyweight.name + "   ";
            //            }
            lesComposants.ForEach(Composant=> result+=Composant.name + "   ");

            return result;
        }
    }
}
