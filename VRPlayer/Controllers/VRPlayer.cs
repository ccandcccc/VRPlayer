using Microsoft.AspNetCore.Mvc;

namespace VRPlayer.Controllers
{
    public class VRPlayer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

 
        public IActionResult Ifm()
        {

            return View();
        }
    }
}
