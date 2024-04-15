using Puerto.Dtos;
using Puerto.Servicios;

namespace Puerto.Controladores;

class Program
{
    public static void Main(string[] args)
    {
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        MenuInterfaz mi = new MenuImplementacion();
        OperativaInterfaz oi = new OperativaImplementacion();
        bool cerrarMenu = true;

        while (cerrarMenu)
        {
            int opcion = mi.mostrarMenuPrincipal();
            switch (opcion)
            {
                case 0:
                    cerrarMenu = false;
                    break;
                case 1:
                    oi.darAltaVehiculo(listaVehiculos);
                    break;
                case 2:
                    oi.accesoAVehiculo(listaVehiculos);
                    break;
                case 3:
                    oi.accesoPIF(listaVehiculos);
                    break;
                default:
                    break;
            }
        }
    }
}