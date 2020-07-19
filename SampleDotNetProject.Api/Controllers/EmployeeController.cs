using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleDotNetProject.Api.Dtos;
using SampleDotNetProject.Api.Helpers;
using SampleDotNetProject.Api.Models;
using SampleDotNetProject.Business.Interfaces.NonGeneric;

namespace SampleDotNetProject.Api.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("")]
        public JsonResult GetAllEmployee()
        {
            try
            {
                return new JsonResult(_employeeService.GetAllEmployees());
            }
            catch(Exception ex)
            {
                return new JsonResult(ResponseValidation.GetHTTPStatusCode(ex));
            }
        }

        [HttpGet]
        [Route("{employeeId}")]
        public JsonResult GetEmployeeById(int employeeId)
        {
            try
            {
                return new JsonResult(_employeeService.GetEmployeeById(employeeId));
            }
            catch (Exception ex)
            {
                return new JsonResult(ResponseValidation.GetHTTPStatusCode(ex));
            }
        }

        [HttpPost]
        [Route("")]
        public JsonResult CreateNewtEmployee([FromBody] EmployeeToAdd employeeToAdd)
        {
            try
            {
                var newEmployee = new Employee()
                {
                    EmployeeAddress = employeeToAdd.Address,
                    EmployeeAge = employeeToAdd.Age,
                    EmployeeName = employeeToAdd.Name,
                    EmployeeSalary = employeeToAdd.Salary
                };

                return new JsonResult(_employeeService.CreateNewEmployee(newEmployee));
            }
            catch (Exception ex)
            {
                return new JsonResult(ResponseValidation.GetHTTPStatusCode(ex));
            }
        }

        [HttpPut]
        [Route("{employeeId}")]
        public JsonResult UpdateAnExistingEmployee(int employeeId, [FromBody] EmployeeToUpdate employeeToUpdate)
        {
            try
            {
                var modifiedEmployee = new Employee
                {
                    EmployeeAddress = employeeToUpdate.Address,
                    EmployeeAge = employeeToUpdate.Age,
                    EmployeeName = employeeToUpdate.Name,
                    EmployeeSalary = employeeToUpdate.Salary,
                    EmployeeStatus = employeeToUpdate.Status
                };

                return new JsonResult(_employeeService.UpdateAnExistingEmployee(employeeId, modifiedEmployee));
            }
            catch (Exception ex)
            {
                return new JsonResult(ResponseValidation.GetHTTPStatusCode(ex));
            }
        }

        [HttpDelete]
        [Route("{employeeId}")]
        public JsonResult DeleteAnEmployee(int employeeId)
        {
            try
            {
                return new JsonResult(_employeeService.DeleteAnEmployee(employeeId));
            }
            catch (Exception ex)
            {
                return new JsonResult(ResponseValidation.GetHTTPStatusCode(ex));
            }
        }
    }
}
