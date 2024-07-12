using EntityFramwork.Core.Models.RequestModel;
using EntityFramwork.Core.Models.ResponseModels;

namespace EntityFramwork.Core.Interfaces.Services;

public interface IEmployeeService
{
    List<EmployeeResponseModel> GetAllEmployees();
    EmployeeResponseModel? GetById(int id);
    int AddEmployee(EmployeeRequestModel model);
}