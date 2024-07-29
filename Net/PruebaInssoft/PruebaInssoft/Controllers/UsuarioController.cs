using Microsoft.AspNetCore.Mvc;

namespace PruebaInssoft.Controllers
{
    public class UsuarioController : Controller
    {
         public IActionResult Index()
         {
             return View();

         }


        public string Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return ("Hello " + name);
        }

    }
}
