using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportistas
{
    interface ITransportista
    {
        void EnvioLocal(Paquete unPaquete);
        void EnvioLargaDistancia(Paquete unPaquete);
        void CalcularCostoDeEnvio(Paquete unPaquete);

    }
}
