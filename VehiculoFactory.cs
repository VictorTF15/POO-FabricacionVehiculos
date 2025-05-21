using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricacionVehiculos
{
    internal class VehiculoFactory
    {
        public static IVehiculo CrearVehiculo(string tipo)
        {
            if (tipo == "Auto") return new Auto();
            if (tipo == "Moto") return new Moto();
            throw new ArgumentException("Tipo de vehículo desconocido");
        }
    }
}
