using Microsoft.AspNetCore.Mvc;
using Orchidb.Models;
namespace Orchidb.Controllers
{
    public class EmployeeController : Controller
    {
        public DatabaseContext _context;
       
        public EmployeeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee em)
        {
            if (ModelState.IsValid)
            {
                var e = new Employee()
                {
                    Name = em.Name,
                    Email = em.Email,
                    Salary = em.Salary,
                    Description = em.Description
                };
                _context.Employees.Add(e);
                _context.SaveChanges();
                TempData["msg"] = "Saved";
                return View();
            }
            else
            {
                TempData["error"] = "Some error ocured";
                return View();
            }
        }

    }
}
