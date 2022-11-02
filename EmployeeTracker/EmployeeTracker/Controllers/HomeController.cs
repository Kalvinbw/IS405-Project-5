using EmployeeTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Controllers
{
    public class HomeController : Controller
    {

        private StudentDBContext _context { get; set; }

        public HomeController(StudentDBContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var dataSet = _context.Student.ToList();
            return View(dataSet);
        }
    }
}
