using Microsoft.AspNetCore.Mvc;
using MijnEerstWebApp.Models;

namespace MijnEerstWebApp.Controllers
{
    public class HobbyController : Controller
    {
        public IActionResult Hobby()
        {
            var vm = new ProfileViewModel { FirstName="Thomas", LastName="Coppens", Hobbies = "Familie, fietsen, film en muziek" };

            return View(vm);
        }
    }
}
