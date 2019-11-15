using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Descuento
    {
        [Key]
        public int IdDescuento { get; set; }
        public int NumeroLinea { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal NaturalezaDescuento { get; set; }
    }
}
