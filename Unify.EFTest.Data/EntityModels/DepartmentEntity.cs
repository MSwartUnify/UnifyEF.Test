namespace Unify.EFTest.Data.EntityModels;

/// <summary>
/// The department table from the SQL database
/// </summary>
public class DepartmentEntity: BaseEntity
{
    /// <summary>
    /// Department Name
    /// </summary>
    public string DepartmentName { get; set; }
    
    /// <summary>
    /// The list of users from relationship
    /// </summary>
    public ICollection<UserEntity> Users { get; set; }
}