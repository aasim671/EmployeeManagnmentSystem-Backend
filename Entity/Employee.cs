using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagnmentSystem_Backend.Entity
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
