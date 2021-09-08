using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    enum tipoDeExtraccion
    {
        cajeroHumano = 1,
        cajeroAutomatico = 2
    }
    class Cuenta
    {
        private float fondo;

        public float Fondo { get => fondo; set => fondo = value; }

        public virtual void insercion(int monto)
        {
            fondo += monto;
        }

        public virtual void extraccion(int monto, tipoDeExtraccion tipo)
        {

        }
    }
}
