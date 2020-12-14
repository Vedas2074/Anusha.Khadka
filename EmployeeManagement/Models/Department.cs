using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id {get; set;}

        [Required(ErrorMessage="Department name Required!!")]
        public string DepartmentName {get;  set;}
        
         public int DepartmentNo {get;  set;}
        
            public string Floor {get;  set;}
        public float Salary { get; set;}


        public static List<Department> GetDepartments()
            {Department department1 = new Department()
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

            return departments;
            }
    }
}
    

