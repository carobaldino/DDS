using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportistas
{
    class Cliente
    {
        ITransportista transportista;
        Paquete paquete;

        public Cliente(ITransportista t, Paquete p) {
            transportista = t;
            paquete = p;
        }
/*
        public ITransportista GetTransportista()
        {
            return this._transportista;
        }

        public void SetTransportista (ITransportista value)
        {
            this._transportista = value;
        }

        public Paquete GetPaquete()
        {
            return this._paquete;
        }

        public void SetPaquete(Paquete value)
        {
            this._paquete = value;
        }
        */

        public void ElegirTransportista() {
            Console.WriteLine("El transportista seleccionado es " + transportista.ToString());
            EnviarPaquete();
        }

        public void EnviarPaquete() {
            transportista.CalcularCostoDeEnvio(paquete);
        }
    }
}
