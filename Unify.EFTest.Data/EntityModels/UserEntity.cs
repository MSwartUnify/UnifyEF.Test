using Unify.EFTest.Data.Enums;

namespace Unify.EFTest.Data.EntityModels;

/// <summary>
/// The user table from the SQL database
/// </summary>
public class UserEntity : BaseEntity
{
    /// <summary>
    /// FirstName
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// LastName
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Role
    /// </summary>
    public RolesEnum Role { get; set; }

    /// <summary>
    /// Department Id
    /// </summary>
    public int DepartmentId { get; set; }

    /// <summary>
    /// The department this user has a relationship with
    /// </summary>
    public DepartmentEntity Department { get; set; }
}