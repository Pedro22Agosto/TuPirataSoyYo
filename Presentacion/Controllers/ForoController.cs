using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class ForoController : Controller
    {
        //Controlador hecho por Pedro Lanza
        public IActionResult Index()
        {
            return View();
        }
    }
}
