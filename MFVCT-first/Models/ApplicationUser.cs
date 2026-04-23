using System;
using System.Collections.Generic;
using backendconfigconecta.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace backendconfigconecta.Models
{
    // IdentityUser já tem Email, PasswordHash, etc. (tabela AspNetUsers)
    public class ApplicationUser : IdentityUser
    {
       public string Nome { get; set; } = string.Empty;
       // Campo customizado - não confundi com Roles do Identity
       public Perfil perfil { get; set; }
       public string Tipo { get; set; } = string.Empty;
    }
}