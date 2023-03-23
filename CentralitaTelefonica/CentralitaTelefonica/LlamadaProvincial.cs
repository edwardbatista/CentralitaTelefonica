using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    internal class LlamadaProvincial : Llamada
    {
        private int franjaHoraria;

        public LlamadaProvincial(string numOrigen, string numDestino, int duracion, int franjaHoraria)
          : base(numOrigen, numDestino, duracion)
        {
            this.franjaHoraria = franjaHoraria;
        }

        override public double Coste()
        {
            double costePorSegundo = 0;

            switch (franjaHoraria)
            {
                case 1:

                    costePorSegundo = 0.20;

                    break;

                case 2:

                    costePorSegundo = 0.25;

                    break;

                case 3:

                    costePorSegundo = 0.30;

                    break;
            }

            return duracion * costePorSegundo;

        }
    }
}
