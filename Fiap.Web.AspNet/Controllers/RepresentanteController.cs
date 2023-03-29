using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet.Controllers
{
    public class RepresentanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }
    }
}
