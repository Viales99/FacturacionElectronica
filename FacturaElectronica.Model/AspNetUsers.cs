using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class AspNetUsers
    {
        [Key]
        public string Id { get; set; }
        public string Email { get; set; }
        [Required]
        public Boolean EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public Boolean PhoneNumberConfirmed { get; set; }
        [Required]
        public Boolean TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        [Required]
        public Boolean LockoutEnabled { get; set; }
        [Required]
        public int AccessFailedCount { get; set; }
        [Required]
        public string UserName { get; set; }
        public int IdUsuario { get; set; }
        public int TipoIdentificacion { get; set; }

    }
}
