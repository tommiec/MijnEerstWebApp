using Microsoft.AspNetCore.Mvc;
using MijnEerstWebApp.Models;

namespace MijnEerstWebApp.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Gent()
        {
            var vm = new LocationViewModel { Address = "Schildersstraat 2", PC = "9040", City = "Sint-Amandsberg", Country = "België"  };
            return View(vm);
        }
    }
}
