﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacturaElectronica.Model
{
    public class Emisor
    {

        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string NombreComercial { get; set; }

    }
}
