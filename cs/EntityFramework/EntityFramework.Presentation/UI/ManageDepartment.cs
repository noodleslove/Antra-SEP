using EntityFramework.Infrastructure.Services;
using EntityFramwork.Core.Entities;
using EntityFramwork.Core.Models.RequestModel;

namespace EntityFramework.Presentation.UI;

public class ManageDepartment
{
    private DepartmentService _departmentService = new DepartmentService();
    
    private void AddDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Console.Write("Enter Name => ");
        departmentRequestModel.Name = Console.ReadLine();
        Console.Write("Enter Location => ");
        departmentRequestModel.Location = Console.ReadLine();
        
        _departmentService.AddDepartment(departmentRequestModel);
    }

    private void DeleteDepartment()
    {
        Console.Write("Enter Id => ");
        int id = Convert.ToInt32(Console.ReadLine());
        
        // _departmentRepository.Delete(id);
    }

    private void UpdateDepartment()
    {
        Department department = new Department();
        Console.Write("Enter Id => ");
        department.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name => ");
        department.Name = Console.ReadLine();
        Console.Write("Enter Location => ");
        department.Location = Console.ReadLine();
        
        // _departmentRepository.Update(department);
    }

    private void PrintAll()
    {
        var departments = _departmentService.GetAllDepartment();

        Console.WriteLine("Department");
        Console.WriteLine(" Name\t| Location");
        Console.WriteLine("-------------------");
        foreach (var department in departments)
        {
            Console.WriteLine($"{department.Name}\t| {department.Location}");
        }
    }

    private void PrintById()
    {
        Console.Write("Enter Id => ");
        int id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentService.GetById(id);

        Console.WriteLine(" Name\t| Location");
        Console.WriteLine("-------------------");
        Console.WriteLine($"{department.Name}\t| {department.Location}");
    }

    public void Run()
    {
        // AddDepartment();
        PrintAll();
    }
}