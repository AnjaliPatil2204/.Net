using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                return Content("Form Submitted Successfully");
            }

            return View(student);
        }
    }
}