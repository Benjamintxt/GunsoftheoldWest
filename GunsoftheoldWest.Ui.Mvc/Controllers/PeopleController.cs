using GunsoftheoldWest.Ui.Mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Core;

namespace GunsoftheoldWest.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleManagerDbContext _peopleManagerDbContext;

        public PeopleController(PeopleManagerDbContext peopleManagerDbContext)
        {
            _peopleManagerDbContext = peopleManagerDbContext;
        
        }
        [HttpGet]
        public IActionResult Index()
        {
            var people = _peopleManagerDbContext.People.ToList();
            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            person.SubmissionDate = DateTime.Now;
            _peopleManagerDbContext.People.Add(person);
            _peopleManagerDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
