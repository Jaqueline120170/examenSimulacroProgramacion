using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puerto.Dtos
{
    internal class Vehiculo
    {
        string matricula;
        char tipo;
        string destino;
        bool mercancia;
        DateTime fechaPaso;

        public string Matricula { get => matricula; set => matricula = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public string Destino { get => destino; set => destino = value; }
        public bool Mercancia { get => mercancia; set => mercancia = value; }
        public DateTime FechaPaso { get => fechaPaso; set => fechaPaso = value; }

        public Vehiculo(string matricula, char tipo, string destino, bool mercancia, DateTime fechaPaso)
        {
            this.matricula = matricula;
            this.tipo = tipo;
            this.destino = destino;
            this.mercancia = mercancia;
            this.fechaPaso = fechaPaso;
        }

        public Vehiculo() { }
    }
}
