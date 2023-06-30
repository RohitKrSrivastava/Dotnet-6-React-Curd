using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeAPI.Models
{
    public class EmployeesData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public int Gender { get; set; }

        [NotMapped]
        public string CafeName { get; set; }
        public string CafeId { get; set; }
        //public CafeData Cafe { get; set; }
    }
}
