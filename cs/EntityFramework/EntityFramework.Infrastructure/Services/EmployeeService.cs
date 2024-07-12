using EntityFramework.Infrastructure.Repositories;
using EntityFramwork.Core.Entities;
using EntityFramwork.Core.Interfaces.Services;
using EntityFramwork.Core.Models.RequestModel;
using EntityFramwork.Core.Models.ResponseModels;

namespace EntityFramework.Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();

    public List<EmployeeResponseModel> GetAllEmployees()
    {
        var employees = _employeeRepository.GetAll();
        var employeeModels = new List<EmployeeResponseModel>();

        foreach (var employee in employees)
        {
            employeeModels.Add(new EmployeeResponseModel
            {
                Age = employee.Age,
                Name = employee.Name
            });
        }

        return employeeModels;
    }

    public EmployeeResponseModel? GetById(int id)
    {
        var employee = _employeeRepository.GetById(id);
        
        if (employee != null)
        {
            return new EmployeeResponseModel
            {
                Age = employee.Age,
                Name = employee.Name
            };
        }

        return null;
    }

    public int AddEmployee(EmployeeRequestModel model)
    {
        var employee = new Employee
        {
            Age = model.Age,
            Name = model.Name,
            DepartmentId = 1
        };

        return _employeeRepository.Insert(employee);
    }
}