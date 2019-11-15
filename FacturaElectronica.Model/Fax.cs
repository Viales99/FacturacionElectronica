using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Fax
    {

        [Key]
        public int Id { get; set; }

        public int NumTelefono { get; set; }

        public string CodigoPais { get; set; }
    }
}
