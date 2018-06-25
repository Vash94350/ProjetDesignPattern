using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    public abstract class VehiculCreator : IVehiculeCreator
    {
        public abstract Moto CreateMoto(string name,string reference);

        public abstract Voiture CreateVoiture(string name, string reference);
    }
}
