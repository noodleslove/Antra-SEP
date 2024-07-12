using EntityFramework.Infrastructure.Repositories;
using EntityFramwork.Core.Entities;
using EntityFramwork.Core.Interfaces.Services;
using EntityFramwork.Core.Models.RequestModel;
using EntityFramwork.Core.Models.ResponseModels;

namespace EntityFramework.Infrastructure.Services;

public class DepartmentService : IDepartmentService
{
    private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();

    public List<DepartmentResponseModel> GetAllDepartment()
    {
        var departments = _departmentRepository.GetAll();

        return departments.Select(department => new DepartmentResponseModel
            { Name = department.Name, Location = department.Location }).ToList();
    }

    public DepartmentResponseModel? GetById(int id)
    {
        var department = _departmentRepository.GetById(id);

        if (department != null)
        {
            return new DepartmentResponseModel
            {
                Name = department.Name,
                Location = department.Location
            };
        }

        return null;
    }

    public int AddDepartment(DepartmentRequestModel model)
    {
        var department = new Department
        {
            Name = model.Name,
            Location = model.Location
        };

        return _departmentRepository.Insert(department);
    }
}