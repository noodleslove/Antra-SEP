using EntityFramework.Infrastructure.Services;
using EntityFramwork.Core.Models.RequestModel;

namespace EntityFramework.Presentation.UI;

public class ManageEmployee
{
    private EmployeeService _employeeService = new();

    private void AddEmployee()
    {
        EmployeeRequestModel employeeRequestModel = new EmployeeRequestModel();
        Console.Write("Please enter employee name => ");
        employeeRequestModel.Name = Console.ReadLine();
        Console.Write("Please enter employee age => ");
        employeeRequestModel.Age = Convert.ToInt32(Console.ReadLine());
        
        _employeeService.AddEmployee(employeeRequestModel);
    }

    private void PrintAllEmployee()
    {
        var employees = _employeeService.GetAllEmployees();

        Console.WriteLine("Employee");
        Console.WriteLine(" Name\t| Age");
        Console.WriteLine("-------------------");
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name}\t{employee.Age}");
        }
    }

    private void GetEmployeeById()
    {
        Console.Write("Please enter employee age => ");
        int id = Convert.ToInt32(Console.ReadLine());
        var employee = _employeeService.GetById(id);

        Console.WriteLine(" Name\t| Age");
        Console.WriteLine("-------------------");
        Console.WriteLine($"{employee.Name}\t{employee.Age}");
    }

    public void Run()
    {
        // AddEmployee();
        PrintAllEmployee();
    }
}