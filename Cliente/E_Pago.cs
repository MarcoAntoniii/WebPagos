namespace Entities
{
    public class E_Pago
    {
        public string Cliente { get; set; }

        public decimal Monto { get; set; }

        public virtual decimal CalcularComision()
        {
            return 0;
        }

        public virtual string ObtenerMetodoPago()
        {
            return "Desconocido";
        }
    }

    public class PagoTarjeta : E_Pago
    {
        public override decimal CalcularComision()
        {
            return Monto * 0.035m;
        }

        public override string ObtenerMetodoPago()
        {
            return "Tarjeta";
        }
    }
    public class PagoTransferencia : E_Pago
    {
        public override decimal CalcularComision()
        {
            return 10;
        }

        public override string ObtenerMetodoPago()
        {
            return "Transferencia";
        }
    }
    public class PagoEfectivo : E_Pago
    {
        public override decimal CalcularComision()
        {
            return 0;
        }

        public override string ObtenerMetodoPago()
        {
            return "Efectivo";
        }
    }
}
