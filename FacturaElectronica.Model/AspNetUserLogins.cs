using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaElectronica.Model
{
    public class AspNetUserLogins
    {
        [Required, Key]
        [Column(" LoginProvider", Order = 0)]
        public string LoginProvider { get; set; }
        [Required, Key]
        [Column(" ProviderKey", Order = 1)]
        public string ProviderKey { get; set; }
        [Required, Key]
        [Column(" UserId", Order = 2)]
        public string UserId { get; set; }

    }
}
