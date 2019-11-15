using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class CodigoTipoMoneda
    {
        [Key]
        public string CodigoMoneda { get; set; }

        public string TipoMoneda { get; set; }

        public decimal TipoCambio { get; set; }
 
    }
}
