using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Impuesto
    {

        [Key]
        public int IdImpuesto { get; set; }
        public int NumeroLinea { get; set; }
        public string Codigo { get; set; }
        public string CodigoTarifa { get; set; }
        public decimal Tarifa { get; set; }
        public decimal FactorIVA { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoExportacion { get; set; }
    }
}
