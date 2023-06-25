using CafeProjectSolution.DbContexts;
using CafeProjectSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CafeProjectSolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataController : ControllerBase
    {
        private readonly CafeDbContext _dbContext;

        public EmployeeDataController(CafeDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var allEmployees = await _dbContext.EmployeesData.ToListAsync();
            return Ok(allEmployees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeesData addEmployee)
        {
            var newEmployee = new EmployeesData()
            {
                Id = "UI" + Guid.NewGuid().ToString().Split("-")[0],
                Name = addEmployee.Name,
                EmailAddress = addEmployee.EmailAddress,
                Gender = addEmployee.Gender,
                PhoneNumber = addEmployee.PhoneNumber

            };
            await _dbContext.EmployeesData.AddAsync(newEmployee);
            await _dbContext.SaveChangesAsync();
            return Ok(newEmployee);

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCafeById([FromRoute] string id)
        {
            var employee = await _dbContext.EmployeesData.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCafe(EmployeesData employeeData)
        {
            var employeesDetail = await _dbContext.EmployeesData.FindAsync(employeeData.Id);

            if (employeesDetail != null)
            {
                employeesDetail.Name = employeeData.Name;
                employeesDetail.Gender = employeeData.Gender;
                employeesDetail.EmailAddress = employeeData.EmailAddress;
                employeesDetail.PhoneNumber = employeeData.PhoneNumber;

                await _dbContext.SaveChangesAsync();
                return Ok(employeesDetail);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            var employeeDetail = await _dbContext.EmployeesData.FindAsync(id); ;
            if (employeeDetail != null)
            {
                _dbContext.Remove(employeeDetail);
                _dbContext.SaveChanges();
                return Ok(employeeDetail);
            }
            return NotFound();
        }
    }
}
