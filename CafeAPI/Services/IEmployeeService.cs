using CafeAPI.Models;

namespace CafeAPI.Services
{
    public interface IEmployeeService
    {
        public List<EmployeesData> GetAllEmployee();
        public string AddEmployee(EmployeesData addEmployee);
        public bool UpdateEmployee(EmployeesData EmployeeData);
        public bool DeleteEmployee(EmployeesData EmployeeData);
    }
}
