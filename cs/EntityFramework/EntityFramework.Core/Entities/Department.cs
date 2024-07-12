namespace EntityFramwork.Core.Entities;

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string Location { get; set; }
    
    // navigation property
    public List<Employee> Employees { get; set; }
}