using Microsoft.AspNetCore.Mvc;
using MijnEerstWebApp.Models;

namespace MijnEerstWebApp.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            var vm = new InfoViewModel { Age = 38, FirstName = "Thomas", LastName = "Coppens" };
            return View(vm);
        }
    }
}
