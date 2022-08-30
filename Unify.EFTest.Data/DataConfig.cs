using System.ComponentModel.DataAnnotations;

namespace Unify.EFTest.Data;

/// <summary>
/// Configuration for connections to SQL Server.
/// </summary>
public class DataConfig
{
    /// <summary>
    /// Connection string used to connect to the SQL Sever.
    /// </summary>
    [Required]
    public string ConnectionString { get; set; }
}
