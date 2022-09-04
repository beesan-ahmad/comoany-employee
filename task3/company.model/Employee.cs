using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task3.Mdels
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public Company Company { get; set; }

    }
}