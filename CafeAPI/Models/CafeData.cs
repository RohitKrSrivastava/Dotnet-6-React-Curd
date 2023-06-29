using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeAPI.Models
{
    public class CafeData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Location { get; set; }
        public byte[] Logo { get; set; }
        
        [ForeignKey("CafeId")]
        public ICollection<EmployeesData> Employees { get; set; }
        
    }
}
