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
        private float monto;

        public float Monto { get => monto; set => monto = value; }

        public void insercion(int monto)
        {

        }

        public void extraccion(int monto, tipoDeExtraccion tipo)
        {

        }
    }
}
