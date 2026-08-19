using Microsoft.AspNetCore.Mvc;

namespace MVC2026;

public class ClientesController : Controller 
{
    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }


}
