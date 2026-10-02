using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class B_Pago
    {
        private readonly PagoFactory factory;

        public B_Pago(PagoFactory factor    )
        {
            factory = factor;
        }

        public E_Pago Procesar (string tipo, string cliente, decimal monto)
        {
            ValidarDatos(cliente, monto);
            E_Pago pago = factory.Crear(tipo, cliente, monto);
            return pago;
        }

        private void ValidarDatos(string cliente, decimal monto)
        {
            if(string.IsNullOrWhiteSpace(cliente))
            {
                throw new Exception("El nombre no puede estar vacio");
            }

            if(monto <= 0)
            {
                throw new Exception("El monto no puede ser menor o igual a 0");
            }                
        }
    }
}
