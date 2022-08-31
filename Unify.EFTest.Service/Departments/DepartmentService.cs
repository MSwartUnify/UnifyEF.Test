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
        
        // -->
        // The above LINQ will generate the following SQL query 
        // -->
        
        // SELECT [t].[Id], 
        // [t].[Created], 
        // [t].[DepartmentName], 
        // [t.Users].[Id],
        // [t.Users].[Created],
        // [t.Users].[FirstName],
        // [t.Users].[LastName],
        // [t.Users].[Role]
        // FROM [Departments] AS [t]
        // LEFT JOIN [Users] AS [t.Users] ON [t].[Id] = [t.Users].[DepartmentId]

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
    
    /// <inheritdoc />
    public IEnumerable<DepartmentEntity> GetDepartmentsWithClients()
    {
        var departments = _DatabaseContext
            .Departments
            .Include(t=>t.Users)
            .AsNoTracking()
            .ToList();

        return departments;
    }
}