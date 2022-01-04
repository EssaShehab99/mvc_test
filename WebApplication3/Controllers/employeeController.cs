using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class employeeController : Controller
    {
        public Employee GetEmployee()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Essa";
            employee.Age = 20;
            employee.CityNo = 1;

            return employee;
        }
        public IActionResult Index()
        {
            Employee employee = GetEmployee();
            return View(employee);
        }
        public IActionResult Edit()
        {
            Employee employee = GetEmployee();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
           return View("Index",employee);
        }
    }
}
