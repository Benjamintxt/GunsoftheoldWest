using GunsoftheoldWest.Ui.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Core;
using System.Diagnostics;

namespace GunsoftheoldWest.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeopleManagerDbContext _peopleManagerDbContext;

        public HomeController(PeopleManagerDbContext peopleManagerDbContext)
        {
            _peopleManagerDbContext = peopleManagerDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sales()
        {
            return View();
        }

        public IActionResult Winner()
        {
            
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
