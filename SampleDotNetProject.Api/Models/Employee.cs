using SampleDotNetProject.Business.Interfaces.NonGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetProject.Api.Models
{
    public class Employee : IEmployee
    {
        public string EmployeeName { get; set; }
        
        public int EmployeeAge { get; set; }
        
        public string EmployeeAddress { get; set; }
        
        public double EmployeeSalary { get; set; }
        
        public int EmployeeStatus { get; set; }
    }
}
