using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Unify.EFTest.Data.EntityModels;

namespace Unify.EFTest.Data;

/// <summary>
/// Inheriting the DbContext to use EF
/// </summary>
public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    /// <summary>
    /// Adding configurations to the model builder
    /// </summary>
    /// <param name="builder"></param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        base.OnModelCreating(builder);
    }

    /// <summary>
    /// DB sets for all the entities 
    /// </summary>
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<DepartmentEntity> Departments { get; set; }
}