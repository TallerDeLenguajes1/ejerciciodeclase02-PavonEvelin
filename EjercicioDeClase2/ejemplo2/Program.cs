using System;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaCorrientePesos = new CuentaCorrienteEnPesos();
            Cuenta cuentaCorrienteDolares = new CuentaCorrienteEnDolares();
            Cuenta cajaAhorroPesos = new CajaDeAhorroEnPesos();


        }
    }
}
