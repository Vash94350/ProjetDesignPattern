using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    interface IVehiculeCreator
    {
        Moto CreateMoto(string name, string reference);

        Voiture CreateVoiture(string name, string reference);
    }
}
