using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Correo
    {
        [Key]
        public int Id { get; set; }

        public string CorreoElectronico { get; set; }
    }
}
