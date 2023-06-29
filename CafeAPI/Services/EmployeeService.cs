using CafeAPI.Models;
using CafeAPI.Repository;

namespace CafeAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string AddEmployee(EmployeesData addEmployee)
        {
            var newEmployee = new EmployeesData()
            {
                Id = "UI" + Guid.NewGuid().ToString().Split("-")[0],
                Name = addEmployee.Name,
                EmailAddress = addEmployee.EmailAddress,
                Gender = addEmployee.Gender,
                PhoneNumber = addEmployee.PhoneNumber
            };

            return _employeeRepository.AddEmployee(newEmployee);
        }

        public bool DeleteEmployee(EmployeesData employeeData)
        {
            return _employeeRepository.DeleteEmployee(employeeData);
        }

        public List<EmployeesData> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }

        public bool UpdateEmployee(EmployeesData employeeData)
        {
            return _employeeRepository.UpdateEmployee(employeeData);
        }
    }
}
