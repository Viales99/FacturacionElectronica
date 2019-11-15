using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class OtrosCargos
    {

        [Key]
        public int IdCargo { get; set; }
        public int NumeroDeLinea { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroIdentidadTercero { get; set; }
        public string NombreTercero { get; set; }
        public string Detalle { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal MontoCargo { get; set; }

    }
}
