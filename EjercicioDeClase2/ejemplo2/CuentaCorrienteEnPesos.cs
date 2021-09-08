using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class CuentaCorrienteEnPesos : Cuenta
    {

        public override void extraccion(int monto, tipoDeExtraccion tipo)
        {
            if(fondo <= -5000)
            {
                Console.WriteLine("No tiene fondos suficientes\n");
            }
            else if(tipo == 2 && monto>20000)
            {
                Console.WriteLine("solo se puede extraer $20000");
            }

            Fondo -= monto;
        }
    }
}
