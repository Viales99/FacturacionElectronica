using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FacturaElectronica.Model
{
    public class AspNetRoles
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
