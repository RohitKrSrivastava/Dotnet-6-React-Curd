using CafeAPI.DbContexts;
using CafeAPI.Models;

namespace CafeAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CafeDbContext _dbContext;

        public EmployeeRepository(CafeDbContext context)
        {
            _dbContext = context;
        }
        public string AddEmployee(EmployeesData addEmployee)
        {
            try
            {
                _dbContext.EmployeesData.Add(addEmployee);
                _dbContext.SaveChanges();
                return addEmployee.Id;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool DeleteEmployee(EmployeesData employeeData)
        {
            var result = false;
            try
            {
                var findEmployee = _dbContext.EmployeesData.Find(employeeData.Id);

            if (findEmployee != null) {
                _dbContext.Remove(findEmployee);
                _dbContext.SaveChanges();
                result = true;
            }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<EmployeesData> GetAllEmployee()
        {
            try 
            { 
                var allEmployee = _dbContext.EmployeesData.ToList();
                return allEmployee;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool UpdateEmployee(EmployeesData employeeData)
        {
            var result = false;
            try
            {
                var employeesDetail = _dbContext.EmployeesData.Find(employeeData.Id);

                if (employeesDetail != null)
                {
                    employeesDetail.Name = employeeData.Name;
                    employeesDetail.Gender = employeeData.Gender;
                    employeesDetail.EmailAddress = employeeData.EmailAddress;
                    employeesDetail.PhoneNumber = employeeData.PhoneNumber;

                    _dbContext.SaveChanges();
                    result = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
