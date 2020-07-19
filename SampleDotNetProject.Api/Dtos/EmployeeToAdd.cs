using SampleDotNetProject.Business.Interfaces.NonGeneric;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetProject.Api.Dtos
{
    public class EmployeeToAdd
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Salary { get; set; }
    }
}
