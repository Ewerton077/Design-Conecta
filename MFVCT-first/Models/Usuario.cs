using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backendconfigconecta.Models;

    public class Usuario
    {
        public string nome { get; set; } = String.Empty;
        public string email { get; set; } = String.Empty;

        public int Idade { get; set; }
        public string tipo { get; set; } = string.Empty;
    }
