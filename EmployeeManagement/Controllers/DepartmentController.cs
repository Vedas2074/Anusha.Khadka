using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Models;
namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
         public IActionResult Index()
        {
            Department department1 = new Department()
            {
                Id = 103,
                DepartmentName = "Finance",
                DepartmentNo = 770,
                Floor = "3rd",
                Salary = 3000000
            };
            Department department2 = new Department()
            {
                Id = 104,
                DepartmentName = "HR",
                DepartmentNo = 800,
                Floor = "1st",
                Salary = 8900000
            };
            Department department3 = new Department()
            {
                Id = 105,
                DepartmentName = "Marketing",
                 DepartmentNo = 900,
                 Floor = "2nd",
                Salary = 8500000
            };
            List<Department> departments =  new List<Department>() {department1, department2,department3};

            return View(departments);
        }
        public ActionResult Add()
        {
            
            return View();

        }
        [HttpPost]
         public string Add(Department department)
        {
            
            return "Record Saved";

        }  
    }
}