using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class CuentaCorrienteEnDolares : Cuenta
    {
        public override void extraccion(int monto, tipoDeExtraccion tipo)
        {
            if (monto > 200)
            {
                Console.WriteLine("Solo se puede extraer USD$200");
            }

            fondo -= monto;
        }
    }
}
