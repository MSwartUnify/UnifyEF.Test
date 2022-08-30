using Microsoft.EntityFrameworkCore;
using Unify.EFTest.Data;
using Unify.EFTest.Data.EntityModels;

namespace Unify.EFTest.Service.Departments;

public class DepartmentService : IDepartmentService
{
    private readonly DatabaseContext _DatabaseContext;

    public DepartmentService(DatabaseContext databaseContext)
    {
        _DatabaseContext = databaseContext;
    }

    /// <inheritdoc />
    public IEnumerable<DepartmentEntity> GetDepartmentsWithUsers()
    {
        var departmentsWithUsers = _DatabaseContext
            .Departments
            .Include(t=>t.Users)
            .AsNoTracking()
            .ToList();

        return departmentsWithUsers;
    }
    
    /// <inheritdoc />
    public IEnumerable<DepartmentEntity> GetDepartments()
    {
        var departments = _DatabaseContext
            .Departments
            .AsNoTracking()
            .ToList();

        return departments;
    }
}