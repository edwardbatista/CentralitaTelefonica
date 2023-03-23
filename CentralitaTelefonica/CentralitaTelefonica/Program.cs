using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaTelefonica
{

    class Practica2

    {

        static void Main(string[] args)

        {
            //Nueva Centralita
            Centralita centralita = new Centralita();

            //Llamadas locales
            LlamadaLocal local1 = new LlamadaLocal("8091234567", "8293456789", 75);
            centralita.RegistrarLlamada(local1);

            LlamadaLocal local2 = new LlamadaLocal("8095674742", "8095474731", 180);
            centralita.RegistrarLlamada(local2);

            //Llamadas provinciales
            LlamadaProvincial provincial1 = new LlamadaProvincial("8093334567", "8492349876", 90, 1);
            centralita.RegistrarLlamada(provincial1);

            LlamadaProvincial provincial2 = new LlamadaProvincial("8091112222", "8297023222", 120, 2);
            centralita.RegistrarLlamada(provincial2);

            LlamadaProvincial provincial3 = new LlamadaProvincial("8093332475", "8096017300", 210, 3);
            centralita.RegistrarLlamada(provincial3);


            //Informe
            centralita.GenerarInforme();





        }

    }
}