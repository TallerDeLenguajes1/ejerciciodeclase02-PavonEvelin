using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class CajaDeAhorroEnPesos : Cuenta
    {
        public override void extraccion(int monto, tipoDeExtraccion tipo)
        {
            if (fondo == 0)
            {
                Console.WriteLine("No posee fondos suficientes.\n");
            }

            if (tipo == tipoDeExtraccion.cajeroAutomatico && monto <= 10000)
            {
                fondo -= monto;
            }
            else
            {
                Console.WriteLine("Solo se puede extraer $10000");
            }
            
        }
    }
}
