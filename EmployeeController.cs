﻿using hashi_project.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace hashi_project.Controllers
{
    public class EmployeeController : Controller
    {
       
        private List<Employee> _employees;
        public IEnumerable<Employee> Employees { get { return _employees; } }

        public EmployeeController()
        {
            _employees = new List<Employee>
            {
                new Employee { Id = 0, Name = "Martin", Surname = "Simpson", BirthDate = new DateTime(1992, 12, 3), Position = "Marketing Expert", Image="/images/Martin.jpg" },
                new Employee { Id = 1, Name = "Jacob", Surname = "Hawk", BirthDate = new DateTime(1995, 10, 2), Position = "Manager", Image="/images/Jacob.jpg" },
                new Employee { Id = 2, Name = "Elizabeth", Surname = "Geil", BirthDate = new DateTime(2000, 1, 7), Position = "Software Engineer", Image="/images/Elizabeth.jpg" },
                new Employee { Id = 3, Name = "Kate", Surname = "Metain", BirthDate = new DateTime(1997, 2, 13), Position = "Admin", Image="/images/Kate.jpg" },
                new Employee { Id = 4, Name = "Michael", Surname = "Cook", BirthDate = new DateTime(1990, 12, 25), Position = "Marketing Expert", Image="/images/Michael.jpg" },
                new Employee { Id = 5, Name = "John", Surname = "Snow", BirthDate = new DateTime(2001, 7, 15), Position = "Software Engineer", Image="/images/John.jpg" },
                new Employee { Id = 6, Name = "Nina", Surname = "Soprano", BirthDate = new DateTime(1999, 9, 30), Position = "Software Engineer", Image="/images/Nina.jpg" },
                new Employee { Id = 7, Name = "Tina", Surname = "Fins", BirthDate = new DateTime(2000, 5, 14), Position = "Team Leader", Image="/images/Tina.jpg" }
            };

         

        }

        public IActionResult Index()
        {
            ViewBag.Layout = "_Lab2Layout"; // Set the layout for Index
                                            // Your existing logic to get employees
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Layout = "_Lab2Layout";

            // Find the employee with the specified ID.
            var employee = _employees.FirstOrDefault(e => e.Id == id);

            // Return the employee object to the view.
            return View(employee);
        }

    }


}
