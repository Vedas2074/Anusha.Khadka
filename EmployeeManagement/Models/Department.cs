using System.ComponentModel.DataAnnotations;
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
    }
}
