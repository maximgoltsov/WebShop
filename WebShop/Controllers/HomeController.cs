using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Surname = "Ivanov",
                FirstName = "Ivan",
                Patronymic = "Ivanovich",
                Age = 50,
                BirthDay = new DateTime()
            },
            new Employee
            {
                Id = 2,
                Surname = "Ivanov2",
                FirstName = "Ivan2",
                Patronymic = "Ivanovich2",
                Age = 52,
                BirthDay = new DateTime().AddDays(3)
            },
            new Employee
            {
                Id = 3,
                Surname = "Ivanov3",
                FirstName = "Ivan3",
                Patronymic = "Ivanovich3",
                Age = 53,
                BirthDay = new DateTime().AddDays(5)
            },
        };
        public IActionResult Index()
        {
            return View(__Employees);
        }
        public IActionResult Employee(int id)
        {
            var employee = __Employees.FirstOrDefault(e => e.Id == id);
            if (employee is null) return NotFound();
            return View(employee);
        }
    }
}
