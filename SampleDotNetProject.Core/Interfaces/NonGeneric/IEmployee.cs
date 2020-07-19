using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDotNetProject.Core.Interfaces.NonGeneric
{
    public interface IEmployee
    {
        int EmployeeID { get; set; }

        string Name { get; set; }

         int Age { get; set; }

        string Address { get; set; }

        double Salary { get; set; }

        DateTime JoinedDate { get; set; }

        DateTime UpdatedDate { get; set; }

        int Status { get; set; }
    }
}
