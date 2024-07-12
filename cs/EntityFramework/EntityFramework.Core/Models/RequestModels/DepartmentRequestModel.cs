using System.ComponentModel.DataAnnotations;

namespace EntityFramwork.Core.Models.RequestModel;

public class DepartmentRequestModel
{
    [Required(ErrorMessage = "Department name is required")]
    [StringLength(256)]
    public string? Name { get; set; }
    public string Location { get; set; }
}