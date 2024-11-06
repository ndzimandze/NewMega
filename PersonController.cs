using Microsoft.AspNetCore.Mvc;
using STUDENT.Models;

namespace STUDENT.Controllers
{
    public class PersonController : Controller
    {
        private readonly MongoDbContext _context;

        public PersonController()
        {
            _context = new MongoDbContext("your_mongodb_connection_string", "your_database_name");
        }

        public IActionResult Index()
        {
            var persons = _context.GetAllPersons();
            return View(persons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _context.CreatePerson(person);
            return RedirectToAction("Index");
        }

        public IActionResult Details(string id)
        {
            var person = _context.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }
    }

    internal class MongoDbContext
    {
        private string v1;
        private string v2;

        public MongoDbContext(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        internal void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        internal void CreatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        internal string? GetAllPersons()
        {
            throw new NotImplementedException();
        }

        internal Task? GetCustomerByEmailAsync(string? email)
        {
            throw new NotImplementedException();
#pragma warning disable CS0162 // Unreachable code detected
            return Task.CompletedTask;
#pragma warning restore CS0162 // Unreachable code detected
        }

        internal string? GetPersonById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
