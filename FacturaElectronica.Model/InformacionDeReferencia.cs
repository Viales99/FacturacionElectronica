using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class InformacionDeReferencia
    {

        [Key]
        public int IdReferencia { get; set; }

        public int NumeroDeFactura { get; set; }

        public string TipoDoc { get; set; }

        public string Numero { get; set; }

        public DateTime FechaEmision { get; set; }

        public string Codigo { get; set; }

        public string Razon { get; set; }
    }
}
