using CafeAPI.Services;
using CafeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("allEmployeeList")]
        public IActionResult GetAllEmployee()
        {
            try
            {
                return Ok(_employeeService.GetAllEmployee());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("addEmployeeDetails")]
        public IActionResult AddEmployee(EmployeesData employeeData)
        {
            try
            {
                return Ok(_employeeService.AddEmployee(employeeData));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("updateEmployeeDetails")]
        public IActionResult UpdateEmployee(EmployeesData employeeData)
        {
            try
            {
                return Ok(_employeeService.UpdateEmployee(employeeData));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        [Route("removeEmployee")]
        public IActionResult DeleteEmployee(EmployeesData employeesData)
        {
            try
            {
                return Ok(_employeeService.DeleteEmployee(employeesData));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
