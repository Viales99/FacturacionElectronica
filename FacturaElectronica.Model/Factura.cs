using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Factura
    {
        [Key]
        public int NumeroDeFactura { get; set; }
        public int Id { get; set; }
        public string CodigoActividad { get; set; }
        public string Clave { get; set; }
        public DateTime FechaEmision { get; set; }
        public string CondicionVenta { get; set; }
        public string PlazoCredito { get; set; }
        public string TipoMoneda  { get; set; }
        public string MedioPago { get; set; }

}
}
