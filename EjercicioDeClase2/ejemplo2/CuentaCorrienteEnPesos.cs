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
            if (fondo <= -5000)
            {
                Console.WriteLine("No posee fondos suficientes.\n");
            }


            if(tipo == tipoDeExtraccion.cajeroAutomatico && monto<=20000)
            {
                fondo -= monto;
            }
            else
            {
                Console.WriteLine("En este cajero se puede extraer hasta $20000");
            }
        }
    }
}
