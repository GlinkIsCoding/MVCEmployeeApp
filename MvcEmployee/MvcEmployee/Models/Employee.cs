using System.ComponentModel.DataAnnotations;

namespace EmployeeMvc.Models
{
    //Employee Model
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        //Backend RFC validation regarding format and length
        [RegularExpression(@"^[A-Z0-9]{13}$", ErrorMessage = "RFC must have 13 alphanumeric characters in capital letters.")]
        public required string RFC { get; set; }
        [DataType(DataType.Date)]
        public DateTime BornDate { get; set; }
        public EmployeeStatus Status { get; set; }
    }

    public enum EmployeeStatus
    {
        NotSet,
        Active,
        Inactive
    }
}

