using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure
{
    public class RolPermissionConfig : IEntityTypeConfiguration<RolPermission>
    {
        public void Configure(EntityTypeBuilder<RolPermission> builder)
        {
            builder.HasKey(x => new { x.IdRol, x.IdPermission });
            builder.HasOne(x => x.Rol)
                .WithMany(x => x.RolPermission)
                .HasForeignKey(x => x.IdRol);
            builder.HasOne(x => x.Permission)
                .WithMany(x => x.RolPermission)
                .HasForeignKey(x => x.IdPermission);
        }
    }
}
