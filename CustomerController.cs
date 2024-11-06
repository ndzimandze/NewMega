using Microsoft.AspNetCore.Mvc;
using STUDENT.Models;

namespace STUDENT.Controllers
{
    public class CustomerController : Controller
    {
        private readonly MongoDbContext _context;

        public CustomerController()
        {
            _context = new MongoDbContext("your_mongodb_connection_string", "New-Mega");
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.CreateCustomer(customer);
                return RedirectToAction("Login");
            }
            return View(customer);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer customer)
        {
            var dbCustomer = _context.GetCustomerByEmailAsync(customer.Email);
            
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(customer);
            }
        }
    }
}
