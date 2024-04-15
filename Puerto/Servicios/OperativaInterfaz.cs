using Puerto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puerto.Servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaVehiculo(List<Vehiculo> listaVehiculos);

        public void accesoAVehiculo(List<Vehiculo> listaVehiculos);
    }
}
