using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task3.Mdels
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        [ForeignKey("CompanyID")]
       public ICollection<Employee> Employees { get; set; }
    }
}
