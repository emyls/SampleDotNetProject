using SampleDotNetProject.Core.Interfaces.NonGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDotNetProject.Business.Interfaces.NonGeneric
{
    public interface IEmployeeService
    {
        IEnumerable<Core.Interfaces.NonGeneric.IEmployee> GetAllEmployees();

        Core.Interfaces.NonGeneric.IEmployee GetEmployeeById(int employeeId);

        Core.Interfaces.NonGeneric.IEmployee CreateNewEmployee(IEmployee newEmployee);

        Core.Interfaces.NonGeneric.IEmployee UpdateAnExistingEmployee(int employeeId, IEmployee modifiedEmployee);

        bool DeleteAnEmployee(int employeeId);
    }
}
