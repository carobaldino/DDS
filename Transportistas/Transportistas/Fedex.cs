using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportistas
{
    class Fedex : ITransportista
    {
        public void EnvioLocal(Paquete unPaquete)
        {
            Console.WriteLine("Envio Local segun Fedex");
        }

        public void EnvioLargaDistancia(Paquete unPaquete)
        {
            Console.WriteLine("Envio Larga distancia segun Fedex");
        }

        public void CalcularCostoDeEnvio(Paquete unPaquete)
        {
            Console.WriteLine("Costo de envio segun Fedex");
        }
    }
}
