using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportistas
{
    class Programa
    {
        static void Main(string[] args)
        {
            UPS ups = new UPS();

            Paquete playStation = new Paquete(8);

            Cliente jose = new Cliente(ups, playStation);

            jose.ElegirTransportista();

        


            Console.ReadKey();
        }
    }
}
