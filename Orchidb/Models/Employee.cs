using System.ComponentModel.DataAnnotations;

namespace Orchidb.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public float Salary { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}
