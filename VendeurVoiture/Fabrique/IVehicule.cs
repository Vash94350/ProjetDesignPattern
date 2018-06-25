using System;
using System.Collections.Generic;
using System.Text;

namespace VendeurVoiture.Fabrique
{
    interface IVehicule
    {
        int NombreDeRoues { get; }
        String Name { get; }
    }
}
