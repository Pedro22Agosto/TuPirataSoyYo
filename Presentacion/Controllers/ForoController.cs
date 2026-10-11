using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class ForoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
