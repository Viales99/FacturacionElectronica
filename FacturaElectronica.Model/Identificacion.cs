using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Identificacion
    {
        [Key]
        public int Id { get; set; }

        public string Tipo { get; set; }

        public string Numero { get; set; }

    }
}
