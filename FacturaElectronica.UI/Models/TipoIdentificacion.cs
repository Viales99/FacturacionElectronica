using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.UI.Models
{
   
        public enum TipoIdentificacion
        {
            [Display(Name = "Físico")]
            Físico = 1,
            [Display(Name = "Jurídico")]
            Jurídico = 2

        }

}