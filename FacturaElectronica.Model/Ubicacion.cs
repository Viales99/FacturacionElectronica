using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Ubicacion
    {

        [Key]
        public int Id { get; set; }

        public string Provincia { get; set; }

        public string Canton { get; set; }

        public string Distrito { get; set; }

        public string Barrio { get; set; }

        public string OtrasSenas { get; set; }
    }
}
