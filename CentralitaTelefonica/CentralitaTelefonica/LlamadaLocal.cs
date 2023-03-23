using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    internal class LlamadaLocal : Llamada
    {
        private double costePorSegundo = 0.15;

        public LlamadaLocal(string numOrigen, string numDestino, int duracion)
          : base(numOrigen, numDestino, duracion)
        {
        }

        override public double Coste()
        {
            return duracion * costePorSegundo;
        }

        public string toString()
        {
            return Coste().ToString();
        }
    }
}
