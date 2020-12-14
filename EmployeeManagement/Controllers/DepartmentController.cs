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
        
            var department = Department.GetDepartments();

            return View(department);
        }
        
        public ActionResult Detail(int id)
        {
            var departments = Department.GetDepartments();
            var emp = departments.FirstOrDefault(x => x.Id == id);
            return View(emp);

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