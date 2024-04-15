using Puerto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puerto.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaVehiculo(List<Vehiculo> listaVehiculos)
        {
            Console.WriteLine("Matricula:");
            string matricula = Console.ReadLine();
            Console.WriteLine("Tipo de vehiculo (P, F, A):");
            char tipo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("zona de destino:");
            string destino = Console.ReadLine();
            Console.WriteLine("Mercania (true o false):");
            bool mercancia = Convert.ToBoolean(Console.ReadLine());
            DateTime fecha;

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Matricula = matricula;
            vehiculo.Tipo = tipo;
            vehiculo.Destino = destino;
            vehiculo.Mercancia = mercancia;
            //vehiculo.FechaPaso = fecha;

            listaVehiculos.Add(vehiculo);
        }

        public void accesoAVehiculo(List<Vehiculo> listaVehiculos)
        {
            Console.WriteLine("Matricula:");
            string matricula = Console.ReadLine();

            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                if (vehiculo.Matricula.Equals(matricula))
                {
                    if (vehiculo.Destino.Equals("SO") && vehiculo.Tipo.Equals('P'))
                    {
                        Console.WriteLine("EL VEHICULO PUEDE ACCEDER A SO");
                    }
                    else if (vehiculo.Destino.Equals("SE") && vehiculo.Mercancia.Equals(true) && (vehiculo.Tipo.Equals('F') || vehiculo.Tipo.Equals('A')))
                    {
                        Console.WriteLine("EL VEHICULO PUEDE ACCEDER A SE");
                    }
                    else if (vehiculo.Destino.Equals("SN") && vehiculo.Mercancia.Equals(false) && (vehiculo.Tipo.Equals('F') || vehiculo.Tipo.Equals('A')))
                    {
                        Console.WriteLine("EL VEHICULO PUEDE ACCEDER A SN");
                    }
                    else
                    {
                        Console.WriteLine("EL VEHICULO NO PUEDE ACCEDER");
                    }
                }
            }
        }

        public void accesoPIF(List<Vehiculo> listaVehiculos)
        {
            Console.WriteLine("Matricula:");
            string matricula = Console.ReadLine();

            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                if (vehiculo.Matricula.Equals(matricula))
                {
                    if (vehiculo.Destino.Equals("SO") && vehiculo.Tipo.Equals('P'))
                    {
                        Console.WriteLine("EL VEHICULO PUEDE ACCEDER A SO");
                    }
                    else if (vehiculo.Destino.Equals("SE") && vehiculo.Mercancia.Equals(true) && (vehiculo.Tipo.Equals('F') || vehiculo.Tipo.Equals('A')))
                    {
                        Console.WriteLine("EL VEHICULO PUEDE ACCEDER A SE");
                    }
                    else if (vehiculo.Destino.Equals("SN") && vehiculo.Mercancia.Equals(false) && (vehiculo.Tipo.Equals('F') || vehiculo.Tipo.Equals('A')))
                    {
                        Console.WriteLine("EL VEHICULO PUEDE ACCEDER A SN");
                    }
                    else
                    {
                        Console.WriteLine("EL VEHICULO NO PUEDE ACCEDER");
                    }
                }
            }
        }
    }
}
