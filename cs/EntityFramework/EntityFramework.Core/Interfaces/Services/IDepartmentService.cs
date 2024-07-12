using EntityFramwork.Core.Models.RequestModel;
using EntityFramwork.Core.Models.ResponseModels;

namespace EntityFramwork.Core.Interfaces.Services;

public interface IDepartmentService
{
    List<DepartmentResponseModel> GetAllDepartment();
    DepartmentResponseModel? GetById(int id);
    int AddDepartment(DepartmentRequestModel model);
}