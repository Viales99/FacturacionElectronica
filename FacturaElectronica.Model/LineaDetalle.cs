using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class LineaDetalle
    {

        [Key]
        public int NumeroLinea { get; set; }
        public int NumeroDeFactura { get; set; }
        public string PartidaArancelaria { get; set; }
        public string Codigo { get; set; }
        public decimal Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string UnidadMedidaComercial { get; set; }
        public string Detalle { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal SubTotal { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal ImpuestoNeto { get; set; }
        public decimal MontoTotalLinea { get; set; }

    }
}
