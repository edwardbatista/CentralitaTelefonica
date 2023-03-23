using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{
    internal class Centralita
    {
        private List<Llamada> llamadas = new List<Llamada>();
        private int numLlamadas = 0;
        private double costoTotal = 0;

        public void RegistrarLlamada(Llamada llamada)
        {
            llamadas.Add(llamada);
            numLlamadas++;
            costoTotal += llamada switch
            {
                LlamadaLocal local => local.Coste(),
                LlamadaProvincial provincial => provincial.Coste(),
                _ => 0,
            };

            Console.WriteLine("Llamada desde:" + llamada.numOrigen + " hacia " + llamada.numDestino + " (" + llamada.duracion + " segundos)");
            Console.WriteLine("Costo de llamada = $" + llamada.Coste() + " DOP");
        }

        public void GenerarInforme()
        {
            Console.WriteLine("Total de llamadas: " + numLlamadas);
            Console.WriteLine("Costo total:" + costoTotal.ToString("C") + " DOP ");
        }

    }
}

