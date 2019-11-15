using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class ResumenFactura
    {
        [Key]
        public int IdResumen { get; set; }
        public int NumeroDeFactura { get; set; }
        public decimal TotalServGravados { get; set; }
        public decimal TotalServExentos { get; set; }
        public decimal TotalServExonerado { get; set; }
        public decimal TotalMercanciasGravadas { get; set; }
        public decimal TotalMercanciasExentas { get; set; }
        public decimal TotalMercExonerada { get; set; }
        public decimal TotalGravado { get; set; }
        public decimal TotalExento { get; set; }
        public decimal TotalExonerado { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal TotalDescuentos { get; set; }
        public decimal TotalVentaNeta { get; set; }
        public decimal TotalImpuesto { get; set; }
        public decimal TotalIVADevuelto { get; set; }
        public decimal TotalOtrosCargos { get; set; }
        public decimal TotalComprobante { get; set; }
    }
}
