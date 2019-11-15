using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Exoneracion
    {
        [Key]
        public int IdExoneracion { get; set; }
        public int NumeroDeFactura { get; set; }
        public string Tipodocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreInstitucion { get; set; }
        public DateTime FechaEmision { get; set; }
        public int PorcentajeExoneracion { get; set; }
        public decimal MontoExoneracion { get; set; }

    }
}
