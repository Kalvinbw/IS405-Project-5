using EmployeeTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmployeeTracker.Models.ViewModels;

namespace EmployeeTracker.Controllers
{
    public class HomeController : Controller
    {

        private IStudentRepository _context;

        public HomeController(IStudentRepository student)
        {
            _context = student;
        }

        public IActionResult Index()
        {
            //var dataSet = _context.Student
            //    .Include(x => x.Class)
            //    .ToList();
            //return View(dataSet);
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View("Edit");
        }

        [HttpPost]
        public IActionResult Form(Student s)
        {
            if (ModelState.IsValid)

            {
                _context.CreateStudent(s);
                _context.SaveStudent(s);
                return View("Index", s);
            }
            else
            {
                ViewBag.Student = _context.Students.ToList();
                return View("Edit", s);
            }
        }

        public IActionResult employees()
        {
            var x = new StudentViewModel
            {
                //TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                //.OrderBy(t => t.Time)
                Students = _context.Students.OrderBy(x => x.LastName)
            };

            return View(x);
        }

        [HttpGet]
        public IActionResult Edit(string byuID)
        {

            ViewBag.Students = _context.Students.ToList();
            var studEntry = _context.Students.Single(x => x.BYUID == byuID);

            return View(studEntry);
        }
    }
}
