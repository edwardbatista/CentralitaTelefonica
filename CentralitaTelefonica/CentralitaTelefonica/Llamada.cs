using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    internal class Llamada
    {
        public string numOrigen;
        public string numDestino;
        public int duracion;
        private double costePorSegundo = 0;

        public Llamada(string numeroOrigen, string numeroDestino, int duracion)
        {
            this.numOrigen = numeroOrigen;
            this.numDestino = numeroDestino;
            this.duracion = duracion;
        }

        public virtual double Coste()
        {
            return duracion * costePorSegundo;
        }
    }
}
