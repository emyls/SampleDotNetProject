using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetProject.Api.Dtos
{
    public class EmployeeToUpdate : EmployeeToAdd
    {
        public int Status { get; set; }
    }
}
