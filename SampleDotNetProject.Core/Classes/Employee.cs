using SampleDotNetProject.Core.Interfaces.NonGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDotNetProject.Core.Classes
{
    public class Employee : IEmployee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public double Salary { get; set; }

        public DateTime JoinedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int Status { get; set; }
    }
}
