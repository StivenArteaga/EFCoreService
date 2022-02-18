using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName)
                .IsRequired()
                .HasMaxLength(20);
            builder.HasOne(x => x.Rol)
                .WithOne(c => c.User)
                .HasForeignKey<User>(x => x.IdRol);

            builder.HasData(new User
            {
                Id = 1,
                FullName ="User Admin",
                IdRol = 1,
            },
            new User
            {
                Id=2,
                FullName="User Standar",
                IdRol = 2,
            });
        }
    }
}
