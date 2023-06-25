using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeProjectSolution.Models
{
    public class CafeData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Location { get; set; }
        public string Logo { get; set; }
        
        [NotMapped]
        public string NumberOfEmployees { get; set; }
    }
}
