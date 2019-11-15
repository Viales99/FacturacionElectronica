using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Producto
    {
        [Key, Display(Name = "Código")]
        public string CodigoProducto { get; set; }
        [Display(Name = "Descripción"), DataType(DataType.MultilineText)]
        public string Detalle { get; set; }
        [Range(1, 15), Display(Name = "Porcentaje de Impuesto")]
        public int Impuesto { get; set; }
        [Range(1, 15), Display(Name = "Porcentaje de descuento")]
        public int Descuento { get; set; }
        [Required, Range(1, 100000), Display(Name = "Precio unitario")]
        public int PrecioUnitario { get; set; }
    }
}
