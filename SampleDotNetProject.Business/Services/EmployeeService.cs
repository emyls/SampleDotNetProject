using SampleDotNetProject.Business.Interfaces.NonGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDotNetProject.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Core.Interfaces.NonGeneric.IEmployee CreateNewEmployee(Interfaces.NonGeneric.IEmployee newEmployee)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAnEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Core.Interfaces.NonGeneric.IEmployee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Core.Interfaces.NonGeneric.IEmployee GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Core.Interfaces.NonGeneric.IEmployee UpdateAnExistingEmployee(int emploeeId, Interfaces.NonGeneric.IEmployee modifiedEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
