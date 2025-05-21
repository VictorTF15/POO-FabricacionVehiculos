    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricacionVehiculos
{
    interface IVehiculo
    {
        string Conducir();
    }

    internal class Auto : IVehiculo
    {
        public string Conducir()
        {
            return "Conduciendo un auto.";
        }
    }
}
