using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDotNetProject.Business.Interfaces.NonGeneric
{
    public interface IEmployee
    {
        string EmployeeName { get; set; }

        int EmployeeAge { get; set; }

        string EmployeeAddress { get; set; }

        double EmployeeSalary { get; set; }

        int EmployeeStatus { get; set; }
    }
}
