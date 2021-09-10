using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    public enum tipoDeExtraccion
    {
        cajeroHumano = 1,
        cajeroAutomatico = 2
    }
    class Cuenta
    {
        protected float fondo;

        public float Fondo { get => fondo; set => fondo = value; }

        public void insercion(int monto)
        {
            fondo += monto;
        }

        public virtual void extraccion(int monto, tipoDeExtraccion tipo)
        {
            //todas las cuentas comparten extraer todo el monto por cajero humano.
            if(tipo == tipoDeExtraccion.cajeroHumano)
            {
                fondo -= monto;
            }
        }
    }
}
