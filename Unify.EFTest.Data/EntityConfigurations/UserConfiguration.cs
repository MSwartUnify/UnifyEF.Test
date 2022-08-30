using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unify.EFTest.Data.EntityModels;

namespace Unify.EFTest.Data.EntityConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(t => t.Id);

        // One-to-many relationship
        builder
            .HasOne(s => s.Department)
            .WithMany(g => g.Users)
            .HasForeignKey(s => s.DepartmentId);
    }
}