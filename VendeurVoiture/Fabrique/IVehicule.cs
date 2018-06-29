using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    interface IVehicule
    {
        Stock.Price Price { get; }
        int NombreDeRoues { get; }
        String Name { get; }
    }
}
