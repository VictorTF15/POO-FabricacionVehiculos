using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricacionVehiculos
{
    internal class Moto : IVehiculo
    {
        public string Conducir()
        {
            return "Conduciendo una moto.";
        }
    }
}
