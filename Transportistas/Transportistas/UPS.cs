using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportistas
{
    class UPS : ITransportista
    {
        

        public UPS() {
            
        }

        public void EnvioLocal(Paquete unPaquete) {
            Console.WriteLine("Envio Local segun UPS");
        }

        public void EnvioLargaDistancia(Paquete unPaquete) {
            Console.WriteLine("Envio Larga distancia segun UPS");
        }

        public void CalcularCostoDeEnvio(Paquete unPaquete) {
            Console.WriteLine("Costo de envio segun UPS");

        }
    }
}
