using Microsoft.AspNetCore.Mvc;
using Unify.EFTest.Data.EntityModels;
using Unify.EFTest.Service.Departments;

namespace Unify.EFTest.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
    private readonly IDepartmentService _DepartmentService;

    public DepartmentController(IDepartmentService departmentService)
    {
        _DepartmentService = departmentService;
    }

    [HttpGet]
    [Route("GetDepartmentsWithUsers")]
    public IEnumerable<DepartmentEntity> GetDepartmentsWithUsers()
    {
        return _DepartmentService.GetDepartmentsWithUsers();
    }

    [HttpGet]
    [Route("GetDepartments")]
    public IEnumerable<DepartmentEntity> GetDepartments()
    {
        return _DepartmentService.GetDepartments();
    }
}