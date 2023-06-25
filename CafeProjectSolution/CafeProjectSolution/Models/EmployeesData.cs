using System.ComponentModel.DataAnnotations;

namespace CafeProjectSolution.Models
{
    public class EmployeesData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public int Gender { get; set; }
    }
}
