using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaElectronica.Model
{
    public class AspNetUserRoles
    {

        [Required, Key]
        [Column(" UserId", Order = 0)]
        public string UserId { get; set; }

        [Required, Key]
        [Column(" RoleId", Order = 1)]
        public string RoleId { get; set; }

    }
}
