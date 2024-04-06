using Microsoft.AspNetCore.Mvc;

namespace Practica.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
