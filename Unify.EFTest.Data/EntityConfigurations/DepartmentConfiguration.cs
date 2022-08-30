using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unify.EFTest.Data.EntityModels;

namespace Unify.EFTest.Data.EntityConfigurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<DepartmentEntity>
{
    public void Configure(EntityTypeBuilder<DepartmentEntity> builder)
    {
        builder.ToTable("Departments");
        builder.HasKey(t => t.Id);

        builder
            .Property(t => t.DepartmentName)
            .HasMaxLength(20);
    }
}