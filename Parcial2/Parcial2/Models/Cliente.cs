﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2.Models
{
    public class Cliente
    {
        public String Lista { get; set; }
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public double Sueldo { get; set; }
    }
}