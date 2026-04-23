using backendconfigconecta.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace backendconfigconecta.Data;

public static class SeedData
{
    // Roles do sistema - corresponde ao [Authorize(Roles = "...")] nos controllers
    private static readonly string[] SystemRoles = { "Aluno", "Professor", "Admin" };

    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole>? roleManager = null)
    {
        // Garante que as roles existem no banco antes de atribuí-las
        if (roleManager != null)
        {
            foreach (var role in SystemRoles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        #region O Aluno
        var aluno = await userManager.FindByEmailAsync("aluno@teste.com");
        if (aluno == null)
        {
            aluno = new ApplicationUser
            {
                UserName = "aluno@teste.com",
                Email = "aluno@teste.com",
                perfil = Perfil.Aluno
            };
            await userManager.CreateAsync(aluno, "Aluno@123");
        }
        // Garante que o usuário tenha a role (inclusive se já existir)
        if (!await userManager.IsInRoleAsync(aluno, "Aluno"))
            await userManager.AddToRoleAsync(aluno, "Aluno");
        #endregion

        #region O Professor
        var professor = await userManager.FindByEmailAsync("professor@teste.com");
        if (professor == null)
        {
            professor = new ApplicationUser
            {
                UserName = "professor@teste.com",
                Email = "professor@teste.com",
                perfil = Perfil.Professor
            };
            await userManager.CreateAsync(professor, "Professor@123");
        }
        // Garante que o usuário tenha a role (inclusive se já existir)
        if (!await userManager.IsInRoleAsync(professor, "Professor"))
            await userManager.AddToRoleAsync(professor, "Professor");
        #endregion
    }
}