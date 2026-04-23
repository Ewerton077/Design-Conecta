using backendconfigconecta.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backendconfigconecta.Data;

// IdentityDbContext já inclui as tabelas de Users, Roles, UserRoles, etc.
public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { } 
}

