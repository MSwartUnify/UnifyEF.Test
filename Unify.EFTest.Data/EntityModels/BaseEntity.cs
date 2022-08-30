namespace Unify.EFTest.Data.EntityModels;

/// <summary>
/// Abstract class to be used by all entities
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// All entities will have a unique identifier called Id
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Date created date
    /// </summary>
    public DateTime Created { get; set; }
}