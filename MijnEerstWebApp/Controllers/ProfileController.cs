using Microsoft.AspNetCore.Mvc;
using MijnEerstWebApp.Models;

namespace MijnEerstWebApp.Controllers
{
    public class ProfileController : Controller

    {
        public IActionResult AboutMe()
        {
            var vm = new ProfileViewModel { FirstName = "Thomas", LastName = "Coppens", Address = "Schildersstraat 2, 9040 Sint-Amandsberg (Gent)", DOB = "21/04/1983", DrivingLicense = true };
            return View(vm);
        }
    }
}
