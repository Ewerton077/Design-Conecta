using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace backendconfigconecta.Controllers;

// Restringe acesso a usuários com role "Aluno" 
[Authorize(Roles = "Aluno")]
public class AlunoController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Posts() => View();
}