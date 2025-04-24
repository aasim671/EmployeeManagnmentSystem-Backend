using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagnmentSystem_Backend.Entity
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

         public string? Phone

            { get; set; }
        public string? JobTitle { get; set; }
        public DateTime? JoiningData { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Department?  Department { get; set; }
        [ForeignKey(nameof(Department))]
        public int? DepartmentId { get; set; }

    }
}
