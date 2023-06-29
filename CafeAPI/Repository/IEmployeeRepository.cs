using CafeAPI.Models;

namespace CafeAPI.Repository
{
    public interface IEmployeeRepository
    {
        public List<EmployeesData> GetAllEmployee();
        public string AddEmployee(EmployeesData addEmployee);
        public bool UpdateEmployee(EmployeesData employeeData);
        public bool DeleteEmployee(EmployeesData employeeData);
    }
}
