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
                Id = 1,
                DepartmentName = "HR",
                DepartmentNo = 678 ,
                Salary = 1546312
            };
            Department department2 = new Department()
            {
                Id = 2,
                DepartmentName = "Finance",
                DepartmentNo= 123 ,
                Salary = 6312155
            };
            Department department3 = new Department()
            {
                Id = 3,
                DepartmentName = "Account",
                DepartmentNo= 990 ,
                Salary = 633565
            };
            List<Department> departments =  new List<Department>() {department1, department2 ,department3};

            return View(departments);
        }
    }
}