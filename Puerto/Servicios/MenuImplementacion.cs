using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puerto.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuPrincipal()
        {
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("0 - CERRAR APLICACIÓN");
            Console.WriteLine("1 - DAR DE ALTA VEHÍCULO");
            Console.WriteLine("2 - ACCESO A VEHÍCULO");
            Console.WriteLine("3 - PUESTO FRONTERIZO");
            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
