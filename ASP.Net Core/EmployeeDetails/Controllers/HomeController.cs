using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> model = new List<Employee>()
            {
                new Employee {  Id = 4, Name = "Mark", Salary = 5000,IsPermanent = false }
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult GetEmployeeList()
        //{
        //    List<Employee> lst = new List<Employee>()
        //    {

        //    };
        //    return View("Index",lst);
        //}

        public IActionResult GetEmployeeList()
        {
            List<Employee> model = new List<Employee>()
            {
                   new Employee()
                    {
                    Id = 1,
                    Name = "John",
                    Salary = 10000,
                    IsPermanent = true
                    },
                    new Employee()
                    {
                    Id = 2,
                    Name = "Mary",
                    Salary = 5000,
                    IsPermanent = false
                    },
                    new Employee()
                    {
                    Id = 3,
                    Name = "Smith",
                    Salary = 5000,
                    IsPermanent = false
                    },
                    new Employee()
                    {
                    Id = 4,
                    Name = "Mark",
                    Salary = 5000,
                    IsPermanent = false
                    }
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
