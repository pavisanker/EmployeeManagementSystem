using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        public string Department {  get; set; }
    }
}
