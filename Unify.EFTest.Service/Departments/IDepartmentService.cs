using Unify.EFTest.Data.EntityModels;

namespace Unify.EFTest.Service.Departments;

public interface IDepartmentService
{
    /// <summary>
    /// Gets the Departments with Users
    /// </summary>
    /// <returns>Departments with users</returns>
    IEnumerable<DepartmentEntity> GetDepartmentsWithUsers();

    /// <summary>
    /// Gets the Departments
    /// </summary>
    /// <returns>Departments</returns>
    IEnumerable<DepartmentEntity> GetDepartments();
}