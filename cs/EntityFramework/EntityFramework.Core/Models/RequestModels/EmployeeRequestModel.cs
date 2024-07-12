using System.ComponentModel.DataAnnotations;

namespace EntityFramwork.Core.Models.RequestModel;

public class EmployeeRequestModel
{
    [Required(ErrorMessage = "Employee name is required")]
    [StringLength(256)]
    public string? Name { get; set; }
    public int Age { get; set; }
}