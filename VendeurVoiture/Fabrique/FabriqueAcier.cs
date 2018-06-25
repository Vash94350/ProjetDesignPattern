using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    public class FabriqueAcier : VehiculCreator
    {
        public override Moto CreateMoto(string name, string reference)
        {
            return new MotoAcier(name,reference);
        }

        public override Voiture CreateVoiture(string name, string reference)
        {
            return new VoitureAcier(name,reference);
        }
    }
}
