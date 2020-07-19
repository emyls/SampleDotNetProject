using System;

namespace SampleDotNetProject.Entity.Model
{
    public class Employee
    {
        public Employee() => JoinedDate = DateTime.Now; 

        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int EmployeeAge { get; set; }

        public string EmployeeAddress { get; set; }

        public double EmployeeSalary { get; set; }

        public DateTime JoinedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int EmployeeStatus { get; set; }
    }
}
