using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    class FabriqueCarbone : VehiculCreator
    {
        public override Moto CreateMoto(string name, string reference)
        {
            return new MotoCarbone(name,reference);
        }

        public override Voiture CreateVoiture(string name, string reference)
        {
            return new VoitureCarbone(name,reference);
        }
    }
}
