using Entities;

namespace Business
{
    public class PagoFactory
    {        
        public E_Pago Crear(string tipo, string cliente, decimal monto)
        {
            E_Pago pago;

            if(tipo.ToLower() == "tarjeta")
            {
                pago = new PagoTarjeta();
            }
            else if (tipo.ToLower() == "transferencia")
            {
                pago = new PagoTransferencia();
            }
            else if (tipo.ToLower() == "efectivo")
            {
                pago = new PagoEfectivo();
            }
            else
            {
                throw new ArgumentException("Tipo de pago no existente");
            }

            pago.Cliente = cliente;
            pago.Monto = monto;
            return pago;
        }
    }
}
